using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstFoundItems
    {
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
    }
}
