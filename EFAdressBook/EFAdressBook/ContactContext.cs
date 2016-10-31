using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdressBook
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

    }
}
