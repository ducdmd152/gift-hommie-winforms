namespace GiftHommieWinforms
{
    partial class frmCheckout
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
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            dgvCheckout = new System.Windows.Forms.DataGridView();
            txtTotal = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            btnCheckout = new System.Windows.Forms.Button();
            txtMessage = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(285, 20);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "CHECKOUT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(438, 5);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "MESSAGE";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCheckout);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(txtMessage);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 63);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(752, 371);
            panel1.TabIndex = 15;
            // 
            // dgvCheckout
            // 
            dgvCheckout.AllowUserToAddRows = false;
            dgvCheckout.AllowUserToDeleteRows = false;
            dgvCheckout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvCheckout.Location = new System.Drawing.Point(0, 225);
            dgvCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvCheckout.Name = "dgvCheckout";
            dgvCheckout.ReadOnly = true;
            dgvCheckout.RowHeadersWidth = 51;
            dgvCheckout.RowTemplate.Height = 29;
            dgvCheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCheckout.Size = new System.Drawing.Size(752, 146);
            dgvCheckout.TabIndex = 24;
            // 
            // txtTotal
            // 
            txtTotal.Location = new System.Drawing.Point(116, 115);
            txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(154, 23);
            txtTotal.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(46, 116);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 22;
            label4.Text = "TOTAL:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(116, 85);
            txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(189, 23);
            txtAddress.TabIndex = 21;
            txtAddress.TextChanged += txtAddress_TextChanged;
            txtAddress.KeyPress += txtAddress_KeyPress;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(116, 53);
            txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(189, 23);
            txtPhone.TabIndex = 20;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // button2
            // 
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.Location = new System.Drawing.Point(578, 148);
            button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(78, 20);
            button2.TabIndex = 19;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnCheckout.Location = new System.Drawing.Point(438, 148);
            btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(78, 20);
            btnCheckout.TabIndex = 18;
            btnCheckout.Text = "ORDER";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += button1_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new System.Drawing.Point(342, 22);
            txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new System.Drawing.Size(316, 113);
            txtMessage.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(46, 55);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(50, 15);
            label9.TabIndex = 9;
            label9.Text = "PHONE:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(116, 20);
            txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(189, 23);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtPhone_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(46, 86);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "ADDRESS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 24);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "NAME:";
            // 
            // frmCheckout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(752, 434);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmCheckout";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCheckout";
            Load += frmCheckout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCheckout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCheckout;
    }
}