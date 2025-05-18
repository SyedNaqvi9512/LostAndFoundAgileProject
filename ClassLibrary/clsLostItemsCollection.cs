using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsLostItemsCollection
    {
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