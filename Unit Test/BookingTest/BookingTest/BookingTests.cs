using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookingSystem;
using BookingSystem.Database;
using System;

namespace BookingTest
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void TestMethod1()   //Tests creating a new student
        {

            string StudentNumber = "0000000004";
            string Name = "Student";
            string Phone = "00000000000";
            string EmailAddress = "email@email.com";
            string Address = "15 Street";
            DateTime DateOfBirth = new DateTime(2000, 02, 02);
            string Password = "123";
            string Postcode = "AA11 1AA";

            Student student = new Student();

            student.StudentNumber = StudentNumber;
            student.Name = Name;
            student.Address = Address;
            student.Postcode = Postcode;
            student.Phone = Phone;
            student.DateOfBirth = DateOfBirth;
            student.Password = Password;
            student.EmailAddress = EmailAddress;

            bool Test = student.Save();

            Assert.IsTrue(Test, "Fail");
        }
        
        public void TestMethod2()   //Tests if the password mathces after its been decrypted
        {
            string password = "123";

            password.Encrypt();

            string decrypted = password.Decrypt();

            Assert.AreEqual(password, decrypted);
        }
    }
}
