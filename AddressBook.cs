using System;
using System.Collections.Generic;

namespace address_book
{
    class AddressBook
    {
        public List<Contact> Contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public Contact GetByEmail(string email)
        {
            Contact matchingContact = Contacts.Find(contact => contact.Email == email);

            return matchingContact;
        }
    }
}