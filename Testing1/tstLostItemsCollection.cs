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
        public void AddMethodOK()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            clsLostItems TestItem = new clsLostItems();
            Int32 PrimaryKey = 0;

            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Description = "Test Description";
            TestItem.Location = "Test Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";

            AllLostItems.ThisLostItems = TestItem;
            PrimaryKey = AllLostItems.Add();
            TestItem.Id = PrimaryKey;
            AllLostItems.LostItemsList.Add(TestItem);
            Assert.AreEqual(AllLostItems.ThisLostItems, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();

            // Create a new lost item for test
            clsLostItems TestItem = new clsLostItems();
            Int32 PrimaryKey = 0;

            // Set initial properties
            TestItem.Title = "Original Title";
            TestItem.Description = "Original Description";
            TestItem.Location = "Original Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";

            // Assign and add the record
            AllLostItems.ThisLostItems = TestItem;
            PrimaryKey = AllLostItems.Add();
            TestItem.Id = PrimaryKey;

            // Modify the test item
            TestItem.Title = "Updated Title";
            TestItem.Description = "Updated Description";
            TestItem.Location = "Updated Location";
            TestItem.DateLost = DateTime.Now.Date; // optional to update
            TestItem.IsClaimed = "Yes";

            // Update the record
            AllLostItems.ThisLostItems = TestItem;
            AllLostItems.Update();

            // Find the updated record
            AllLostItems.ThisLostItems.Find(PrimaryKey);

            // Assert that the record was updated successfully
            Assert.AreEqual(AllLostItems.ThisLostItems, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            clsLostItems TestItem = new clsLostItems();
            Int32 PrimaryKey = 0;
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Description = "Test Description";
            TestItem.Location = "Test Location";
            TestItem.DateLost = DateTime.Now.Date;
            TestItem.IsClaimed = "No";
            AllLostItems.ThisLostItems = TestItem;
            PrimaryKey = AllLostItems.Add();
            TestItem.Id = PrimaryKey;
            AllLostItems.LostItemsList.Add(TestItem);
            AllLostItems.ThisLostItems.Find(PrimaryKey);
            AllLostItems.Delete();
            Boolean Found = AllLostItems.ThisLostItems.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsLostItemsCollection AllLostItems = new clsLostItemsCollection();
            clsLostItemsCollection FilteredList = new clsLostItemsCollection();
            FilteredList.ReportByTitle("");
            Assert.AreEqual(AllLostItems.Count, FilteredList.Count);
        }




    }
}
