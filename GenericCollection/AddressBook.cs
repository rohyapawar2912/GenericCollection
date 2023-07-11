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

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public Contact GetContactByName(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName.Equals(firstName) && contact.LastName.Equals(lastName))
                {
                    return contact;
                }
            }
            return null;
        }

        public bool EditContact(string firstName, string lastName)
        {
            Contact contact = GetContactByName(firstName, lastName);
            if (contact == null)
            {
                return false;
            }

            Console.WriteLine("Enter new contact details:");

            Console.Write("First Name: ");
            string newFirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string newLastName = Console.ReadLine();

            Console.Write("Address: ");
            string newAddress = Console.ReadLine();

            Console.Write("City: ");
            string newCity = Console.ReadLine();

            Console.Write("State: ");
            string newState = Console.ReadLine();

            Console.Write("Zip: ");
            string newZip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string newPhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string newEmail = Console.ReadLine();

            contact.FirstName = newFirstName;
            contact.LastName = newLastName;
            contact.Address = newAddress;
            contact.City = newCity;
            contact.State = newState;
            contact.Zip = newZip;
            contact.PhoneNumber = newPhoneNumber;
            contact.Email = newEmail;

            return true;
        }
    }
}
