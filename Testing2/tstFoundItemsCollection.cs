using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstFoundItemsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Test that it exists
            Assert.IsNotNull(AllFoundItems);
        }

        [TestMethod]
        public void FoundItemsListOK()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            List<clsFoundItems> TestList = new List<clsFoundItems>();
            // Add an item to the test list
            clsFoundItems TestItem = new clsFoundItems();
            // Set its properties
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Location = "Test Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllFoundItems.FoundItemsList = TestList;
            // Test that the two values are the same
            Assert.AreEqual(AllFoundItems.FoundItemsList, TestList);
        }



        [TestMethod]
        public void ThisFoundItemsPropertyOk()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            clsFoundItems TestItem = new clsFoundItems();
            // Set its properties
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Location = "Test Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Assign the data to the property
            AllFoundItems.ThisFoundItems = TestItem;
            // Test that the two values are the same
            Assert.AreEqual(AllFoundItems.ThisFoundItems, TestItem);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            List<clsFoundItems> TestList = new List<clsFoundItems>();
            // Add an item to the test list
            clsFoundItems TestItem = new clsFoundItems();
            // Set its properties
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Location = "Test Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllFoundItems.FoundItemsList = TestList;
            // Test that the two values are the same
            Assert.AreEqual(AllFoundItems.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            clsFoundItems TestItem = new clsFoundItems();
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Id = 1;
            TestItem.Title = "Test Title";
            TestItem.Location = "Test Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Assign the data to the property
            AllFoundItems.ThisFoundItems = TestItem;
            // Add the item to the collection
            PrimaryKey = AllFoundItems.Add();
            // Set the primary key of the test item
            TestItem.Id = PrimaryKey;
            // Test that the two values are the same
            Assert.AreEqual(AllFoundItems.ThisFoundItems, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            clsFoundItems TestItem = new clsFoundItems();
            Int32 PrimaryKey = 0;
            // Set initial properties
            TestItem.Title = "Original Title";
            TestItem.Location = "Original Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Assign and add the record
            AllFoundItems.ThisFoundItems = TestItem;
            PrimaryKey = AllFoundItems.Add();
            // Set the primary key of the test item
            TestItem.Id = PrimaryKey;
            // Modify the properties
            TestItem.Title = "Updated Title";
            TestItem.Location = "Updated Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "Yes";
            // Assign the modified item back to the collection
            AllFoundItems.ThisFoundItems = TestItem;
            // Update the record in the database
            AllFoundItems.Update();
            // Test that the two values are the same
            Assert.AreEqual(AllFoundItems.ThisFoundItems, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to test
            clsFoundItemsCollection AllFoundItems = new clsFoundItemsCollection();
            // Create some test data to assign to the property
            clsFoundItems TestItem = new clsFoundItems();
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Title = "Test Title";
            TestItem.Location = "Test Location";
            TestItem.DateFound = DateTime.Now.Date;
            TestItem.IsReturned = "No";
            // Assign the data to the property
            AllFoundItems.ThisFoundItems = TestItem;
            // Add the item to the collection
            PrimaryKey = AllFoundItems.Add();
            // Set the primary key of the test item
            TestItem.Id = PrimaryKey;
            // Assign the modified item back to the collection
            AllFoundItems.ThisFoundItems = TestItem;
            // Delete the record from the database
            AllFoundItems.Delete();
            Boolean Found = AllFoundItems.ThisFoundItems.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByTitleMethodOK()
        {
            clsFoundItemsCollection collection = new clsFoundItemsCollection();
            string testTitle = "Test"; // Use a substring that should match at least one item in your DB

            // Act
            collection.ReportByTitle(testTitle);

            // Assert: All returned items should contain the testTitle substring in their Title
            bool allMatch = true;
            foreach (var item in collection.FoundItemsList)
            {
                if (!item.Title.Contains(testTitle))
                {
                    allMatch = false;
                    break;
                }
            }
            Assert.IsTrue(allMatch);
        }
        

    } 
}
