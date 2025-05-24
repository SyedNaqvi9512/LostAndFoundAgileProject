using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsLostItemsCollection
    {
        //[rivate data member for the ThisLostItems property
        //private clsLostItems mThisLostItems;
        public clsLostItemsCollection()
        {
            {
                // constructor for the class
                clsDataConnection DB = new clsDataConnection();
                DB.Execute("lostItems_SelectAll");

                Int32 Index = 0;
                Int32 RecordCount =0;
                RecordCount = DB.Count;

                while (Index < RecordCount)
                {
                    clsLostItems lostItem = new clsLostItems();
                    lostItem.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                    lostItem.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                    lostItem.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                    lostItem.Location = Convert.ToString(DB.DataTable.Rows[Index]["Location"]);
                    lostItem.DateLost = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateLost"]);
                    lostItem.IsClaimed = Convert.ToString(DB.DataTable.Rows[Index]["IsClaimed"]);

                    mLostItemsList.Add(lostItem);
                    Index++;

                }
            }
            }
        List<clsLostItems> mLostItemsList = new List<clsLostItems>();
        //private data member for the ThisLostItems property
        private clsLostItems mThisLostItems = new clsLostItems();
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
        public clsLostItems ThisLostItems { 
            get {
                // return the current item
                return mThisLostItems;
            }
            set {
                // set the current item
                mThisLostItems = value;
            }
        }

        public int Add()
        {
            // add a new record to the database based on the values of ThisLostItems
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Title", mThisLostItems.Title);
            DB.AddParameter("@Description", mThisLostItems.Description);
            DB.AddParameter("@Location", mThisLostItems.Location);
            DB.AddParameter("@DateLost", mThisLostItems.DateLost);
            DB.AddParameter("@IsClaimed", mThisLostItems.IsClaimed);
            return DB.Execute("sproc_lostItems_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisLostItems.Id);
            DB.AddParameter("@Title", mThisLostItems.Title);
            DB.AddParameter("@Description", mThisLostItems.Description);
            DB.AddParameter("@Location", mThisLostItems.Location);
            DB.AddParameter("@DateLost", mThisLostItems.DateLost);
            DB.AddParameter("@IsClaimed", mThisLostItems.IsClaimed);
            DB.Execute("sproc_lostItems_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisLostItems.Id);
            DB.Execute("sproc_lostItems_Delete");

        }
    }
}