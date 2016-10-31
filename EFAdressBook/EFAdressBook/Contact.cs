using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;

namespace EFAdressBook
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public void DeleteContact(int selectedItemId)
        {
            using (var context = new ContactContext())
            {
                var itemToRemove = context.Contacts.SingleOrDefault(x => x.ContactId == selectedItemId);
                context.Contacts.Remove(itemToRemove);
                context.SaveChanges();
            }
        }
    }
}
