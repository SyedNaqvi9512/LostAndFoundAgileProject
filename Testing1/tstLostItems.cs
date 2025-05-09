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

        [TestMethod]
        public void IdPropertyOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Int32 testData = 1;
            AnLostItems.Id = testData;
            Assert.AreEqual(AnLostItems.Id, testData);

        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "Keys Lost";
            AnLostItems.Title = TestData;
            Assert.AreEqual(AnLostItems.Title, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "Keys Lost of my car";
            AnLostItems.Description = TestData;
            Assert.AreEqual(AnLostItems.Description, TestData);
        }

        [TestMethod]
        public void LocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "LAB 102";
            AnLostItems.Location = TestData;
            Assert.AreEqual(AnLostItems.Location, TestData);
        }

        [TestMethod]
        public void DateLostPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            DateTime TestData = DateTime.Now.Date;
            AnLostItems.DateLost = TestData;
            Assert.AreEqual(AnLostItems.DateLost, TestData);

        }

        [TestMethod]
        public void IsClaimedPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            Boolean TestData = true;
            AnLostItems.IsClaimed = TestData;
            Assert.AreEqual(AnLostItems.IsClaimed, TestData);
        }


    }
}
