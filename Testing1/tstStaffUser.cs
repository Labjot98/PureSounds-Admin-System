using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.Text;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnUser.UserID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create some test data to assign to the property
            String TestData = "Dawn";
            // assign the data to the property
            AnUser.UserName = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create some test data to assign to the property
            String TestData = "cbfdac6008f9cab4083784cbd1874f76618d2a97";
            // assign the data to the property
            AnUser.PasswordHash = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnUser.PasswordHash, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create some test data to assign to the property
            String TestData = "Address Book";
            // assign the data to the property
            AnUser.Department = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create a Boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            String UserName = "testuser";
            String Password = "password123";

            // invoke the method
            Found = AnUser.FindUser(UserName, Password);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            // create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            // create a Boolean variable to store the result of the search
            Boolean Found = false;
            //  create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            string UserName = "testuser";
            string Password = "password123";

            // invoke the method
            Found = AnUser.FindUser(UserName, Password);
            // check the user ID and password properties
            if (AnUser.UserName != UserName)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
