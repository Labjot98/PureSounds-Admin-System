using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
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
            Int32 StaffID = 5;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the StaffID
            if (AStaff.StaffID !=5)
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
            Int32 StaffId = 4;
            // invoke the method
            Found = AStaff.Find(StaffId);
            // check the Name
            if (AStaff.Name != "Gene Harlow")
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
            Int32 StaffID = 4;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the DateJoined
            if (AStaff.DateJoined != Convert.ToDateTime("04/04/1953"))
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
            Int32 StaffID = 4;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the DateJoined
            if (AStaff.DateLeft != Convert.ToDateTime("05/05/1956"))
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
            Int32 StaffID = 4;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the Name
            if (AStaff.Rank != "Salesperson")
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
            Int32 StaffID = 4;
            // invoke the method
            Found = AStaff.Find(StaffID);
            // check the Name
            if (AStaff.NINumber != "EF444444V")
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
            Int32 StaffID = 4;
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


    }
}
