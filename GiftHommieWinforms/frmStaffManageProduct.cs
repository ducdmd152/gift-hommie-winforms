using BusinessObjects;
using BussinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftHommieWinforms
{
    public partial class frmStaffManageProduct : Form
    {
        public frmStaffManageProduct()
        {
            InitializeComponent();
        }
        private IProductRepository productRepository = new ProductRepository();
        public Product Product { get; set; }

        // Create = false, Update = true
        public Boolean CreateOrUpdate { get; set; }

        private void frmStaffManageProduct_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadDataToUpdate();
        }


        private void LoadDataToUpdate()
        {
            txtName.Text = Product.Name;
            txtPrice.Text = Convert.ToString(Product.Price);
            txtAvailable.Text = Convert.ToString(Product.Status);
            txtDesciption.Text = Product.Description;
            txtQuantity.Text = Convert.ToString(Product.Quantity);
            txtImgUrl.Text = Product.Avatar;
            Category c = productRepository.GetCategoryById(Product.CategoryId);
            cbProductCategory.Text = c.Name;
        }
        private void LoadCategoryList()
        {
            try
            {
                var CategoryList = productRepository.GetAllCategories();
                cbProductCategory.DataSource = CategoryList;
                cbProductCategory.DisplayMember = "Name";
                cbProductCategory.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of categories");
            }
        }

        private bool ValidateInputs()
        {
            if (
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtImgUrl.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtDesciption.Text) ||
                string.IsNullOrEmpty(txtAvailable.Text)

                )

            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == true)
            {

                // Lấy dữ liệu của Product Detail
                Product p = new Product()
                {
                    Id = Product.Id,
                    Name = txtName.Text,
                    Price = double.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Avatar = txtImgUrl.Text,
                    Description = txtDesciption.Text,
                    Status = bool.Parse(txtAvailable.Text),
                    CategoryId = int.Parse(cbProductCategory.SelectedValue.ToString())
                };

                // Update
                if (CreateOrUpdate == true)
                {
                    DialogResult d;
                    d = MessageBox.Show($"Bạn sẽ lưu thông tin Product {p.Name}", "Quản lý thông tin Product - Thay Đổi Dữ Liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                    if (d == DialogResult.OK)
                    {
                        productRepository.Update(p);
                        DialogResult = DialogResult.OK;
                    }

                }



            }
        }
    }
}
