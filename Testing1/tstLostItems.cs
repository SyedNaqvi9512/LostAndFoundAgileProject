using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstLostItems
    {
        string Title = "Keys Lost";
        string Description = "Keys Lost of my car";
        string Location = "LAB 102";
        string IsClaimed = "yes";
        string DateLost = DateTime.Now.Date.ToShortDateString();

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
            Int32 TestData = 4;
            Found = AnLostItems.Find(TestData);
        }

        [TestMethod]
        public void TestIdFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;

            Int32 Id = 4;

            Found = AnLostItems.Find(Id);

            if (AnLostItems.Id != 4)
            {
                OK = false;

            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestTitleFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Title = 4;
            Found = AnLostItems.Find(Title);
            if (AnLostItems.Title != "keys3lost")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Description = 4;
            Found = AnLostItems.Find(Description);
            if (AnLostItems.Description != "lost keys 3")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestLocationFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Location = 4;
            Found = AnLostItems.Find(Location);
            if (AnLostItems.Location != "lobby")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestIsClaimedFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 IsClaimed = 4;
            Found = AnLostItems.Find(IsClaimed);
            if (AnLostItems.IsClaimed != "yes")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsLostItems AnLostItems = new clsLostItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 DateTime = 4;
            Found = AnLostItems.Find(DateTime);
            if (AnLostItems.DateLost != Convert.ToDateTime("08/09/2023 00:00:00"))
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void validMethodOK()
        {
            clsLostItems AnLostItems = new clsLostItems();
            string Error = "";
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TitleMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "a"; //this should be ok
                                //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMinPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aa"; //this should be ok
                                 //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxLessOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = ""; //this should be ok
            Title = Title.PadRight(49, 'a');                        //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMax()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(50, 'a');   //this should be ok
                                               //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMid()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "aaa"; //this should be ok
                                  //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(51, 'a'); //this should be ok
                                             //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TitleMaxExtreme()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Title = "";
            Title = Title.PadRight(500, 'a'); //this should be ok
                                              //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "a"; //this should be ok
                                      //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aa"; //this should be ok
                                       //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = ""; //this should be ok
            Description = Description.PadRight(49, 'a');

            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(50, 'a');   //this should be ok
                                                           //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aaa"; //this should be ok
                                        //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(51, 'a'); //this should be ok
                                                         //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxExtreme()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            Description = Description.PadRight(500, 'a'); //this should be ok
                                                          //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LocationMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "a"; //this should be ok
                                   //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMinPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "aa"; //this should be ok
                                    //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMax()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "";
            Location = Location.PadRight(50, 'a');   //this should be ok
                                                     //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMaxMinusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = ""; Location = Location.PadRight(49, 'a'); //this should be ok
                                                                         //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LocationMaxExtreme()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Location = "";
            Location = Location.PadRight(500, 'a'); //this should be ok
                                                    //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateLostExtremeMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method

            DateTime TestDate = DateTime.Now.Date; //this should be ok
            TestDate = TestDate.AddYears(-100); //this should be ok
            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateLostMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok

            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateLostMinLessOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok
            TestDate = TestDate.AddDays(-1); //this should be ok
            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateLostMaxExtreme()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate = DateTime.Now.Date; //this should be ok
            TestDate = TestDate.AddYears(100); //this should be ok
            String DateLost = TestDate.ToString();
            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateLostInvalidData()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DateLost = "This is not a date"; //this should trigger an error
                                                    //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IsClaimedMin()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = "a"; //this should be ok
                                    //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void IsClaimedMax()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = ""; IsClaimed = IsClaimed.PadRight(50, 'a'); //this should be ok
                                                                            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IsClaimedMaxLessOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = ""; IsClaimed = IsClaimed.PadRight(49, 'a'); //this should be ok
                                                                            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void IsClaimedMaxPlusOne()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = ""; IsClaimed = IsClaimed.PadRight(51, 'a'); //this should be ok
                                                                            //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void IsClaimedMid()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = "aaa"; //this should be ok
                                      //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void IsClaimedMinPlusOne()
        {

            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = "aa"; //this should be ok
                                     //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void IsClaimedMaxExtreme()
        {
            clsLostItems AnLostItems = new clsLostItems();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string IsClaimed = ""; IsClaimed = IsClaimed.PadRight(500, 'a'); //this should be ok
                                                                             //invoke the method
            Error = AnLostItems.Valid(Title, Description, Location, DateLost, IsClaimed);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
