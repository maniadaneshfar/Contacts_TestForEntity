using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Contacts.Entity.Model;
using Contact.Form1.Forms;
using Contacts.Data.Context;
using System.Windows.Forms;

using System.Linq;

namespace Contact.Form1
{
    public partial class AddNewContact : Form
    {
        public AddNewContact()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Contacts.Data.Context.ApplicationContext ApplicationDbContext = new Contacts.Data.Context.ApplicationContext();
            Contacts.Entity.Model.Contacts contacts = new Contacts.Entity.Model.Contacts();
            
            contacts.Name = txtName.Text;
            contacts.Family = txtFamily.Text;
            contacts.Mobile = txtMobile.Text;
            contacts.Email = txtEmail.Text;
            contacts.Address = txtAddress.Text;

            ApplicationDbContext.MyContact.Add(contacts);
            ApplicationDbContext.SaveChanges();

           

           

                

            }

        }
 }


