
namespace Contact.Form1
{
    partial class AddNewContact
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(326, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام:";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(23, 21);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(205, 22);
            this.txtFamily.TabIndex = 5;
            this.txtFamily.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(245, 24);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(76, 14);
            this.lblFamily.TabIndex = 4;
            this.lblFamily.Text = "نام خانوادگی:";
            this.lblFamily.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(326, 72);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(205, 22);
            this.txtMobile.TabIndex = 7;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(537, 80);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(66, 14);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "تلفن همراه:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(245, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 14);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "ایمیل:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(23, 128);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(508, 134);
            this.txtAddress.TabIndex = 11;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(555, 131);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 14);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "آدرس:";
            this.lblAddress.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(519, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 322);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افزودن شخص جدید";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSubmit;
    }
}