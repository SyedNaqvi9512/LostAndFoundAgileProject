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

            Int32 Id = 21;

            Found = AnFoundItems.Find(Id);

            if (AnFoundItems.Id != 21)
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
            Int32 Title = 21;
            Found = AnFoundItems.Find(Title);
            if (AnFoundItems.Title != "Test Title")
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
            Int32 Location = 21;
            Found = AnFoundItems.Find(Location);
            if (AnFoundItems.Location != "Test Location")
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
            Int32 DateTime = 21;
            Found = AnFoundItems.Find(DateTime);
            if (AnFoundItems.DateFound != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
