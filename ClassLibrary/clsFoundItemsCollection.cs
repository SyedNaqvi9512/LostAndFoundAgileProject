using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsFoundItemsCollection
    {
        public clsFoundItemsCollection() {
            // constructor for the class
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("FoundItems_SelectAll");
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsFoundItems foundItem = new clsFoundItems();
                foundItem.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                foundItem.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                foundItem.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                foundItem.DateFound = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateFound"]);
                foundItem.IsReturned = Convert.ToString(DB.DataTable.Rows[Index]["IsReturned"]);
                mFoundItemsList.Add(foundItem);
                Index++;
            }
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