using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instacne of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();

            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create some test data to assign to the property
            Int32 TestData = 2;
            // assign the data to the property
            AUser.UserID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create some test data to assign to the property
            String TestData = "John";
            // assign the data to the property
            AUser.UserName = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create some test data to assign to the property
            String TestData = "apassword";
            // assign the data to the property
            AUser.Password = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create some test data to assign to the property
            String TestData = "Customers";
            // assign the data to the property
            AUser.Department = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create a Boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            String UserName = "John";
            String Password = "apassword";
            // invoke the method
            Found = AUser.FindUser(UserName, Password);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            // create an instance of the class we want to create
            clsCustomerUser AUser = new clsCustomerUser();
            // create a Boolean variable to store the result of the search
            Boolean Found = false;
            //  create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            string UserName = "John";
            string Password = "apassword";
            // invoke the method
            Found = AUser.FindUser(UserName, Password);
            // check the user ID and password properties
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
