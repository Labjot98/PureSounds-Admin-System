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

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffID = 1;
            TestItem.Name = "John Wayne";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Chief";
            TestItem.NINumber = "F123456GG";
            TestItem.IsFemale = false;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set primary key of the test data
            TestItem.StaffID = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the two values are equal
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Name = "Greta Garbo";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Loner";
            TestItem.NINumber = "G123456HH";
            TestItem.IsFemale = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set primary key of the test data
            TestItem.StaffID = PrimaryKey;
            // modify the test record
            TestItem.Name = "John Garfied";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Manager";
            TestItem.NINumber = "K123456LL";
            TestItem.IsFemale = false;
            // set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            // update the record
            AllStaff.Update();
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see if ThisAddress matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.Name = "Sophia Loren";
            TestItem.DateJoined = DateTime.Now;
            TestItem.DateLeft = DateTime.Now;
            TestItem.Rank = "Salesperson";
            TestItem.NINumber = "L123456SS";
            TestItem.IsFemale = true;
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record
            PrimaryKey = AllStaff.Add();
            // set primary key of the test data
            TestItem.StaffID = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // delete the record
            AllStaff.Delete();
            // now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }


    }
}
