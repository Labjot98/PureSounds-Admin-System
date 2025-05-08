using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrderLine.OrderLineId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrderLine.OrderId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }

        [TestMethod]
        public void ItemIdPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnOrderLine.ItemId = TestData;
            // test to see whether the two values are the same
            Assert.AreEqual(AnOrderLine.ItemId, TestData);
        }
    }
}
