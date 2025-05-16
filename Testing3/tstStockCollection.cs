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
            TestItem.ItemName = "testing";
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
            TestStock.ItemName = "testing";
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
            TestItem.ItemName = "testing";
            TestItem.DatePosted = DateTime.Now;
            TestItem.Brand = "testingbrand";
            TestItem.Quantity = 40;
            TestItem.Price = 99.99m;

            TestList.Add(TestItem);

            ALLStock.StockList = TestList;

            Assert.AreEqual(ALLStock.Count, TestList.Count);

        }

    
    }
}
