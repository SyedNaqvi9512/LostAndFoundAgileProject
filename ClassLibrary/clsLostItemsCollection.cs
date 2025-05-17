using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsLostItemsCollection
    {
        public clsLostItemsCollection() {
            // constructor for the class
            // create an instance of the lost items class
            clsLostItems TestItems = new clsLostItems();
            TestItems.Title = "Test Title";
            TestItems.Description = "Test Description";
            TestItems.Location = "Test Location";
            TestItems.DateLost = DateTime.Now;
            TestItems.IsClaimed = "No";
            // add the test item to the list
            mLostItemsList.Add(TestItems);

            TestItems = new clsLostItems();
            TestItems.Title = "Test Title 2";
            TestItems.Description = "Test Description 2";
            TestItems.Location = "Test Location 2";
            TestItems.DateLost = DateTime.Now.Date;
            TestItems.IsClaimed = "Yes";
            // add the test item to the list
            mLostItemsList.Add(TestItems);




        }
        List<clsLostItems> mLostItemsList = new List<clsLostItems>();
        public List<clsLostItems> LostItemsList { get { 
                return mLostItemsList;
            } 
            set { 
                mLostItemsList = value;
            } 
        }
        public int Count { get
            {
                return mLostItemsList.Count;
            }
            set 
            {
                // do nothing
            }
        }
        public clsLostItems ThisLostItems { get; set; }
    }
}