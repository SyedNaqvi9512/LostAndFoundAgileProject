using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstLostItems
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Assert.IsNotNull(AnLostItems);

        }

        [TestMethod]
        public void IdPropertyOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Int32 testData = 1;
            AnLostItems.Id = testData;
            Assert.AreEqual(AnLostItems.Id, testData);

        }

        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "Keys Lost";
            AnLostItems.Title = TestData;
            Assert.AreEqual(AnLostItems.Title, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "Keys Lost of my car";
            AnLostItems.Description = TestData;
            Assert.AreEqual(AnLostItems.Description, TestData);
        }

        [TestMethod]
        public void LocationPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "LAB 102";
            AnLostItems.Location = TestData;
            Assert.AreEqual(AnLostItems.Location, TestData);
        }

        [TestMethod]
        public void DateLostPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            DateTime TestData = DateTime.Now.Date;
            AnLostItems.DateLost = TestData;
            Assert.AreEqual(AnLostItems.DateLost, TestData);

        }

        [TestMethod]
        public void IsClaimedPropertyOK()
        {
            //create an instance of the class we want to create
            clsLostItems AnLostItems = new clsLostItems();
            string TestData = "yes";
            AnLostItems.IsClaimed = TestData;
            Assert.AreEqual(AnLostItems.IsClaimed, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Int32 TestData = 21;
            Found = AnLostItems.Find(TestData);
        }

        [TestMethod]
        public void TestIdFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;

            Int32 Id = 21;

            Found = AnLostItems.Find(Id);

            if (AnLostItems.Id != 21)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Title = 21;
            Found = AnLostItems.Find(Title);
            if (AnLostItems.Title != "Test Title")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Description = 21;
            Found = AnLostItems.Find(Description);
            if (AnLostItems.Description != "Test Description")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Location = 21;
            Found = AnLostItems.Find(Location);
            if (AnLostItems.Location != "Test Location")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsClaimedFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 IsClaimed = 21;
            Found = AnLostItems.Find(IsClaimed);
            if (AnLostItems.IsClaimed != "Test IsClaimed")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 DateTime = 21;
            Found = AnLostItems.Find(DateTime);
            if (AnLostItems.DateLost != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
