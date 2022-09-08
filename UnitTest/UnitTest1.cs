using AddressBook_ADO.NET;
using NUnit.Framework;

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
            address.City = "mumbai";
            address.State = "colaba";
            address.Zip = 400005;
            address.PhoneNumber = 7410741141;
            address.Email = "kundan@gmail.com";
            bool result = addressBookDetail.UpdateDetails(address);
            Assert.AreEqual(expected, result);
        }
    }
}
