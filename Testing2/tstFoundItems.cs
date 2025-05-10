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

        [TestMethod]
        public void IdPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Int32 testData = 1;
            AnFoundItems.Id = testData;
            Assert.AreEqual(AnFoundItems.Id, testData);

        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "Keys Lost";
            AnFoundItems.Title = TestData;
            Assert.AreEqual(AnFoundItems.Title, TestData);
        }



        [TestMethod]
        public void LocationPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "LAB 102";
            AnFoundItems.Location = TestData;
            Assert.AreEqual(AnFoundItems.Location, TestData);
        }

        [TestMethod]
        public void DateFoundPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            DateTime TestData = DateTime.Now.Date;
            AnFoundItems.DateFound = TestData;
            Assert.AreEqual(AnFoundItems.DateFound, TestData);
        }

        [TestMethod]
        public void IsReturnedOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "yes";
            AnFoundItems.IsReturned = TestData;
            Assert.AreEqual(AnFoundItems.IsReturned, TestData);
        }
    }
}
