using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
