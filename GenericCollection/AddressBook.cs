using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    public class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContacts()
        {
            Console.WriteLine("Contacts:");

            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"First Name: {contact.FirstName}");
                Console.WriteLine($"Last Name: {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Zip: {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine();
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contact contactToDelete = null;

            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.Equals(firstName) && contact.LastName.Equals(lastName))
                {
                    contactToDelete = contact;
                    break;
                }
            }

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found. Please try again.");
            }
        }
    }
}

