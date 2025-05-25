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
                foundItem.Title = Convert.ToString(DB.DataTable.Rows[Index]["itemName"]);
                foundItem.Location = Convert.ToString(DB.DataTable.Rows[Index]["LocationFound"]);
                foundItem.DateFound = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateFound"]);
                foundItem.IsReturned = Convert.ToString(DB.DataTable.Rows[Index]["IsReturned"]);
                mFoundItemsList.Add(foundItem);
                Index++;
            }
        }

        List<clsFoundItems> mFoundItemsList = new List<clsFoundItems>();
        //private data member for the ThisFoundItems property
        private clsFoundItems mThisFoundItems = new clsFoundItems();
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
        public clsFoundItems ThisFoundItems { get {
                return mThisFoundItems;
            } set {
                mThisFoundItems = value;
            } }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@itemName", mThisFoundItems.Title);
            DB.AddParameter("@LocationFound", mThisFoundItems.Location);
            DB.AddParameter("@DateFound", mThisFoundItems.DateFound);
            DB.AddParameter("@IsReturned", mThisFoundItems.IsReturned);
            //execute the stored procedure
            return DB.Execute("sproc_FoundItems_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Id", mThisFoundItems.Id);
            DB.AddParameter("@itemName", mThisFoundItems.Title);
            DB.AddParameter("@LocationFound", mThisFoundItems.Location);
            DB.AddParameter("@DateFound", mThisFoundItems.DateFound);
            DB.AddParameter("@IsReturned", mThisFoundItems.IsReturned);
            //execute the stored procedure
            DB.Execute("sproc_FoundItems_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Id", mThisFoundItems.Id);
            //execute the stored procedure
            DB.Execute("sproc_FoundItems_Delete");
        }
    }
}