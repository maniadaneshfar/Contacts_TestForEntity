
namespace Contact.Form1.Forms
{
    partial class frmMyContacts
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
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.Location = new System.Drawing.Point(669, 12);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.Size = new System.Drawing.Size(119, 30);
            this.btnAddNewContact.TabIndex = 0;
            this.btnAddNewContact.Text = "افزودن شخص جدید";
            this.btnAddNewContact.UseVisualStyleBackColor = true;
            this.btnAddNewContact.Click += new System.EventHandler(this.btnAddNewContact_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(521, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblIdentity);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جست و جو";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(239, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(667, 36);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(103, 14);
            this.lblIdentity.TabIndex = 0;
            this.lblIdentity.Text = "نام و نام خانوادگی:";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvContacts.Location = new System.Drawing.Point(12, 130);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowTemplate.Height = 25;
            this.dgvContacts.Size = new System.Drawing.Size(776, 211);
            this.dgvContacts.TabIndex = 3;
            this.dgvContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(713, 361);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ContactID";
            this.Column1.HeaderText = "ContactID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Family";
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mobile";
            this.Column4.HeaderText = "تلفن همراه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "ایمیل";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Address";
            this.Column6.HeaderText = "آدرس";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmMyContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddNewContact);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMyContacts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دفترچه تلفن من";
            this.Load += new System.EventHandler(this.frmMyContact_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}