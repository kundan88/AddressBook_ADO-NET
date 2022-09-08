

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
            address.FirstName = "Satish";
            address.LastName = "Pyage";
            address.Address = "Kamalnagar";
            address.City = "Bidar";
            address.State = "Karnataka";
            address.Zip = 248899;
            address.PhoneNumber = 7875737394;
            address.Email = "pyage@gmail.com";
            var actual = addressBookDetail.InsertAddressData(address);
            Assert.AreEqual(expected, actual);
        }
    }
}
