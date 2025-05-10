using System;

namespace ClassLibrary
{
    public class clsFoundItems
    {
        Int32 mId;
        public int Id { 
            get {
                return mId;
            } 
            set {
                mId = value;
            } }

        string mTitle;
        public string Title { 
            get {
                return mTitle;
            } 
            set {
                mTitle = value;
            } }

        string mLocation;
        public string Location { 
            get {
                return mLocation;
            } 
            set {
                mLocation = value;
            } }

        DateTime mDateFound;
        public DateTime DateFound { 
            get {
                return mDateFound;
            } 
            set {
                mDateFound = value;
            } }

        public string IsReturned { get; set; }

        public bool Find(int AddressId)
        {
            //set the private data members to the test data value
            mId = 21;
            mTitle = "Test Title";
            mLocation = "Test Location";
            mDateFound = Convert.ToDateTime("23/12/2022");
            return true;
        }
    }
}