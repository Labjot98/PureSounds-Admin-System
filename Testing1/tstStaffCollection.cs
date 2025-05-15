using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of object
            List<clsStaff> TestList = new List<clsStaff>();
            // Add an Item to the List
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 1;
            TestItem.Name = "Warren Beatty";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Salesperson";
            TestItem.NINumber = "BB123456C";
            TestItem.IsFemale = false;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            Int32 SomeCount = 0;
            // assign the data to the property
            AllStaff.Count = SomeCount; 
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount); 
        }
        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.StaffID = 9;
            TestStaff.Name = "Faye Dunaway";
            TestStaff.DateJoined = DateTime.Now;
            TestStaff.DateLeft = DateTime.Now;
            TestStaff.Rank = "Manager";
            TestStaff.NINumber = "DD123456D";
            TestStaff.IsFemale = true;
            // assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            // Add an item to the List
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // set its properties
            TestItem.StaffID = 9;
            TestItem.Name = "Charlton Heston";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Seller";
            TestItem.NINumber = "EE123456E";
            TestItem.IsFemale = false;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllStaff.StaffList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }



















    }
}
