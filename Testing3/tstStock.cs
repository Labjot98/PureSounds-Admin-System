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
            clsStock aStock = new clsStock();

            //test to see if it exists
            Assert.IsNotNull(aStock);
        }
    }
}
