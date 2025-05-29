using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        // good test data
        // create some test data to pass the method
        String Name = "Phineas Fogg";
        String DateJoined = DateTime.Now.ToShortDateString();
        String DateLeft = DateTime.Now.ToShortDateString();
        String Rank = "Manager";
        String NINumber = "XY123456A";

        /**********************INSTANCE OF THE CLASS TEST********************/

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }
                
        /*******************PROPERTY OKAY TESTS******************************/
        
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AStaff.StaffID = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Orson Welles";
            // assign the data to the property
            AStaff.Name = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void StaffDateJoinedPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            // assign the data to the property
            AStaff.DateJoined = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }

        [TestMethod]
        public void StaffDateLeftPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            // assign the data to the property
            AStaff.DateLeft = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.DateLeft, TestData);
        }

        [TestMethod]
        public void StaffRankPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Senior Salesperson";
            // assign the data to the property
            AStaff.Rank = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.Rank, TestData);
        }

        [TestMethod]
        public void StaffNINumberPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "NH 323334 B";
            // assign the data to the property
            AStaff.NINumber = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.NINumber, TestData);
        }

        [TestMethod]
        public void StaffIsFemaleOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            Boolean TestData = false;
            // assign the data to the property
            AStaff.IsFemale = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AStaff.IsFemale, TestData);
        }

        /**********************FIND METHOD TEST*******************************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 5;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /**********************PROPERTY DATA TESTS****************************/

        [TestMethod]
        public void TestStaffIDFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found  = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the StaffID
            if (AStaff.StaffID !=6)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffId = 6;
            // invoke the method
            Found = AStaff.Find(StaffId);
            // check the Name
            if (AStaff.Name != "Heddy Lamarr")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the DateJoined
            if (AStaff.DateJoined != Convert.ToDateTime("06/06/1966"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateLeftFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the DateJoined
            if (AStaff.DateLeft != Convert.ToDateTime("07/07/1977"))
                        {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRankFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the Name
            if (AStaff.Rank != "Manager")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNINumberFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the Name
            if (AStaff.NINumber != "KK111111B")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsFemaleFound()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // create a Boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            // create some test data to use with the method
            Int32 StaffID = 6;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the Name
            if (AStaff.IsFemale != true)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = ""; // this should trigger an error
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "a"; // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "aa"; // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            Name = Name.PadLeft(49, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            Name = Name.PadLeft(50, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            Name = Name.PadLeft(25, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            Name = Name.PadLeft(51, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Name = "";
            Name = Name.PadLeft(1000, '*'); // this should be fail
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            // convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            // convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // set the DateJoined to a non-date value
            string DateJoined = "this is not a date!";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateLeftExtremeMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            // convert the date variable to a string variable
            string DateLeft = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateLeftMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            // convert the date variable to a string variable
            string DateLeft = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateLeftMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // convert the date variable to a string variable
            string DateLeft = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateLeftMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            // convert the date variable to a string variable
            string DateLeft = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateLeftExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create a variable to store the test date data to pass
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            // convert the date variable to a string variable
            string DateLeft = TestDate.ToString();
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateLeftInvalidData()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // set the DateJoined to a non-date value
            string DateLeft = "this is not a date!";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void RankMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = ""; // this should trigger an error
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RankMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "a"; // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RankMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "aa"; // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RankMaxMinusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "";
            Rank = Rank.PadLeft(29, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RankMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "";
            Rank = Rank.PadLeft(30, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RankMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "";
            Rank = Rank.PadLeft(15, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RankMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "";
            Rank = Rank.PadLeft(31, '*'); // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RankExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string Rank = "";
            Rank = Rank.PadLeft(1000, '*'); // this should be fail
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////


        [TestMethod]
        public void NINumberMinLessOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "12345678"; // this should trigger an error
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberMin()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "AA123456A"; // this should be okay
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NINumberMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "AA123456AA"; // this should fail
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberMid()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "12345"; // just should fail
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "";
            NINumber = NINumber.PadLeft(1000, '*'); // this should be fail
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberNotAlphaInFirstPlace()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "1A123456A";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberNotAlphaInSecondPlace()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "A1123456A";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberNotDigitInMiddle()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "AA123B56A";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NINumberNotAlphaInFinalPlace()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create a variable to store the results of the validation
            String Error = "";
            // create some test data to pass to the method
            string NINumber = "AA1234567";
            // invoke the method
            Error = AStaff.Valid(Name, DateJoined, DateLeft, Rank, NINumber);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
