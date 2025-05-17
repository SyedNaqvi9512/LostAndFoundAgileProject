using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstFoundItems

    {
        string ItemName = "Keys";
        string LocationFound = "Lobby";
        string DateFound = DateTime.Now.ToShortDateString();
        string IsReturned = "Yes";

        [TestMethod]
        public void InstanceOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Assert.IsNotNull(AnFoundItems);
        }

        [TestMethod]
        public void IdPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Int32 testData = 1;
            AnFoundItems.Id = testData;
            Assert.AreEqual(AnFoundItems.Id, testData);

        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "Keys Lost";
            AnFoundItems.Title = TestData;
            Assert.AreEqual(AnFoundItems.Title, TestData);
        }



        [TestMethod]
        public void LocationPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "LAB 102";
            AnFoundItems.Location = TestData;
            Assert.AreEqual(AnFoundItems.Location, TestData);
        }

        [TestMethod]
        public void DateFoundPropertyOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            DateTime TestData = DateTime.Now.Date;
            AnFoundItems.DateFound = TestData;
            Assert.AreEqual(AnFoundItems.DateFound, TestData);
        }

        [TestMethod]
        public void IsReturnedOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            string TestData = "yes";
            AnFoundItems.IsReturned = TestData;
            Assert.AreEqual(AnFoundItems.IsReturned, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Int32 TestData = 21;
            Found = AnFoundItems.Find(TestData);
        }

        [TestMethod]
        public void TestIdFound()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Boolean OK = true;

            Int32 Id = 4;

            Found = AnFoundItems.Find(Id);

            if (AnFoundItems.Id != 4)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Title = 4;
            Found = AnFoundItems.Find(Title);
            if (AnFoundItems.Title != "Keys")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestLocationFound()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Location = 4;
            Found = AnFoundItems.Find(Location);
            if (AnFoundItems.Location != "Lobby")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 DateTime = 4;
            Found = AnFoundItems.Find(DateTime);
            if (AnFoundItems.DateFound != Convert.ToDateTime("08/09/2024 00:00:00"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsReturnedFound()
        {
            // Create an instance of the class
            clsFoundItems AnFoundItems = new clsFoundItems();
            Boolean Found = false;
            Boolean OK = true;

            // Define the primary key to search for
            Int32 Id = 4;

            // Call the Find method
            Found = AnFoundItems.Find(Id);

            // Check if the IsReturned property matches the expected value
            if (AnFoundItems.IsReturned != "Yes")
            {
                OK = false;
            }

            // Assert that the test passed
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void validMethodOK()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMin()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "a";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ItemNameMax()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(50, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(49, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMinPLusOne()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "aa";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPLusOne() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(51, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(500, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMin() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "a";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMax() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "";
            LocationFound = LocationFound.PadRight(50, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMaxLessOne() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "";
            LocationFound = LocationFound.PadRight(49, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundExtreme() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "";
            LocationFound = LocationFound.PadRight(500, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMinPlusOne() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "aa";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMid() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "aaa";
            LocationFound = LocationFound.PadRight(25, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationFoundMaxPlusOne() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string LocationFound = "";
            LocationFound = LocationFound.PadRight(51, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMin() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "a";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void IsReturnedMax()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "";
            IsReturned = IsReturned.PadRight(50, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMaxLessOne() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "";
            IsReturned = IsReturned.PadRight(49, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMaxPlusOne()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "";
            IsReturned = IsReturned.PadRight(51, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMinPlusOne() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "aa";
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedExtremeMax() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "";
            IsReturned = IsReturned.PadRight(500, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMid() { 
            clsFoundItems AnFoundItems = new clsFoundItems();
            String Error = "";
            string IsReturned = "aaa";
            IsReturned = IsReturned.PadRight(25, 'a');
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateFoundMin()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok

            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateFoundMax() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok
            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateFoundExtremeMax() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok
            TestDate = TestDate.AddYears(100); //this should be ok
            String DateFound = TestDate.ToString();
            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        

        [TestMethod]
        public void DateFoundMaxPlusOne()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok
            TestDate = TestDate.AddDays(1); //this should be ok
            String DateFound = TestDate.ToString();
            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsReturendMin()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = "a"; //this should be ok
                                    //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturendMax() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsReturned = ""; //this should be ok
            IsReturned = IsReturned.PadRight(50,'a');
            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMinPLusOne()
        {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsReturned = "aa";
                                                       //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedMaxPLusOne() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsReturned = ""; 
            IsReturned = IsReturned.PadRight(51, 'a'); //this should be ok
                                                                            //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsReturnedExtreme() {
            clsFoundItems AnFoundItems = new clsFoundItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsReturned = ""; //this should be ok
            IsReturned = IsReturned.PadRight(500, 'a'); //this should be ok
                                                       //invoke the method
            Error = AnFoundItems.Valid(ItemName, LocationFound, DateFound, IsReturned);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
