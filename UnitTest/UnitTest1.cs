
using AddressBook_ADO.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AddressBookTest
{
    public class Tests
    {
        AddressBookModel address;
        AddressBookDetail addressBookDetail;
        [SetUp]
        public void Setup()
        {
            address = new AddressBookModel();
            addressBookDetail = new AddressBookDetail();
        }
        //<summary>
        //UC2 : Insert Details
        //</summary>
        [Test]
        public void Inserting_AddressBook_Details()
        {
            int expected = 1;
            address.FirstName = "Kiran";
            address.LastName = "kadam";
            address.Address = "street 404";
            address.City = "Mumbai";
            address.State = "Dadar";
            address.Zip = 245673;
            address.PhoneNumber = 9375937394;
            address.Email = "kiran@gmail.com";
            var actual = addressBookDetail.InsertAddressData(address);
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //TC 3 : Retrieve Details
        //</summary>
        [Test]
        public void Retrive_AddressBook_Details()
        {
            int expected = 4;
            var result = addressBookDetail.RetrieveAddressBookDetails();
            Assert.AreEqual(expected, result.Count);
        }
        //<summary>
        //TC 4 : Update Details
        //</summary>
        [Test]
        public void UpdatingEmployeeDetails()
        {
            bool expected = true;
            address.ID = 4;
            address.FirstName = "Kundan";
            address.LastName = "Kamble";
            address.Address = "Mumbai";
            address.City = "Texas";
            address.State = "colaba";
            address.Zip = 400005;
            address.PhoneNumber = 7410741141;
            address.Email = "kundan@gmail.com";
            bool result = addressBookDetail.UpdateDetails(address);
            Assert.AreEqual(expected, result);
        }
        //<summary>
        //TC 5 : Remove Details
        //</summary>
        [Test]
        public void Remove_AddressBook_Details()
        {
            bool expected = true;
            address.ID = 4;
            bool result = addressBookDetail.RemoveContact(address);
            Assert.AreEqual(expected, result);
        }
        //<summary>
        //TC 6 : Retrieve Details by city and state
        //</summary>
        [Test]
        public void Retrive_AddressBook_Details_By_CityState()
        {
            bool expected = true;
            address.City = "Mumbai";
            address.State = "Maharashtra";
            bool actual = addressBookDetail.GetDataFromCityAndState(address);
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //TC 7 : Count Details by city and state
        //</summary>
        [Test]
        public void Count_AddressBook_Details_By_CityState()
        {
            bool expected = true;
            address.City = "Mumbai";
            address.State = "Maharashrta";
            bool actual = addressBookDetail.CountDataFromCityAndState(address);
            Assert.AreEqual(expected, actual);
        }
    }
}
