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
    }
}
