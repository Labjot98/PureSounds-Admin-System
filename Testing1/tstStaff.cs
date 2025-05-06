using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }

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

    }
}
