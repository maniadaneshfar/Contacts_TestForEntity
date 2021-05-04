
namespace Contact.Form1.Forms
{
    partial class EditContact
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditMobile = new System.Windows.Forms.TextBox();
            this.lblEditMobile = new System.Windows.Forms.Label();
            this.txtEditFamily = new System.Windows.Forms.TextBox();
            this.lblEditFamily = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(508, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(12, 133);
            this.txtEditAddress.Multiline = true;
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(508, 134);
            this.txtEditAddress.TabIndex = 22;
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Location = new System.Drawing.Point(544, 136);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(39, 14);
            this.lblEditAddress.TabIndex = 21;
            this.lblEditAddress.Text = "آدرس:";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(12, 77);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEditEmail.TabIndex = 20;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.AutoSize = true;
            this.lblEditEmail.Location = new System.Drawing.Point(234, 80);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(37, 14);
            this.lblEditEmail.TabIndex = 19;
            this.lblEditEmail.Text = "ایمیل:";
            // 
            // txtEditMobile
            // 
            this.txtEditMobile.Location = new System.Drawing.Point(315, 77);
            this.txtEditMobile.Name = "txtEditMobile";
            this.txtEditMobile.Size = new System.Drawing.Size(205, 22);
            this.txtEditMobile.TabIndex = 18;
            // 
            // lblEditMobile
            // 
            this.lblEditMobile.AutoSize = true;
            this.lblEditMobile.Location = new System.Drawing.Point(526, 85);
            this.lblEditMobile.Name = "lblEditMobile";
            this.lblEditMobile.Size = new System.Drawing.Size(66, 14);
            this.lblEditMobile.TabIndex = 17;
            this.lblEditMobile.Text = "تلفن همراه:";
            // 
            // txtEditFamily
            // 
            this.txtEditFamily.Location = new System.Drawing.Point(12, 26);
            this.txtEditFamily.Name = "txtEditFamily";
            this.txtEditFamily.Size = new System.Drawing.Size(205, 22);
            this.txtEditFamily.TabIndex = 16;
            // 
            // lblEditFamily
            // 
            this.lblEditFamily.AutoSize = true;
            this.lblEditFamily.Location = new System.Drawing.Point(234, 29);
            this.lblEditFamily.Name = "lblEditFamily";
            this.lblEditFamily.Size = new System.Drawing.Size(76, 14);
            this.lblEditFamily.TabIndex = 15;
            this.lblEditFamily.Text = "نام خانوادگی:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(315, 26);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(205, 22);
            this.txtEditName.TabIndex = 14;
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(558, 29);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(25, 14);
            this.lblEditName.TabIndex = 13;
            this.lblEditName.Text = "نام:";
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 340);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.lblEditAddress);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.lblEditEmail);
            this.Controls.Add(this.txtEditMobile);
            this.Controls.Add(this.lblEditMobile);
            this.Controls.Add(this.txtEditFamily);
            this.Controls.Add(this.lblEditFamily);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblEditName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش شخص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtEditMobile;
        private System.Windows.Forms.Label lblEditMobile;
        private System.Windows.Forms.TextBox txtEditFamily;
        private System.Windows.Forms.Label lblEditFamily;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblEditName;
    }
}