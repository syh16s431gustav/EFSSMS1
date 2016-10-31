namespace EFAdressBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtBoxPostCode = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtBoxTelephone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.dTPickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.lstBoxContacts = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBoxSearchbar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(156, 44);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(49, 85);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(101, 17);
            this.lblStreetAddress.TabIndex = 4;
            this.lblStreetAddress.Text = "Streetaddress:";
            // 
            // txtBoxStreetAddress
            // 
            this.txtBoxStreetAddress.Location = new System.Drawing.Point(156, 85);
            this.txtBoxStreetAddress.Name = "txtBoxStreetAddress";
            this.txtBoxStreetAddress.Size = new System.Drawing.Size(100, 22);
            this.txtBoxStreetAddress.TabIndex = 3;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(49, 129);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(71, 17);
            this.lblPostCode.TabIndex = 6;
            this.lblPostCode.Text = "Postcode:";
            // 
            // txtBoxPostCode
            // 
            this.txtBoxPostCode.Location = new System.Drawing.Point(156, 129);
            this.txtBoxPostCode.Name = "txtBoxPostCode";
            this.txtBoxPostCode.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPostCode.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(49, 176);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(156, 173);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCity.TabIndex = 7;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(49, 215);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(80, 17);
            this.lblTelephone.TabIndex = 10;
            this.lblTelephone.Text = "Telephone:";
            // 
            // txtBoxTelephone
            // 
            this.txtBoxTelephone.Location = new System.Drawing.Point(156, 215);
            this.txtBoxTelephone.Name = "txtBoxTelephone";
            this.txtBoxTelephone.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTelephone.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(49, 259);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(156, 256);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(49, 298);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(64, 17);
            this.lblBirthDay.TabIndex = 14;
            this.lblBirthDay.Text = "Birthday:";
            // 
            // dTPickerBirthDay
            // 
            this.dTPickerBirthDay.Location = new System.Drawing.Point(156, 298);
            this.dTPickerBirthDay.Name = "dTPickerBirthDay";
            this.dTPickerBirthDay.Size = new System.Drawing.Size(200, 22);
            this.dTPickerBirthDay.TabIndex = 15;
            // 
            // lstBoxContacts
            // 
            this.lstBoxContacts.FormattingEnabled = true;
            this.lstBoxContacts.ItemHeight = 16;
            this.lstBoxContacts.Location = new System.Drawing.Point(387, 60);
            this.lstBoxContacts.Name = "lstBoxContacts";
            this.lstBoxContacts.Size = new System.Drawing.Size(287, 260);
            this.lstBoxContacts.TabIndex = 16;
            this.lstBoxContacts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxContacts_MouseClick);
            this.lstBoxContacts.SelectedValueChanged += new System.EventHandler(this.lstBoxContacts_SelectedValueChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(480, 340);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 44);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove contact";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(194, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 31);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBoxSearchbar
            // 
            this.txtBoxSearchbar.Location = new System.Drawing.Point(387, 32);
            this.txtBoxSearchbar.Name = "txtBoxSearchbar";
            this.txtBoxSearchbar.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSearchbar.TabIndex = 21;
            this.txtBoxSearchbar.Text = "Searchbar";
            this.txtBoxSearchbar.TextChanged += new System.EventHandler(this.txtBoxSearchbar_TextChanged);
            this.txtBoxSearchbar.Enter += new System.EventHandler(this.txtBoxSearchbar_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 440);
            this.Controls.Add(this.txtBoxSearchbar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstBoxContacts);
            this.Controls.Add(this.dTPickerBirthDay);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtBoxTelephone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.txtBoxPostCode);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.txtBoxStreetAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtBoxStreetAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtBoxPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtBoxTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.DateTimePicker dTPickerBirthDay;
        private System.Windows.Forms.ListBox lstBoxContacts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtBoxSearchbar;
    }
}

