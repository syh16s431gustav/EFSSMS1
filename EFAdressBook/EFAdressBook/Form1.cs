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
        Contact contact = new Contact();
        List<Contact> ContactsList = new List<Contact>();
        List<object> ContactsProperties = new List<object>();
        bool startCheckingChangedItemValue;
        bool hasSelectedItem;
        bool calledOnce;
        bool ClearedSearchbarText;
        int selectedContactId;

        public Form1()
        {
            InitializeComponent();
            NotSearchingShowContacts();
        }
        void NotSearchingShowContacts()
        {
            using (var context = new ContactContext())
            {
                ContactsList = context.Contacts.ToList();
                lstBoxContacts.DataSource = ContactsList;
                lstBoxContacts.ValueMember = "ContactId";
                lstBoxContacts.DisplayMember = "Name";
            }
            if (!calledOnce)
            {
                lstBoxContacts.ClearSelected();
                calledOnce = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ContactContext())
            {
                Contact newContact = new Contact { Name = txtBoxName.Text, StreetAddress = txtBoxStreetAddress.Text, PostCode = txtBoxPostCode.Text, City = txtBoxCity.Text, Telephone = txtBoxTelephone.Text, Email = txtBoxEmail.Text, BirthDay = dTPickerBirthDay.Value };
                context.Contacts.Add(newContact);
                context.SaveChanges(); 
            }
            NotSearchingShowContacts();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CheckIfSelectedItem();
            if (hasSelectedItem)
            {
                contact.DeleteContact((int)lstBoxContacts.SelectedValue);
                NotSearchingShowContacts();
                txtBoxSearchbar.Text = string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckIfSelectedItem();
            if (hasSelectedItem)
            {
                int selectedItemId = (int)lstBoxContacts.SelectedValue;
                using (var context = new ContactContext())
                {
                    var itemToUpdate = context.Contacts.SingleOrDefault(x => x.ContactId == selectedItemId);
                    itemToUpdate.Name = txtBoxName.Text;
                    itemToUpdate.StreetAddress = txtBoxStreetAddress.Text;
                    itemToUpdate.PostCode = txtBoxPostCode.Text;
                    itemToUpdate.City = txtBoxCity.Text;
                    itemToUpdate.Telephone = txtBoxTelephone.Text;
                    itemToUpdate.Email = txtBoxEmail.Text;
                    itemToUpdate.BirthDay = dTPickerBirthDay.Value;
                    context.SaveChanges();
                }
                NotSearchingShowContacts();
                txtBoxSearchbar.Text = string.Empty;
            }
        }
        void CheckIfSelectedItem()
        {
            if (lstBoxContacts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first");
                hasSelectedItem = false;
            }
            else
                hasSelectedItem = true;
        }
        private void lstBoxContacts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (startCheckingChangedItemValue)
                FillTextBoxes();
        }
        private void lstBoxContacts_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstBoxContacts.SelectedIndex != -1)
            {
                FillTextBoxes();
                startCheckingChangedItemValue = true;
            }
        }
        void FillTextBoxes()
        {
                selectedContactId = (int)lstBoxContacts.SelectedValue;

            using (var context = new ContactContext())
            {
                var itemToWriteProp = context.Contacts.SingleOrDefault(x => x.ContactId == selectedContactId);
                txtBoxName.Text = itemToWriteProp.Name;
                txtBoxStreetAddress.Text = itemToWriteProp.StreetAddress;
                txtBoxPostCode.Text = itemToWriteProp.PostCode;
                txtBoxCity.Text = itemToWriteProp.City;
                txtBoxTelephone.Text = itemToWriteProp.Telephone;
                txtBoxEmail.Text = itemToWriteProp.Email;
                dTPickerBirthDay.Value = itemToWriteProp.BirthDay.Date;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        void ClearTextBoxes()
        {
            txtBoxName.Text = string.Empty;
            txtBoxStreetAddress.Text = string.Empty;
            txtBoxPostCode.Text = string.Empty;
            txtBoxCity.Text = string.Empty;
            txtBoxTelephone.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;
            dTPickerBirthDay.Value = DateTime.Now;
        }
        private void txtBoxSearchbar_TextChanged(object sender, EventArgs e)
        {
            if ((ClearedSearchbarText))
            {
                var results = ContactsList.Where(c => c.Name.ToLower().Contains(txtBoxSearchbar.Text.ToLower()));
                lstBoxContacts.DataSource = results.ToList();
            }
        }
        private void txtBoxSearchbar_Enter(object sender, EventArgs e)
        { 
            if (!ClearedSearchbarText)
            {
                txtBoxSearchbar.Text = string.Empty;
                ClearedSearchbarText = true;
            }
        }
    }
}
