using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem
{
    public static class Utility
    {
        public static string EncryptDecrypt(this string value)
        {
            string encrypted = "";
            foreach (char c in value)
            {
                encrypted += (char)('P' ^ c);
            }
            return encrypted;
        }
    }
}
