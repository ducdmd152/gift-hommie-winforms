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

    public partial class frmStaff : Form
    {
        private IProductRepository productRepository = new ProductRepository();
        private BindingSource bindingSource = null;
        private bool orderTimeDescMode = true;

        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var frm = new frmStaffManageProduct();
            frm.ShowDialog();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            tabHome_Click(sender, e);
        }

        private void tabHome_Click(object sender, EventArgs e)
        {
            HomeInitDataForSearchComponent();
            HomeLoadData();
        }

        private void HomeInitDataForSearchComponent()
        {

        }

        private void HomeLoadData()
        {
            List<Product> products = productRepository.GetAllWithFilter(
                "",
                txtProductNameSearch.Text,
                txtUnitPriceMinSearch.Text, txtUnitPriceMaxSearch.Text,
                txtUnitsInStockMinSearch.Text, txtUnitsInStockMaxSearch.Text,
                ToIntOrZero(cbProductCategory.SelectedValue.ToString()),
                true);
            if (cbProductSort.SelectedIndex == 1)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else if (cbProductSort.SelectedIndex == 2)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }

            //HomeLoadDataToGridView(products);
        }

        private int ToIntOrZero(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch
            {
                return 0;
            }
        }
    }
}
