using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    class AddressBookRepo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog =AddressBook; Integrated Security = True;";
        SqlConnection connection = new SqlConnection(connectionString);
        public void checkConnection()
        {
            try
            {
                this.connection.Open();
                Console.WriteLine("connection established");
                this.connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public List<AddressBookModel> GetAllEmployees()
        {
            List<AddressBookModel> employees = new List<AddressBookModel>();
            SqlCommand command = new SqlCommand("Sp_RetrieveData", connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            SqlDataReader row = command.ExecuteReader();


            AddressBookModel model = new AddressBookModel();
            if (row.HasRows)
            {
                while (row.Read())
                {
                    model.ID = row.GetInt32(0);
                    model.FirstName = row.GetString(1);
                    model.LastName = row.GetString(2);
                    model.PhoneNumber = row.GetInt32(3);
                    model.Address = row.GetString(4);
                    model.City = row.GetString(5);
                    model.Zip = row.GetInt32(6);
                    model.Email = row.GetString(7);
                    model.State = row.GetString(8);
                    model.NAME= row.GetString(9);
                    model.TYPE = row.GetString(10);
                    

                    employees.Add(model);
                    Console.WriteLine(model.FirstName + " " + model.LastName+ " " + model.PhoneNumber + " " + model.Address + " " + model.City + " " + model.Zip + " " + model.Email + " " + model.State + " " + model.NAME + " " + model.TYPE);

                }
            }
            connection.Close();
            return employees;
        }

    }
}