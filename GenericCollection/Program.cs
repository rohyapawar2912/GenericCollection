using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Address: ");
                        string address = Console.ReadLine();
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        Console.Write("State: ");
                        string state = Console.ReadLine();
                        Console.Write("Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Contact added successfully!");
                        Console.WriteLine();
                        break;
                    case "2":
                        addressBook.DisplayContacts();
                        break;
                    case "3":
                        Console.Write("Enter the First Name of the contact to delete: ");
                        string deleteFirstName = Console.ReadLine();
                        Console.Write("Enter the Last Name of the contact to delete: ");
                        string deleteLastName = Console.ReadLine();
                        addressBook.DeleteContact(deleteFirstName, deleteLastName);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Exiting Address Book. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
     
}
