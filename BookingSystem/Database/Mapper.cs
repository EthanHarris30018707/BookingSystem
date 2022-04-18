using FastMember;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Database
{
    public static class Mapper
    {
        public static List<T> Fetch<T>(string command_string, string connectionStringName, string parameterName, object parameterValue, CommandType command_type = CommandType.Text) where T : new()
        {
            string connection_string = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            var connection = new SqlConnection(connection_string);
            connection.Open();
            var command = new SqlCommand(command_string, connection);
            command.Parameters.AddWithValue(parameterName, parameterValue);
            //command.Prepare();
            return FetchCommand<T>(command_type, command);
        }
        public static List<T> Fetch<T>(string command_string, string connectionStringName, CommandType command_type = CommandType.Text) where T : new()
        {
            string connection_string = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            var connection = new SqlConnection(connection_string);
            connection.Open();
            var command = new SqlCommand(command_string, connection);
            return FetchCommand<T>(command_type, command);
        }

        private static List<T> FetchCommand<T>(CommandType command_type, SqlCommand command) where T : new()
        {
            List<T> values = new List<T>();
            try
            {
                command.CommandType = command_type;
                using (var r = command.ExecuteReader())
                {
                    var columns = r.GetColumns();
                    GetDictionaryValues<T>(out var mappings, columns);

                    while (r.Read())
                    {
                        values.Add(Selector<T>(r, mappings, columns));
                    }
                }
            }
            finally
            {
                command.Connection.Close();
                command.Dispose();
            }
            return values;
        }

        private static void GetDictionaryValues<T>(out Dictionary<string, int> mappings,
            string[] columns) where T : new()
        {
            Type type = typeof(T);
            var properties = type.GetProperties().ToArray();
            mappings = properties.PropertiesDict(columns);
        }

        private static string[] GetColumns(this SqlDataReader reader)
        {
            string[] names = new string[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++)
            {
                names[i] = reader.GetName(i);
            }
            return names;
        }

        private static T Selector<T>(SqlDataReader data, Dictionary<string, int> mappings,
            string[] columns) where T : new()
        {
            var instance = new T();
            var accessor = TypeAccessor.Create(typeof(T));

            foreach (var map in mappings)
            {
                SetProperty(data, map, instance, accessor);
            }
            return instance;
        }

        private static Dictionary<string, int> PropertiesDict(this PropertyInfo[] props, string[] columns)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var p in props)
            {
                var ind = Array.IndexOf<string>(columns, p.GetMappingName());
                if (ind >= 0)
                {
                    dict[p.Name] = ind;
                }
            }
            return dict;
        }

        private static void SetProperty<T>(IDataRecord row, KeyValuePair<string, int> map,
            T instance, TypeAccessor accessor) where T : new()
        {
            object value = row[map.Value];
            if (!(value is DBNull))
            {
                accessor[instance, map.Key] = value;
            }
        }

        private static string GetMappingName(this PropertyInfo info)
        {
            MapperAtrribute attribute = info.GetCustomAttributes<MapperAtrribute>(false).FirstOrDefault();
            return attribute == null ? info.Name : attribute.HeaderName;
        }
    }
}
