﻿namespace GiftHommieWinforms
{
    partial class frmRegister
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            cbYob = new System.Windows.Forms.ComboBox();
            rbMale = new System.Windows.Forms.RadioButton();
            rbFemale = new System.Windows.Forms.RadioButton();
            txtPhone = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(307, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 37);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(29, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(29, 98);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(29, 229);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(29, 143);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 21);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(388, 54);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 21);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(388, 98);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 21);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(29, 185);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 21);
            label8.TabIndex = 7;
            label8.Text = "Yob";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(388, 138);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(66, 21);
            label9.TabIndex = 8;
            label9.Text = "Address";
            // 
            // txtUserName
            // 
            txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUserName.Location = new System.Drawing.Point(181, 54);
            txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(166, 29);
            txtUserName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(181, 94);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(166, 29);
            txtEmail.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(181, 138);
            txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(166, 29);
            txtName.TabIndex = 11;
            // 
            // cbYob
            // 
            cbYob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbYob.FormattingEnabled = true;
            cbYob.Location = new System.Drawing.Point(181, 179);
            cbYob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbYob.Name = "cbYob";
            cbYob.Size = new System.Drawing.Size(166, 29);
            cbYob.TabIndex = 12;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new System.Drawing.Point(483, 55);
            rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new System.Drawing.Size(51, 19);
            rbMale.TabIndex = 13;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new System.Drawing.Point(564, 55);
            rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new System.Drawing.Size(63, 19);
            rbFemale.TabIndex = 14;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPhone.Location = new System.Drawing.Point(483, 96);
            txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(166, 29);
            txtPhone.TabIndex = 15;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddress.Location = new System.Drawing.Point(483, 138);
            txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(232, 65);
            txtAddress.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(181, 224);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(166, 29);
            txtPassword.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(29, 270);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 21);
            label10.TabIndex = 18;
            label10.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtConfirmPassword.Location = new System.Drawing.Point(181, 265);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new System.Drawing.Size(166, 29);
            txtConfirmPassword.TabIndex = 19;
            // 
            // btnRegister
            // 
            btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.Location = new System.Drawing.Point(239, 311);
            btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(106, 33);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReset.Location = new System.Drawing.Point(388, 311);
            btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(106, 33);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(833, 389);
            Controls.Add(btnReset);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label10);
            Controls.Add(txtPassword);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(cbYob);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmRegister";
            Text = "frmRegister";
            Load += frmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox cbYob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label10;
    }
}