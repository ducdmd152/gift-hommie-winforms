using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GiftHommieWinforms
{
    public partial class frmEditFee : Form
    {
        public frmEditFee()
        {
            InitializeComponent();
        }
        private IOrderRepository orderRepository = new OrderRepository();

        public Order ordertmp { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ordertmp != null)
            {
                DialogResult d;
                d = MessageBox.Show($"Save Shipping Fee Order ", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    ordertmp.ShippingFee = double.Parse(txtFeeEdit.Text);
                    orderRepository.Save(ordertmp);
                    DialogResult = DialogResult.OK;


                }
            }
        }

        private void frmEditFee_Load(object sender, EventArgs e)
        {
            txtFeeEdit.Text = ordertmp.ShippingFee.ToString();
        }

        private void txtFeeEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
