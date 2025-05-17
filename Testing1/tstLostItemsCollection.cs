using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstLostItemsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLostItemsCollection AllLostItems= new clsLostItemsCollection();
            Assert.IsNotNull(AllLostItems);
        }

        [TestMethod]
        public void LostItemsListOK()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            List<clsLostItems> TestList = new List<clsLostItems>();
            clsLostItems TestItem = new clsLostItems();
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Description = "Test Description";
            TestItem.Location = "Test Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";
            TestList.Add(TestItem);
            AllLostItems.LostItemsList = TestList;
            Assert.AreEqual(AllLostItems.LostItemsList, TestList);
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            Int32 SomeCount = 2;
            AllLostItems.Count = SomeCount;
            Assert.AreEqual(AllLostItems.Count, 2);
        }
        [TestMethod]
        public void ThisLostItemsPropertyOk()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            clsLostItems TestItem = new clsLostItems();
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Description = "Test Description";
            TestItem.Location = "Test Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";
            AllLostItems.ThisLostItems = TestItem;
            Assert.AreEqual(AllLostItems.ThisLostItems, TestItem);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            List<clsLostItems> TestList = new List<clsLostItems>();
            clsLostItems TestItem = new clsLostItems();
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Description = "Test Description";
            TestItem.Location = "Test Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";
            TestList.Add(TestItem);
            AllLostItems.LostItemsList = TestList;
            Assert.AreEqual(AllLostItems.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            Assert.AreEqual(AllLostItems.Count, 2);

        }
    }
}
