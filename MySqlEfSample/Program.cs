// See https://aka.ms/new-console-template for more information
using MySqlEfSample.DBModels;
using MySqlEfSample;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        using (var context = new AppDbContext())
        {
            // Add a new customer
            var customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhonePrimary = "123-456-7890",
                PhoneSecondary = "098-765-4321",
                DateOfBirth = new DateTime(1979,3,8),
                DateOfAnniversary = new DateTime(2005,1,27),
                Addresses = new[]
                {
                    new CustomerAddress { AddressType = "Billing", Street = "123 Main St", City = "CityA", State = "StateA", ZipCode = "12345", Country = "USA" },
                    new CustomerAddress { AddressType = "Shipping", Street = "456 Elm St", City = "CityB", State = "StateB", ZipCode = "67890", Country = "USA" }
                },
                PaymentInfos = new[]
                {
                    new CustomerPaymentInfo { PaymentType = "Card", CardNumber = "4111111111111111", IsPrimary = true },
                    new CustomerPaymentInfo { PaymentType = "Bank", BankName = "BankA", AccountNumber = "123456789", IsPrimary = false }
                },
                BusinessInfo = new CustomerBussines
                {
                    Name = "Doe Enterprises",
                    RegistrationNumber = "REG123",
                    TaxId = "TAX456",
                    ContactPerson = "Jane Doe",
                    ContactEmail = "jane.doe@doeenterprises.com",
                    ContactPhone = "321-654-0987"
                }
            };

            context.Customers.Add(customer);
            context.SaveChanges();
            Console.WriteLine("Customer added successfully!");
        }
    }
}