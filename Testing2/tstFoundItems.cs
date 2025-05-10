using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstFoundItems
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Assert.IsNotNull(AnFoundItems);
        }
    }
}
