using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see it exists
            Assert.IsNotNull(AnSupplier);
        }
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AnSupplier.Active = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AnSupplier.DateAdded = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.DateAdded, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOk()
        {
            //create instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            Int32 TestData = 31;
            //assign data to the property   
            AnSupplier.SupplierId = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            String TestData = "SuppliersRUS";
            //assign data to the property
            AnSupplier.SupplierName = TestData;
            //test to see two values are the same
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierLocationPropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            String TestData = "Newcastle";
            //assign data to the property
            AnSupplier.SupplierLocation = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierLocation, TestData);
        }
        [TestMethod]
        public void SupplierQualityPropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            String TestData = "Good";
            //assign data to the property
            AnSupplier.SupplierQuality = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierQuality, TestData);
        }
        [TestMethod]
        public void SupplierCostPropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            decimal TestData = 1000;
            //assign data to the property
            AnSupplier.SupplierCost = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierCost, TestData);
        }
        [TestMethod]
        public void SupplierStockAvailablePropertyOk()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSupplier.SupplierStockAvailable = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnSupplier.SupplierStockAvailable, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use within the method
            Int32 SupplierId = 8;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //test method to see if it is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the SupplierId
            if (AnSupplier.SupplierId != 21)
            {
                OK = false;
            }
            //test method to see it is true
            Assert.IsTrue(OK);
        

        }
        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the DateAdded
            if (AnSupplier.DateAdded != Convert.ToDateTime("23/06/22"))
            {
                OK = false;
            }
            //test method to see it is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Name
            if (AnSupplier.SupplierName != ("SupplyRUS"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierLocationFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check location
            if (AnSupplier.SupplierLocation != ("Newcastle"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierQuality()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check quality
            if (AnSupplier.SupplierQuality != ("Great"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierCost()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check cost
            if (AnSupplier.SupplierCost != Convert.ToDecimal("1000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierStockAvailable()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a boolean value to store the result of the search
            Boolean Found = false;
            //create a boolean value to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierStockAvailable != Convert.ToBoolean("true"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
