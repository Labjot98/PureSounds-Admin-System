using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            Int32 TestData = 1;

            //assign the data to the property
            ACustomer.CustomerId = TestData; 

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFullnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "Jacob Bethell";

            //assign the data to the property
            ACustomer.CustomerFullname = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerFullname, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "jacobbethell25@gmail.com";

            //assign the data to the property
            ACustomer.Email = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "27 Coral Street, Leicester, LE4 5AD";

            //assign the data to the property
            ACustomer.Address = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "jacob04bethell";

            //assign the data to the property
            ACustomer.Password = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void BonusEligibilityActiveProperty()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            ACustomer.BonusEligibility = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.BonusEligibility, TestData);
        }

        [TestMethod]
        public void CreatedOnPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            ACustomer.CreatedOn = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CreatedOn, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 CustomerId = 1;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the address id
            if (ACustomer.CustomerId != 10)
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerFullnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer fullname
            if (ACustomer.CustomerFullname != "Tim David")
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Email != "timdavid@gmail.com")
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Address != "Test Address")
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Password != "Test Password")
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBonusEligibilityFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.BonusEligibility != true)
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCreatedOnFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //create a Boolean variale to store the results of the validation
            Boolean Found = false;

            //create a Boolean variable to record if the data is OK (assume it it)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 10;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.CreatedOn != Convert.ToDateTime("08/05/2025"))
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }
    }
}
