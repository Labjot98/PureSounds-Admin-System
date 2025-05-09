using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();

            //test to see if it exists
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            int TestData = 2;
            //assign the data to the property
            aStock.ItemID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.ItemID, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            string TestData = "ThisName";
            //assign the data to the property
            aStock.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.ItemName, TestData);
        }

        [TestMethod]
        public void DatePostedPropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStock.DatePosted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.DatePosted, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            int TestData = 40;
            //assign the data to the property
            aStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Quantity, TestData);
        }

        [TestMethod]
        public void BluetoothPropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aStock.Bluetooth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Bluetooth, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            decimal TestData = 49.99m;
            //assign the data to the property
            aStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Price, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class we are testing
            clsStock1 aStock = new clsStock1();
            //create test data to Assign to the property
            string TestData = "Sony";
            //assign the data to the property
            aStock.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Brand, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to test
            clsStock1 aStock = new clsStock1();
            //create a boolean to store the result
            Boolean Found = false;
            //create test data to use with the method
            int ItemID = 26;
            //invoke the method
            Found = aStock.Find(ItemID);
            Assert.IsTrue(Found);
        }

        //property Data Tests

        [TestMethod]
        public void TestItemIDFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.ItemID != 26)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.ItemName != "bose soundflex")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePostedFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.DatePosted != Convert.ToDateTime("10/07/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.Quantity != 40)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBluetoothFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.Bluetooth != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.Price != 29.99m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestBrandFound()
        {
            clsStock1 aStock = new clsStock1();

            Boolean Found = false;

            Boolean OK = true;

            int ItemID = 26;

            Found = aStock.Find(ItemID);

            if (aStock.Brand != "bose")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }

    
}
