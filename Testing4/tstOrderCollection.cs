using System;
using ClassLibrary;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            //test to see if it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property in this case data needs to be a List of objects
            List<clsOrder> TestList = new List<clsOrder>();

            //Add the item to the list -> create the item of test data
            clsOrder TestItem = new clsOrder();

            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 99.99m;
            TestItem.Status = "Pending";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DiscountApplied = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllOrders.OrderList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();

            //set the properties of the test object
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.TotalAmount = 99.99m;
            TestOrder.Status = "Pending";
            TestOrder.PaymentMethod = "Credit Card";
            TestOrder.DiscountApplied = true;

            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;

            //test to see that two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();

            //create some test data to assign to the property in this case data needs to be a List of objects
            List<clsOrder> TestList = new List<clsOrder>();

            //Add the item to the list -> create the item of test data
            clsOrder TestItem = new clsOrder();

            //set its properties
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 99.99m;
            TestItem.Status = "Pending";
            TestItem.PaymentMethod = "Credit Card";
            TestItem.DiscountApplied = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllOrders.OrderList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Variable to store the primary key (OrderId)
            Int32 PrimaryKey = 0;

            // Set the properties of the test data
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 100.00m;
            TestItem.Status = "Pending";
            TestItem.DiscountApplied = true;
            TestItem.PaymentMethod = "Credit Card";

            // Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record
            PrimaryKey = AllOrders.Add(); 

            // Set the primary key of the test data
            TestItem.OrderId = PrimaryKey;

            // Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see that the two values are equal
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Variable to store the primary key (OrderId)
            Int32 PrimaryKey = 0;

            // Set its properties (initial test data)
            TestItem.CustomerId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 150.50m;
            TestItem.Status = "Processing";
            TestItem.DiscountApplied = false;
            TestItem.PaymentMethod = "Credit Card";

            // Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record
            PrimaryKey = AllOrders.Add();

            // Set the primary key of the test data (OrderId)
            TestItem.OrderId = PrimaryKey;

            // Modify the test record (update the data)
            TestItem.CustomerId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.TotalAmount = 250.75m;
            TestItem.Status = "Shipped";
            TestItem.DiscountApplied = true;
            TestItem.PaymentMethod = "PayPal";

            // Set the record based on the new test data
            AllOrders.ThisOrder = TestItem;

            // Update the record
            AllOrders.Update();

            // Find the record using the primary key (OrderId)
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
