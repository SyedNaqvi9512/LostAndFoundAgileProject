using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsFoundItemsCollection
    {
        public clsFoundItemsCollection() { 
            // constructor for the class
            // create an instance of the found items class
            clsFoundItems TestItems = new clsFoundItems();
            TestItems.Title = "Test Title";
            TestItems.Location = "Test Location";
            TestItems.DateFound = DateTime.Now;
            TestItems.IsReturned = "No";
            // add the test item to the list
            mFoundItemsList.Add(TestItems);
            TestItems = new clsFoundItems();
            TestItems.Title = "Test Title 2";
            TestItems.Location = "Test Location 2";
            TestItems.DateFound = DateTime.Now.Date;
            TestItems.IsReturned = "Yes";
            // add the test item to the list
            mFoundItemsList.Add(TestItems);
        }

        List<clsFoundItems> mFoundItemsList = new List<clsFoundItems>();
        public List<clsFoundItems> FoundItemsList { 
            get {
                return mFoundItemsList;

            } 
            set {
                mFoundItemsList = value;

            }
        }
        public int Count {
            get {
                return mFoundItemsList.Count;

            }
            set { 
                //do nothing

            }
        }
        public clsFoundItems ThisFoundItems { get; set; }
    }
}