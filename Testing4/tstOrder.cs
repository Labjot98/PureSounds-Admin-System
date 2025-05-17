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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the clsOrder class
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 8;  // Use a valid OrderId that exists in your test data
                                  //invoke the method to find the order by OrderId
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true (meaning the order was found)
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 8)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the customer id
            if (AnOrder.CustomerId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order date
            if (AnOrder.OrderDate != Convert.ToDateTime("05/05/2025"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the total amount
            if (AnOrder.TotalAmount != 199)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the status
            if (AnOrder.Status != "Completed")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountAppliedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check if the discount applied is true
            if (AnOrder.DiscountApplied != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 8;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the payment method
            if (AnOrder.PaymentMethod != "Credit Card")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
