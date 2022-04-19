using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Database
{
    public class Student: BindableBase
    {

        private static List<Student> students;
        public static List<Student> Students
        {
            get
            {
                return students;
            }
        }
        static Student()
        {
            students.AddRange(GetStudents());
        }
        public static List<Student> GetStudents()
        {
            return Mapper.Fetch<Student>("SELECT * FROM Student", Constants.CONNECTION_STRING, System.Data.CommandType.Text);
        }


        private string studentId;
        [MapperAtrribute(HeaderName = "StudentId")]
        public string StudentId
        {
            get { return studentId; }
            set {SetProperty(ref studentId, value); }
        }

        private string name;
        [MapperAtrribute(HeaderName = "Name")]
        public string Name
        {
            get { return name; }
            set {SetProperty(ref name, value); }
        }

        private string address;
        [MapperAtrribute(HeaderName = "Address")]
        public string Address
        {
            get { return address; }
            set {SetProperty(ref address, value); }
        }

        private string postcode;

        public string Postcode
        {
            get { return postcode; }
            set {SetProperty(ref postcode, value); }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set {SetProperty(ref phone, value); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set {SetProperty(ref password, value); }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set {SetProperty(ref dateOfBirth, value); }
        }

        public bool Save()
        {
            try
            {
                string connection_string = ConfigurationManager.ConnectionStrings[Constants.CONNECTION_STRING].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("procedureCreateStudent", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@paramStudentId", StudentId);
                        command.Parameters.AddWithValue("@paramName",  Name);
                        command.Parameters.AddWithValue("@paramAddress", Address);
                        command.Parameters.AddWithValue("@paramPostcode", Postcode);
                        command.Parameters.AddWithValue("@paramPhone", Phone);
                        command.Parameters.AddWithValue("@paramDateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@paramPassword", Password.Encrypt());

                        int ret = (int)command.ExecuteScalar();
                        return ret == 1;
                    }
                }
            }
            catch 
            {
                return false;
            }
        }
    }
}
