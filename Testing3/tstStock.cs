using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string ItemName = "Bose Soundflex";
        string DatePosted = DateTime.Now.ToShortDateString();
        string Price = "30";
        string Brand = "Bose";
        string Quantity = "50";





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
            int ItemID = 4;
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.ItemID != 4)
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.ItemName != "WaveBoom")
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.DatePosted != Convert.ToDateTime("06/04/2025"))
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.Quantity != 30)
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.Bluetooth != false)
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.Price != 20m)
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

            int ItemID = 4;

            Found = aStock.Find(ItemID);

            if (aStock.Brand != "EcoSounds")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        //Validation Testing

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock1 aStock = new clsStock1();

            //string variable to store error message

            String Error = "";

            //invoke the method

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            //test to see result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";


            String ItemName = ""; //should cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }

        [TestMethod]
        public void ItemNameMin()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "I"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "II"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void ItemNameMax()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII"; //SHOULD cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }

        [TestMethod]
        public void ItemNameMid()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String ItemName = "IIIIIIIIIIIIIIIIIIII"; //SHOULDNT cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";

            String ItemName = "";
            ItemName = ItemName.PadRight(199, 'I'); //SHOULD cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";


            String Brand = ""; //should cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }

        [TestMethod]
        public void BrandMin()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "W"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "WW"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void BrandMax()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"; //SHOULD cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }

        [TestMethod]
        public void BrandMid()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";


            String Brand = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"; //should not cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreEqual(Error, ""); //passes test if there ISNT an Error
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            clsStock1 aStock = new clsStock1();


            String Error = "";

            String Brand = "";
            Brand = Brand.PadRight(299, 'W'); //SHOULD cause an error

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see its correct
            Assert.AreNotEqual(Error, ""); //passes test if there IS an Error
        }


        [TestMethod]
        public void DatePostedExtremeMin()
        {
            
            clsStock1 aStock = new clsStock1();
            
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 50 years
            TestDate = TestDate.AddYears(-50);
            //convert the date variable to a string variable
            string DatePosted = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinLessOne()
        {
            
            clsStock1 aStock = new clsStock1();
            
            String Error = "";
            
            DateTime TestDate;
            
            TestDate = DateTime.Now.Date;
            
            TestDate = TestDate.AddDays(-1);
            
            string DatePosted = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMin()
        {

            clsStock1 aStock = new clsStock1();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string DatePosted = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedMinPlusOne()
        {

            clsStock1 aStock = new clsStock1();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string DatePosted = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedExtremeMax()
        {

            clsStock1 aStock = new clsStock1();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string DatePosted = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePostedInvalidData()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            string DatePosted = "this is not valid Date format";

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); //this should be true, since its the incorrect data type
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 4.99m;

            string Price = TestPrice.ToString();
            
            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the min price is 5.00

        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 5.00m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the min price is 5.00

        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 5.01m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the min price + 0.01 is 5.01

        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 999.99m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max price is 1000.00

        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 1000.00m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max price is 1000.00

        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 1000.01m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the max price is 1000.00

        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 10500.00m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the max price is 1000.00

        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestPrice = 174.99m;

            string Price = TestPrice.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max price is 1000.00 and min is 5.00

        }


        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            string Price = "not a decimal data type";

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since this isnt a correct data type

        }

        //*************************-----Quantity------******************************************


        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = -1;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the min Quantity is 0 - cant have minus Quantity

        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 0;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the min Quantity is 0 

        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            Decimal TestQuantity = 1;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the min + 1 Quantity is 1

        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 999;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max Quantity is 1000

        }

        [TestMethod]
        public void QuantityMax()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 1000;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max quantity is 1000

        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 1001;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the max Quantity is 1001

        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 10000;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since the max Quantity is 1000

        }

        [TestMethod]
        public void QuantityMid()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            int TestQuantity = 100;

            string Quantity = TestQuantity.ToString();

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreEqual(Error, ""); // this should be true, since the max quantity is 1000 and min is 0

        }


        [TestMethod]
        public void QuantityInvalidData()
        {
            clsStock1 aStock = new clsStock1();

            String Error = "";

            string Quantity = "not a decimal data type";

            Error = aStock.Valid(ItemName, Brand, DatePosted, Price, Quantity);

            Assert.AreNotEqual(Error, ""); // this should be true, since this isnt a correct data type

        }

    }

    
}
