using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
     



        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();

            Assert.IsNotNull(ALLStock);

        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();
            //create test data to assign
            //data needs to be a list of objects
            List<clsStock1> TestList = new List<clsStock1>();
            //add to the list
            //create the item of test data
            clsStock1 TestItem = new clsStock1();
            TestItem.Bluetooth = true;
            TestItem.ItemID = 1;
            TestItem.ItemName = "testinggg";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand";
            TestItem.Quantity = 40;
            TestItem.Price = 99.99m;


            TestList.Add(TestItem);

            ALLStock.StockList = TestList;

            Assert.AreEqual(ALLStock.StockList, TestList);
        }

        

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();

            clsStock1 TestStock = new clsStock1();
            TestStock.Bluetooth = true;
            TestStock.ItemID = 1;
            TestStock.ItemName = "testinggg";
            TestStock.DatePosted = DateTime.Now;
            TestStock.Brand = "testingbrand";
            TestStock.Quantity = 40;
            TestStock.Price = 99.99m;

            ALLStock.ThisStock = TestStock;
            Assert.AreEqual(ALLStock.ThisStock, TestStock);


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();

            List<clsStock1> TestList = new List<clsStock1>();

            clsStock1 TestItem = new clsStock1();
            TestItem.Bluetooth = true;
            TestItem.ItemID = 1;
            TestItem.ItemName = "testinggg";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand";
            TestItem.Quantity = 40;
            TestItem.Price = 99.99m;

            TestList.Add(TestItem);

            ALLStock.StockList = TestList;

            Assert.AreEqual(ALLStock.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class we want to create
            clsStockCollection ALLStock = new clsStockCollection();
            

            //variable to store primary key
            int PrimaryKey = 0;

            clsStock1 TestItem = new clsStock1();
            TestItem.Bluetooth = true;
            TestItem.ItemID = 1;
            TestItem.ItemName = "testingAga";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand 3.0";
            TestItem.Quantity = 40;
            TestItem.Price = 99.99m;

            ALLStock.ThisStock = TestItem;

            PrimaryKey = ALLStock.Add();
            TestItem.ItemID = PrimaryKey;

            ALLStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(ALLStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();

            clsStock1 TestItem = new clsStock1();

            int PrimaryKey = 0;

            TestItem.Bluetooth = false;
            TestItem.ItemName = "testingUpdate";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand Update";
            TestItem.Quantity = 50;
            TestItem.Price = 99.99m;

            ALLStock.ThisStock = TestItem;

            //add the record
            PrimaryKey = ALLStock.Add();
            //set primary key of the test data
            TestItem.ItemID = PrimaryKey;

            //modify the test data
            TestItem.Bluetooth = true;
            TestItem.ItemName = "testingUpdate change";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand Update change";
            TestItem.Quantity = 50;
            TestItem.Price = 99.99m;

            //set the record based on the new test data
            ALLStock.ThisStock = TestItem;

            //update the record
            ALLStock.Update();

            //find the record
            ALLStock.ThisStock.Find(PrimaryKey);

            //test to see if it matches the test data
            Assert.AreEqual (ALLStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection ALLStock = new clsStockCollection();
            //create an item of testdata
            clsStock1 TestItem = new clsStock1();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.ItemID = 1;
            TestItem.ItemName = "testingUpdate change";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand Update change";
            TestItem.Quantity = 50;
            TestItem.Price = 99.99m;

            //set thisItem to the test data
            ALLStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = ALLStock.Add();
            //set the primary key of the test data
            TestItem.ItemID = PrimaryKey;
            //find the record
            ALLStock.ThisStock.Find (PrimaryKey);
            //delete the record
            ALLStock.Delete();
            //now find the record
            Boolean Found = ALLStock.ThisStock.Find(PrimaryKey);
            //test to see the record was not found
            Assert.IsFalse (Found);

        }

        [TestMethod]
        public void ReportByItemNameOK()
        {
            //Create an instance of the class
            clsStockCollection ALLStock = new clsStockCollection ();
            //create instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection ();
            //apply a blank string (should return all records)
            FilteredStock.ReportByItemName("");
            //test to see the two attributes are the same
            Assert.AreEqual(FilteredStock.Count, ALLStock.Count);
        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            //create instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a itemname that dosent exist
            FilteredStock.ReportByItemName("qwert trewq");
            //test to see the two attributes are the same
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByItemNameTestDataFound()
        {
            //create an instance if the following data
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;

            //apply an itemname that dosent exist
            FilteredStock.ReportByItemName("testingAgain");
            //check the correct number of records is found

            if(FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].ItemID != 7)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].ItemID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }


    }
}
