using System;

namespace ClassLibrary
{
    public class clsLostItems
    {
        public clsLostItems()
        {
        }

        private Int32 mId;
        public int Id {
            get {
                return mId;
            }
            set {
                mId = value;
            } 
        }
        private DateTime mDate;
        public DateTime DateLost {
            get {
                return mDate;   
            }
            set {
                mDate = value;
            }
        }
        private string mTitle;
        public string Title {
            get {
              return mTitle;
            }
            set { 
            mTitle = value;
            }
        }
        private string mDescription;
        public string Description {
            get {
                return mDescription;
            }
            set { 
            mDescription = value;
            }
        }

        private string mLocation;
        public string Location {
            get {
                return mLocation;
            }
            set{
                mLocation = value;
            }
        }
        private string mIsClaimed;
        public string IsClaimed { get {
                return mIsClaimed;
                    } set {
                mIsClaimed = value;
                    } }

    

        public bool Find(int AddressId)
        {
            //set the private data members to the test data value
            mId = 21;
            mTitle = "Test Title";
            mDescription = "Test Description";
            mLocation = "Test Location";
            mDate = Convert.ToDateTime("23/12/2022");
            mIsClaimed = "Test IsClaimed";
            return true;
        }
    }
}