
namespace AddressBook_ADO.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Address Book");
            AddressBookModel address = new AddressBookModel();
            AddressBookDetail addressBookDetail = new AddressBookDetail();
            int option = 0;
            do
            {
                Console.WriteLine("1: For Establish Connection");
                Console.WriteLine("2: For Close Connection");
                Console.WriteLine("3: Insert Addressbook Details");
                Console.WriteLine("4: For retrieve AddressBook Details");
                Console.WriteLine("5: For Update AddressBook Details");
                Console.WriteLine("0: For Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        addressBookDetail.EstablishConnection();
                        Console.WriteLine("Connection is Open");
                        break;
                    case 2:
                        addressBookDetail.CloseConnection();
                        Console.WriteLine("Connection is closed");
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name");
                        string firstname = Console.ReadLine();
                        address.FirstName = firstname;
                        Console.WriteLine("Enter Last Name");
                        string lastname = Console.ReadLine();
                        address.LastName = lastname;
                        Console.WriteLine("Enter Address");
                        string address1 = Console.ReadLine();
                        address.Address = address1;
                        Console.WriteLine("Enter City");
                        string city = Console.ReadLine();
                        address.City = city;
                        Console.WriteLine("Enter state");
                        string state = Console.ReadLine();
                        address.State = state;
                        Console.WriteLine("Enter zip");
                        double zip = Convert.ToInt64(Console.ReadLine());
                        address.Zip = zip;
                        Console.WriteLine("Enter phone number");
                        double phone = Convert.ToInt64(Console.ReadLine());
                        address.PhoneNumber = phone;
                        Console.WriteLine("Enter email");
                        string email = Console.ReadLine();
                        address.Email = email;
                        addressBookDetail.InsertAddressData(address);
                        break;
                    case 4:
                        addressBookDetail.RetrieveAddressBookDetails();
                        break;
                    case 5:
                        Console.WriteLine("Enter ID");
                        int iD = Convert.ToInt32(Console.ReadLine());
                        address.ID = iD;
                        Console.WriteLine("Enter First Name");
                        string firstname1 = Console.ReadLine();
                        address.FirstName = firstname1;
                        Console.WriteLine("Enter Last Name");
                        string lastname1 = Console.ReadLine();
                        address.LastName = lastname1;
                        Console.WriteLine("Enter Address");
                        string address2 = Console.ReadLine();
                        address.Address = address2;
                        Console.WriteLine("Enter City");
                        string city1 = Console.ReadLine();
                        address.City = city1;
                        Console.WriteLine("Enter state");
                        string state1 = Console.ReadLine();
                        address.State = state1;
                        Console.WriteLine("Enter zip");
                        double zip1 = Convert.ToInt64(Console.ReadLine());
                        address.Zip = zip1;
                        Console.WriteLine("Enter phone number");
                        double phone1 = Convert.ToInt64(Console.ReadLine());
                        address.PhoneNumber = phone1;
                        Console.WriteLine("Enter email");
                        string email1 = Console.ReadLine();
                        address.Email = email1;
                        addressBookDetail.UpdateDetails(address);
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Input");
                        break;
                }
            }
            while (option != 0);
        }
    }
}

