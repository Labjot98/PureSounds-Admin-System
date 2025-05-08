using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.OrderId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.CustomerId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Decimal TestData = 50;
            // assign the data to the property
            AnOrder.TotalAmount = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            string TestData = "Completed";
            // assign the data to the property
            AnOrder.Status = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.Status, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrder.StaffId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }

        [TestMethod]
        public void DiscountAppliedPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.DiscountApplied = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.DiscountApplied, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property
            string TestData = "Credit Card";
            // assign the data to the property
            AnOrder.PaymentMethod = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }

    }
}
