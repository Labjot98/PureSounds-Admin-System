using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsStockUser AnUser = new clsStockUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of user
            clsStockUser AnUser = new clsStockUser();
            Int32 TestData = 1;
            //assign data to the propery
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            //create test data
            string TestData = "Abdul";
            //assign data to the property
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            //create test data
            string TestData = "Abdul123";
            //assign data to the property
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);

        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            //create test data
            string TestData = "Stock";
            //assign data to the property
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of user class
            clsStockUser AnUser = new clsStockUser();
            //boolean variable to store results of validation
            Boolean Found = false;
            //Create test data 
            string UserName = "Abdul";
            string Password = "Abdul123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the user class
            clsStockUser AnUser = new clsStockUser();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean to record if data is ok
            Boolean OK = true;
            //create test data to use with method
            string UserName = "Abdul";
            string Password = "Abdul123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check that username and pw match
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see result is ok
            Assert.IsTrue(OK);
        }
    }
}
