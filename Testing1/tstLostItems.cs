using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstLostItems
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Assert.IsNotNull(AnLostItems);

        }
    }
}
