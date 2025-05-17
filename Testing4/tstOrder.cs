using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string CustomerId = "67890";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalAmount = "99.99";
        string Status = "Processing";
        string PaymentMethod = "Credit Card";

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

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to test
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            // Test to see if the result is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "";       //this should trigger an error
                                          //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "12345";       //this should trigger an ok
                                               //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "123456";       //this should trigger an ok
                                                //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "123456789012";       //this should trigger an ok
                                                      //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "123456789012";       //this should trigger an ok
                                                      //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "123456789";       //this should trigger an ok
                                                   //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "1234567890123";       //this should trigger an error
                                                       //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the test
            string CustomerId = "";
            CustomerId = CustomerId.PadRight(300, '1');     // this should fail
                                                            //invoke the method
            Error = AnOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            //test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*-----------Tests for valid OrderDate-------------*/

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidDate()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string OrderDate = "Some non date value";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        /*------------Tests for Valid TotalAmount */
        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "1";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "1";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "9999999";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "10000";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "99999999";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "";
            TotalAmount = TotalAmount.PadRight(81, '0');
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TotalAmount = "";
            TotalAmount = new string('9', 100);
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        /*------------Tests for Valid Status */
        [TestMethod]
        public void StatusMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "a";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "aa";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatusMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "";
            Status = Status.PadRight(51, 'a');
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StatusExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Status = "";
            Status = Status.PadRight(200, 'a');
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        /*------------Tests for Valid PaymentMethod */
        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "C";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "CC";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "CreditCard";
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "CreditCard12345678901234567890"; // 30 characters
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "CreditCard123456789012345678901"; // 31 characters
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "";
            PaymentMethod = new string('A', 31); // 31 characters
            Error = AOrder.Valid(CustomerId, OrderDate, TotalAmount, Status, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
    }
}
