﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Database
{
    public class Staff: BindableBase
    {

        private static List<Staff> staffs = new List<Staff>();
        public static List<Staff> Staffs
        {
            get
            {
                return staffs;
            }
        }
        static Staff()
        {
            staffs.AddRange(GetStaffs());
        }
        public static List<Staff> GetStaffs()
        {
            return Mapper.Fetch<Staff>("SELECT * FROM Staff", Constants.CONNECTION_STRING, System.Data.CommandType.Text);
        }


        private string staffId;
        [MapperAtrribute(HeaderName = "StaffId")]
        public string StaffId
        {
            get { return staffId; }
            set {SetProperty(ref staffId, value); }
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
                    using (SqlCommand command = new SqlCommand("procedureCreateStaff", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@paramStaffId", StaffId);
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
            catch(Exception ex) 
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public override string ToString()
        {
            return $"{StaffId}: {Name}";
        }
    }
}
