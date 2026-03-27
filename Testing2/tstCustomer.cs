using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerFullname = "Tim David";
        string Email = "timdavid@gmail.com";
        string Address = "23 Coral Street, Leicester, LE4 5AD";
        string Password = "timdavid23";
        string CreatedOn = DateTime.Now.ToShortDateString();

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
            Int32 CustomerId = 32;

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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the address id
            if (ACustomer.CustomerId != 32)
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer fullname
            if (ACustomer.CustomerFullname != "Jos Buttler")
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Email != "jos.buttler@gmail.com")
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Address != "202 Wand Lane, Manchester, UK")
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.Password != "buttler12345")
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer data for this field
            if (ACustomer.BonusEligibility != false)
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
            Int32 CustomerId = 32;

            //invoke the method
            Found = ACustomer.Find(CustomerId);

            //check the customer email
            if (ACustomer.CreatedOn != Convert.ToDateTime("22/05/2025"))
            {
                OK = false;
            }

            //test to see that the result if correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see if the result is true
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFullnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFullnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFullnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string CustomerFullname = "";       
            CustomerFullname = CustomerFullname.PadRight(300, 'a');     // this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*------------Tests for Valid Email */

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaa@gmail.com";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaaa@gmail.com";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaa@gmail.com";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa@gmail.com";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Email = "";
            Email = Email.PadRight(200, 'a');     // this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        /* -------------Tests for Address------------ */

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Address = "";
            Address = Address.PadRight(400, 'a');     // this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }


        /*-----------Tests for valid password-------------*/
        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an ok

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";       //this should trigger an error

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create some test data to pass to the test
            string Password = "";
            Password = Password.PadRight(100, 'a');     // this should fail

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }


        /*-----------Tests for valid date-------------*/
        [TestMethod]
        public void CreatedOnExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create a date variable to store the test data
            DateTime TestDate;

            //set the TestDate to Today's Date
            TestDate = DateTime.Now.Date;

            //change the date to whatever date was 100 years ago
            TestDate = TestDate.AddYears(-100);

            //convert date variable to string variable
            string CreatedOn = TestDate.ToString();      

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create a date variable to store the test data
            DateTime TestDate;

            //set the TestDate to Today's Date
            TestDate = DateTime.Now.Date;

            //change the date to whatever date was 1 day ago
            TestDate = TestDate.AddYears(-1);

            //convert date variable to string variable
            string CreatedOn = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create a date variable to store the test data
            DateTime TestDate;

            //set the TestDate to Today's Date
            TestDate = DateTime.Now.Date;

            //convert date variable to string variable
            string CreatedOn = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create a date variable to store the test data
            DateTime TestDate;

            //set the TestDate to Today's Date
            TestDate = DateTime.Now.Date;

            //change the date to whatever date is tomorrow
            TestDate = TestDate.AddYears(1);

            //convert date variable to string variable
            string CreatedOn = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //create a date variable to store the test data
            DateTime TestDate;

            //set the TestDate to Today's Date
            TestDate = DateTime.Now.Date;

            //change the date to whatever date is plus 100 years
            TestDate = TestDate.AddYears(100);

            //convert date variable to string variable
            string CreatedOn = TestDate.ToString();

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CreatedOnInvalidDate()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();

            //string variable to store any error message
            string Error = "";

            //set the createdOn value to non date value
            string CreatedOn = "Some non date value";

            //invoke the method
            Error = ACustomer.Valid(CustomerFullname, Email, Address, Password, CreatedOn);

            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
