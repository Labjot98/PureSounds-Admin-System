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
    }
}
