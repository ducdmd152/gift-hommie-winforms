namespace GiftHommieWinforms
{
    partial class frmEditFee
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
            txtFeeEdit = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Shipping Fee";
            // 
            // txtFeeEdit
            // 
            txtFeeEdit.Location = new System.Drawing.Point(102, 65);
            txtFeeEdit.Name = "txtFeeEdit";
            txtFeeEdit.Size = new System.Drawing.Size(130, 23);
            txtFeeEdit.TabIndex = 1;
            txtFeeEdit.KeyPress += txtFeeEdit_KeyPress;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(102, 124);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEditFee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(265, 159);
            Controls.Add(button1);
            Controls.Add(txtFeeEdit);
            Controls.Add(label1);
            Name = "frmEditFee";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EditFee";
            Load += frmEditFee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeeEdit;
        private System.Windows.Forms.Button button1;
    }
}