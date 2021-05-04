﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contact.Form1.Forms
{
    public partial class frmMyContacts : Form
    {
        public frmMyContacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void frmMyContact_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            AddNewContact AddNewContact = new AddNewContact();
            AddNewContact.ShowDialog();
            if (AddNewContact.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGrid();
        }


        private void BindGrid()
        {
            using (Contacts.Data.Context.ApplicationContext ApplicationDbContext = new Contacts.Data.Context.ApplicationContext())
            {
                dgvContacts.AutoGenerateColumns = false;
                dgvContacts.Columns[0].Visible = false;
                dgvContacts.DataSource = ApplicationDbContext.MyContact.ToList();

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (Contacts.Data.Context.ApplicationContext ApplicationDbContext = new Contacts.Data.Context.ApplicationContext())
            {
                dgvContacts.DataSource = ApplicationDbContext.MyContact.Where(c => c.Name.Contains(txtSearch.Text) || c.Family.Contains(txtSearch.Text)).ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                string name = dgvContacts.CurrentRow.Cells[1].Value.ToString();
                string family = dgvContacts.CurrentRow.Cells[2].Value.ToString();
                string fullname = name + "" + family;
                if (MessageBox.Show($"آیا از حذف {fullname} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int contactId = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                    using (Contacts.Data.Context.ApplicationContext ApplicationDbContext = new Contacts.Data.Context.ApplicationContext())
                    {
                        Contacts.Entity.Model.Contacts contact = ApplicationDbContext.MyContact.Single(c => c.ContacID == contactId);
                    }
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید");
            }
        }
    }
}




