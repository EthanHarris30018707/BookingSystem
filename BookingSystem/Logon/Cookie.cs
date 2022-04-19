using BookingSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Logon
{
    //Singleton class to store the currently logged in user
    public class Cookie : BindableBase
    {
        private static Lazy<Cookie> instance = new Lazy<Cookie>(() => new Cookie());
        public static Cookie Instance => instance.Value;
        private Cookie()
        {

        }

        private Staff loggedStaff = null;

        public Staff LoggedStaff
        {
            get { return loggedStaff; }
            set {SetProperty(ref loggedStaff, value); }
        }

        private Student loggedStudent = null;

        public Student LoggedStudent
        {
            get { return loggedStudent; }
            set { SetProperty(ref loggedStudent, value); }
        }
    }
}
