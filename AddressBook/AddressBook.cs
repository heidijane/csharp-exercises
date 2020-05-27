using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        private Dictionary<string, Contact> _contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return _contacts[email];
        }

    }
}