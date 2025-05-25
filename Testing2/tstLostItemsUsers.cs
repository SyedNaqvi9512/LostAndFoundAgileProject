using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstLostItemsUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to test
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            // Test that it exists
            Assert.IsNotNull(AUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            // Create an instance of the class we want to test
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            // Create some test data to assign to the property
            Int32 TestData = 1;
            // Assign the data to the property
            AUser.UserID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            // Create an instance of the class we want to test
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            // Create some test data to assign to the property
            string TestData = "John Doe";
            // Assign the data to the property
            AUser.UserName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            // Create an instance of the class we want to test
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            // Create some test data to assign to the property
            string TestData = "password123";
            // Assign the data to the property
            AUser.Password = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // Create an instance of the class we want to test
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            // Create some test data to assign to the property
            string TestData = "Lost and Found";
            // Assign the data to the property
            AUser.Department = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AUser.Department, TestData);

        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsLostItemsUsers AUser = new clsLostItemsUsers();
            Int32 TestData = 1;
            Boolean Found = false;
            string UserName = "AliHusnain";
            string Password = "12345";
            bool found = AUser.FindUser(UserName,Password);
            Assert.IsTrue(found);
        }

    }
}
