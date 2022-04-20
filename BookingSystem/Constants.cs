using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    public static class Constants
    {
        public const string CONNECTION_STRING = "BookingSystem.Properties.Settings.Database1ConnectionString";
        public const char ENCRYPT_CHAR = 'P';

        public const int NO_ERROR = 0;
        public const int INVALID_PHONE_NUMBER_ERROR = 1;
        public const int INVALID_NAME_ERROR = 2;
        public const int INVALID_DOB_ERROR = 3;
        public const int PASSWORD_AND_RETYPE_NOT_MATCHING = 4;
        public const int INVALID_EMAIL_ADDRESS = 5;

        public static string ErrorToMessage(this int error)
        {
            switch (error)
            {
                case NO_ERROR:
                    return "No error";
                case INVALID_NAME_ERROR:
                    return "Staff/student name must be at least two charaecters long";
                case INVALID_DOB_ERROR:
                    return "Staff/student must be at least 18 years old";
                case PASSWORD_AND_RETYPE_NOT_MATCHING:
                    return "Password and validate password are not the same";
                case INVALID_PHONE_NUMBER_ERROR:
                    return "Incorrect phone number enterred";
                case INVALID_EMAIL_ADDRESS:
                    return "Email address not in the right format or invalid";
                default:
                    return "Unknown error message";
            }

        }
    }
}
