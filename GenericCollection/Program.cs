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
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Contact contact = GetContactDetails();
                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact added successfully!");
                        Console.WriteLine();
                        break;
                    case "2":
                        DisplayContacts(addressBook);
                        break;
                    case "3":
                        if (EditContact(addressBook))
                        {
                            Console.WriteLine("Contact edited successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Contact not found. Please try again.");
                        }
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

        private static bool EditContact(AddressBook addressBook)
        {
            throw new NotImplementedException();
        }

        static Contact GetContactDetails()
        {
            Console.WriteLine("Enter Contact Details:");

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

            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            return contact;
        }

        static void DisplayContacts(AddressBook addressBook)
        {
            Console.WriteLine("Contacts:");

            foreach (Contact contact in addressBook.GetContacts())
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine();
            }
        }
    } 
}
