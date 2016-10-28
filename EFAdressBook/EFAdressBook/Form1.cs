using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFAdressBook
{
    public partial class Form1 : Form
    {
        List<Contact> ContactsList = new List<Contact>();
        public Form1()
        {
            InitializeComponent();
            UpdateListBox();
        }
        void UpdateListBox()
        {
            //lstBoxContacts.DataSource = ;
            //lstBoxContacts.ValueMember = "CategoryID";
            //lstBoxContacts.DisplayMember = "CategoryName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ContactContext())
            {
                Contact newContact = new Contact { Name = txtBoxName.Text, StreetAddress = txtBoxStreetAddress.Text, PostCode = txtBoxPostCode.Text, City = txtBoxCity.Text, Telephone = txtBoxTelephone.Text, Email = txtBoxEmail.Text, BirthDay = dTPickerBirthDay.Value };
                context.Contacts.Add(newContact);
                context.SaveChanges();
                ContactsList = context.Contacts.ToList();
            }
        }
    }
}
