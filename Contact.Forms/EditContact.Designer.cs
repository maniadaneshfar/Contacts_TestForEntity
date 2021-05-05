
namespace Contact.Forms
{
    partial class frmEditContact
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
            this.btnEditInEditForm = new System.Windows.Forms.Button();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtEditMobile = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditFamily = new System.Windows.Forms.TextBox();
            this.lblFamily = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditInEditForm
            // 
            this.btnEditInEditForm.Location = new System.Drawing.Point(242, 293);
            this.btnEditInEditForm.Name = "btnEditInEditForm";
            this.btnEditInEditForm.Size = new System.Drawing.Size(75, 23);
            this.btnEditInEditForm.TabIndex = 21;
            this.btnEditInEditForm.Text = "ویرایش";
            this.btnEditInEditForm.UseVisualStyleBackColor = true;
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(12, 138);
            this.txtEditAddress.Multiline = true;
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(514, 137);
            this.txtEditAddress.TabIndex = 20;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(532, 141);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 14);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "آدرس:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(532, 85);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(66, 14);
            this.lblMobile.TabIndex = 18;
            this.lblMobile.Text = "تلفن همراه:";
            // 
            // txtEditMobile
            // 
            this.txtEditMobile.Location = new System.Drawing.Point(333, 82);
            this.txtEditMobile.Name = "txtEditMobile";
            this.txtEditMobile.Size = new System.Drawing.Size(193, 22);
            this.txtEditMobile.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(226, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 14);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "ایمیل:";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(12, 82);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(208, 22);
            this.txtEditEmail.TabIndex = 15;
            // 
            // txtEditFamily
            // 
            this.txtEditFamily.Location = new System.Drawing.Point(12, 34);
            this.txtEditFamily.Name = "txtEditFamily";
            this.txtEditFamily.Size = new System.Drawing.Size(208, 22);
            this.txtEditFamily.TabIndex = 14;
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(226, 37);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(76, 14);
            this.lblFamily.TabIndex = 13;
            this.lblFamily.Text = "نام خانوادگی:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(333, 34);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(193, 22);
            this.txtEditName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(532, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 14);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "نام:";
            // 
            // frmEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 357);
            this.Controls.Add(this.btnEditInEditForm);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtEditMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.txtEditFamily);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش مخاطب";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditInEditForm;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtEditMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label lblName;
    }
}