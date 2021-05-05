using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Contacts.Data.Context;
using Contact.Forms;
using System.Windows.Forms;
using System.Linq;

namespace Contact.Forms
{
    public partial class frmAddNewContact : Form
    {
        public frmAddNewContact()
        {
            InitializeComponent();
        }

        bool ValidateInputs()
        {


            if (txtName.Text == "")
            {

                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtMobile.Text == "")
            {
                MessageBox.Show("لطفا موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("لطفا آدرس را وارد کنید","هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
  
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Contacts.Data.Context.ApplicationContext ApplicationDbContext = new Contacts.Data.Context.ApplicationContext();
            Contacts.Entity.Model.Contacts ContacsOfModel = new Contacts.Entity.Model.Contacts();



            ContacsOfModel.Name = txtName.Text;
            ContacsOfModel.Family = txtFamily.Text;
            ContacsOfModel.Mobile = txtMobile.Text;
            ContacsOfModel.Email = txtEmail.Text;
            ContacsOfModel.Address = txtAddress.Text;

            ApplicationDbContext.MyContact.Add(ContacsOfModel);
            ApplicationDbContext.SaveChanges();

            if (ValidateInputs())
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
    }
}
