﻿namespace GiftHommieWinforms
{
    partial class frmStaff
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label6 = new System.Windows.Forms.Label();
            txtUnitPriceMaxSearch = new System.Windows.Forms.TextBox();
            txtUnitPriceMinSearch = new System.Windows.Forms.TextBox();
            cbProductSort = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            cbProductCategory = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtProductNameSearch = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtUnitsInStockMinSearch = new System.Windows.Forms.TextBox();
            btnReset = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtUnitsInStockMaxSearch = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBoxSearch = new System.Windows.Forms.GroupBox();
            btnAddProduct = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            gbProduct = new System.Windows.Forms.GroupBox();
            gbSelect = new System.Windows.Forms.GroupBox();
            txtCurrentIndex = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            txtAvailable = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtDesc = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbAvailable = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            pbProductAvatar = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            dgvProducts = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            tabHome = new System.Windows.Forms.TabPage();
            tabcontrolStaff = new System.Windows.Forms.TabControl();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            gbProduct.SuspendLayout();
            gbSelect.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabHome.SuspendLayout();
            tabcontrolStaff.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 20);
            label6.TabIndex = 0;
            label6.Text = "Unit Price Min";
            // 
            // txtUnitPriceMaxSearch
            // 
            txtUnitPriceMaxSearch.Location = new System.Drawing.Point(152, 87);
            txtUnitPriceMaxSearch.Name = "txtUnitPriceMaxSearch";
            txtUnitPriceMaxSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitPriceMaxSearch.TabIndex = 1;
            txtUnitPriceMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMaxSearch.TextChanged += txtUnitPriceMaxSearch_TextChanged;
            // 
            // txtUnitPriceMinSearch
            // 
            txtUnitPriceMinSearch.Location = new System.Drawing.Point(152, 45);
            txtUnitPriceMinSearch.Name = "txtUnitPriceMinSearch";
            txtUnitPriceMinSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitPriceMinSearch.TabIndex = 0;
            txtUnitPriceMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitPriceMinSearch.TextChanged += txtUnitPriceMinSearch_TextChanged;
            // 
            // cbProductSort
            // 
            cbProductSort.BackColor = System.Drawing.Color.White;
            cbProductSort.FormattingEnabled = true;
            cbProductSort.Items.AddRange(new object[] { "Sort by", "Price asc", "Price desc" });
            cbProductSort.Location = new System.Drawing.Point(9, 262);
            cbProductSort.Name = "cbProductSort";
            cbProductSort.Size = new System.Drawing.Size(290, 28);
            cbProductSort.TabIndex = 51;
            cbProductSort.SelectedIndexChanged += cbProductSort_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 240);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(57, 20);
            label15.TabIndex = 52;
            label15.Text = "Sorting";
            // 
            // cbProductCategory
            // 
            cbProductCategory.BackColor = System.Drawing.Color.White;
            cbProductCategory.FormattingEnabled = true;
            cbProductCategory.Items.AddRange(new object[] { "Select the category" });
            cbProductCategory.Location = new System.Drawing.Point(9, 190);
            cbProductCategory.Name = "cbProductCategory";
            cbProductCategory.Size = new System.Drawing.Size(290, 28);
            cbProductCategory.TabIndex = 3;
            cbProductCategory.SelectedIndexChanged += cbProductCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 168);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 50;
            label4.Text = "Category";
            // 
            // txtProductNameSearch
            // 
            txtProductNameSearch.BackColor = System.Drawing.Color.White;
            txtProductNameSearch.Location = new System.Drawing.Point(9, 121);
            txtProductNameSearch.Name = "txtProductNameSearch";
            txtProductNameSearch.Size = new System.Drawing.Size(290, 27);
            txtProductNameSearch.TabIndex = 0;
            txtProductNameSearch.TextChanged += txtProductNameSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 99);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 20);
            label5.TabIndex = 48;
            label5.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 20);
            label3.TabIndex = 2;
            label3.Text = "Units In Stock Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(16, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 20);
            label7.TabIndex = 0;
            label7.Text = "Units In Stock Min";
            // 
            // txtUnitsInStockMinSearch
            // 
            txtUnitsInStockMinSearch.Location = new System.Drawing.Point(152, 45);
            txtUnitsInStockMinSearch.Name = "txtUnitsInStockMinSearch";
            txtUnitsInStockMinSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitsInStockMinSearch.TabIndex = 0;
            txtUnitsInStockMinSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMinSearch.TextChanged += txtUnitsInStockMinSearch_TextChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new System.Drawing.Point(185, 39);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(114, 31);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUnitsInStockMaxSearch);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtUnitsInStockMinSearch);
            groupBox2.Location = new System.Drawing.Point(9, 469);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(311, 125);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Units In Stock";
            // 
            // txtUnitsInStockMaxSearch
            // 
            txtUnitsInStockMaxSearch.Location = new System.Drawing.Point(152, 84);
            txtUnitsInStockMaxSearch.Name = "txtUnitsInStockMaxSearch";
            txtUnitsInStockMaxSearch.Size = new System.Drawing.Size(138, 27);
            txtUnitsInStockMaxSearch.TabIndex = 1;
            txtUnitsInStockMaxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtUnitsInStockMaxSearch.TextChanged += txtUnitsInStockMaxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Unit Price Max";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUnitPriceMaxSearch);
            groupBox1.Controls.Add(txtUnitPriceMinSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(9, 316);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(311, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unit Price";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBoxSearch.Controls.Add(btnAddProduct);
            groupBoxSearch.Controls.Add(cbProductSort);
            groupBoxSearch.Controls.Add(label15);
            groupBoxSearch.Controls.Add(cbProductCategory);
            groupBoxSearch.Controls.Add(label4);
            groupBoxSearch.Controls.Add(txtProductNameSearch);
            groupBoxSearch.Controls.Add(label5);
            groupBoxSearch.Controls.Add(btnReset);
            groupBoxSearch.Controls.Add(groupBox2);
            groupBoxSearch.Controls.Add(groupBox1);
            groupBoxSearch.Controls.Add(btnSearch);
            groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBoxSearch.Size = new System.Drawing.Size(343, 723);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.LemonChiffon;
            btnAddProduct.Location = new System.Drawing.Point(83, 631);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(125, 38);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddToCart_Click;
            // 
            // btnSearch
            // 
            btnSearch.Enabled = false;
            btnSearch.Location = new System.Drawing.Point(25, 39);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(142, 31);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Auto Filting";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(1423, 723);
            splitContainer1.SplitterDistance = 343;
            splitContainer1.TabIndex = 87;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(gbProduct);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button1);
            splitContainer2.Panel2.Controls.Add(dgvProducts);
            splitContainer2.Panel2.Controls.Add(btnClose);
            splitContainer2.Size = new System.Drawing.Size(1076, 723);
            splitContainer2.SplitterDistance = 379;
            splitContainer2.TabIndex = 87;
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(gbSelect);
            gbProduct.Controls.Add(txtAvailable);
            gbProduct.Controls.Add(txtPrice);
            gbProduct.Controls.Add(groupBox3);
            gbProduct.Controls.Add(label1);
            gbProduct.Controls.Add(lbAvailable);
            gbProduct.Controls.Add(lbPrice);
            gbProduct.Controls.Add(lbProductName);
            gbProduct.Controls.Add(pbProductAvatar);
            gbProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            gbProduct.Location = new System.Drawing.Point(0, 0);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new System.Drawing.Size(1076, 379);
            gbProduct.TabIndex = 86;
            gbProduct.TabStop = false;
            gbProduct.Text = "Product Name";
            // 
            // gbSelect
            // 
            gbSelect.Controls.Add(txtCurrentIndex);
            gbSelect.Controls.Add(btnBack);
            gbSelect.Controls.Add(btnNext);
            gbSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbSelect.Location = new System.Drawing.Point(3, 323);
            gbSelect.Name = "gbSelect";
            gbSelect.Size = new System.Drawing.Size(1070, 53);
            gbSelect.TabIndex = 92;
            gbSelect.TabStop = false;
            // 
            // txtCurrentIndex
            // 
            txtCurrentIndex.Location = new System.Drawing.Point(473, 18);
            txtCurrentIndex.Name = "txtCurrentIndex";
            txtCurrentIndex.ReadOnly = true;
            txtCurrentIndex.Size = new System.Drawing.Size(126, 27);
            txtCurrentIndex.TabIndex = 1;
            txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(323, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(144, 31);
            btnBack.TabIndex = 0;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(605, 16);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(144, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next >>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new System.Drawing.Point(637, 122);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtAvailable.Size = new System.Drawing.Size(110, 27);
            txtAvailable.TabIndex = 2;
            txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(363, 122);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            txtPrice.Size = new System.Drawing.Size(110, 27);
            txtPrice.TabIndex = 1;
            txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDesc);
            groupBox3.Location = new System.Drawing.Point(290, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(733, 115);
            groupBox3.TabIndex = 89;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description";
            // 
            // txtDesc
            // 
            txtDesc.Location = new System.Drawing.Point(9, 26);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new System.Drawing.Size(715, 83);
            txtDesc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(299, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 28);
            label1.TabIndex = 88;
            // 
            // lbAvailable
            // 
            lbAvailable.AutoSize = true;
            lbAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAvailable.Location = new System.Drawing.Point(535, 121);
            lbAvailable.Name = "lbAvailable";
            lbAvailable.Size = new System.Drawing.Size(96, 28);
            lbAvailable.TabIndex = 87;
            lbAvailable.Text = "Available:";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(299, 121);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(58, 28);
            lbPrice.TabIndex = 86;
            lbPrice.Text = "Price:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbProductName.Location = new System.Drawing.Point(290, 49);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(236, 45);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            lbProductName.TextChanged += lbProductName_TextChanged;
            lbProductName.Click += lbProductName_Click;
            // 
            // pbProductAvatar
            // 
            pbProductAvatar.Location = new System.Drawing.Point(17, 39);
            pbProductAvatar.Name = "pbProductAvatar";
            pbProductAvatar.Size = new System.Drawing.Size(240, 271);
            pbProductAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbProductAvatar.TabIndex = 85;
            pbProductAvatar.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(963, 306);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(85, 29);
            button1.TabIndex = 84;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            dgvProducts.Location = new System.Drawing.Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new System.Drawing.Size(1076, 297);
            dgvProducts.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.Location = new System.Drawing.Point(1887, 597);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(85, 29);
            btnClose.TabIndex = 83;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(splitContainer1);
            tabHome.Location = new System.Drawing.Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Padding = new System.Windows.Forms.Padding(3);
            tabHome.Size = new System.Drawing.Size(1429, 729);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabHome_Click;
            // 
            // tabcontrolStaff
            // 
            tabcontrolStaff.Controls.Add(tabHome);
            tabcontrolStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            tabcontrolStaff.Location = new System.Drawing.Point(0, 0);
            tabcontrolStaff.Name = "tabcontrolStaff";
            tabcontrolStaff.SelectedIndex = 0;
            tabcontrolStaff.Size = new System.Drawing.Size(1437, 762);
            tabcontrolStaff.TabIndex = 1;
            tabcontrolStaff.TabStop = false;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 762);
            Controls.Add(tabcontrolStaff);
            Name = "frmStaff";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaff";
            FormClosing += frmStaff_FormClosing;
            Load += frmStaff_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            gbSelect.ResumeLayout(false);
            gbSelect.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabHome.ResumeLayout(false);
            tabcontrolStaff.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnitPriceMaxSearch;
        private System.Windows.Forms.TextBox txtUnitPriceMinSearch;
        private System.Windows.Forms.ComboBox cbProductSort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbProductCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitsInStockMinSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnitsInStockMaxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvailable;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox pbProductAvatar;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabControl tabcontrolStaff;
        private System.Windows.Forms.Button button1;
    }
}