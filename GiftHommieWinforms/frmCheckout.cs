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
using System.Xml.Schema;

namespace GiftHommieWinforms
{
    public partial class frmCheckout : Form
    {
        private IOrderRepository orderRepository = new OrderRepository();
        private IProductRepository productRepository = new ProductRepository();
        public List<Cart> CartList;
        public double Total;
        private string DEFAULT_STATUS = "PENDING";
        public frmCheckout()
        {
            InitializeComponent();
        }
        private void CheckValidation()
        {
            if (txtPhone.Text.Trim().Length < 10)
                throw new Exception("WRONG FORMAT OF PHONE NUMBER");
            if (txtName.Text.Trim().Length < 5)
                throw new Exception("WRONG FORMAT OF NAME");
            if (txtAddress.Text.Trim().Length < 5)
                throw new Exception("WRONG FORMAT OF ADDRESS");
        }

        private Order GetCurrentOrder()
        {
            return new Order
            {
                Username = GlobalData.AuthenticatedUser.Username,
                LastUpdatedTime = DateTime.Now,
                Name = txtName.Text,
                Address = txtAddress.Text,
                OrderTime = DateTime.Now,
                Message = txtMessage.Text,
                Status = DEFAULT_STATUS,
                Comment = txtComment.Text,
                Phone = txtPhone.Text,
            };
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtName.Text = GlobalData.AuthenticatedUser.Name;
            txtAddress.Text = GlobalData.AuthenticatedUser.Address;
            txtPhone.Text = GlobalData.AuthenticatedUser.Phone;
            txtTotal.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<OrderDetail> detals = new List<OrderDetail>();
            try
            {
                Order order = GetCurrentOrder();
                List<OrderDetail> details = new List<OrderDetail>();

                foreach (Cart cart in CartList)
                {
                    details.Add(new OrderDetail
                    {
                        ProductId = cart.ProductId,
                        Price = productRepository.Get((int)cart.ProductId).Price
                                * cart.Quantity,
                        Quantity = cart.Quantity,
                    });
                }
                order.OrderDetails = details;
                orderRepository.Add(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtAddress.Text)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != ',')
                {
                    int len = txtAddress.Text.Length;
                    txtAddress.Text = txtAddress.Text.Remove(txtAddress.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtName.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtPhone.Text)
            {
                if (!char.IsDigit(c))
                {
                    txtPhone.Text = txtPhone.Text.Remove(txtPhone.Text.Length - 1, 1);
                    MessageBox.Show("WRONG FORMAT");
                    return;
                }
            }
        }
    }
}
