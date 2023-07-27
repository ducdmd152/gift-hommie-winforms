using BusinessObjects;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiftHommieWinforms
{

    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadDataToYob();
        }

        private void LoadDataToYob()
        {
            List<int> yob = new List<int>();
            int i = 2023;
            while (i > 1950)
            {
                yob.Add(i);
                i--;
            }
            cbYob.DataSource = yob;
            cbYob.SelectedIndex = 0;
        }

        //CHECK VALIDATION
        private bool CheckCharacterOfPhone(String input)
        {
            string pattern = @"^\d{9,12}$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }
        private bool CheckCharacter(String input)
        {
            string pattern = "^[a-zA-Z ]+$"; // Ký tự chữ cái không phải là số
            return Regex.IsMatch(input, pattern);
        }

        private bool CheckName(String input)
        {
            if (input.Trim().Length <= 5)
            {
                txtName.Focus();
                throw new Exception("NAME WAS TOO SHORT");
            }


            string pattern = @"\d"; // Ký tự chữ cái không phải là số
            if (Regex.IsMatch(input, pattern))
            {
                txtName.Focus();
                throw new Exception("WRONG FORMAT OF NAME");
            }

            return true;
        }

        private bool CheckPassword(String input)
        {
            if (input.Length <= 5)
            {
                txtPassword.Focus();
                txtConfirmPassword.Clear();
                throw new Exception("PASSWORD WAS TOO SHORT");
            }

            return true;
        }

        private bool CheckUsername(String input)
        {
            string pattern = "^[a-zA-Z0-9]{4,20}$";
            if (!Regex.IsMatch(input, pattern))
            {
                txtUserName.Focus();
                throw new Exception("WRONG FORMAT OF USERNAME");
            }
            if (input.Length <= 5)
            {
                txtUserName.Focus();
                throw new Exception("USERNAME WAS TOO SHORT");
            }

            if (userRepository.Exist(input))
            {
                txtUserName.Focus();
                throw new Exception("USERNAME WAS EXIST");
            }

            return true;
        }

        private bool CheckPhone(String input)
        {
            if (!CheckCharacterOfPhone(txtPhone.Text))
            {
                txtPhone.Focus();
                throw new Exception("PLEASE TYPE THE PHONE NUMBER FROM 9 to 12 DIGITS");
            }

            if (input[0] != '0')
            {
                txtPhone.Focus();
                throw new Exception("WRONG FORMAT OF PHONE");
            }

            if (userRepository.GetAll().Where(u => u.Phone == txtPhone.Text).Count() > 0)
            {
                txtPhone.Focus();
                throw new Exception("PHONE WAS EXIST");
            }

            return true;
        }

        private bool CheckEmail(string input)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            if (!Regex.IsMatch(input, pattern))
            {
                txtEmail.Focus();
                throw new Exception("WRONG FORMAT OF EMAIL");
            }

            if (userRepository.Exist(txtEmail.Text))
            {
                txtEmail.Focus();
                throw new Exception("EMAIL WAS EXIST");
            }
            return true;
        }

        private bool ValidateInputs()
        {
            try
            {
                if (
                string.IsNullOrEmpty(txtUserName.Text.Trim()) ||
                string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                string.IsNullOrEmpty(txtName.Text.Trim()) ||
                string.IsNullOrEmpty(txtPhone.Text.Trim()) ||
                string.IsNullOrEmpty(txtPassword.Text.Trim()) ||
                string.IsNullOrEmpty(txtPassword.Text.Trim()) ||
                (rbMale.Checked == false && rbFemale.Checked == false)
                )
                {
                    throw new Exception("PLEASE FILL ALL REQUIRED FIELD");
                }
                CheckUsername(txtUserName.Text);

                CheckEmail(txtEmail.Text);

                CheckName(txtName.Text);

                CheckPhone(txtPhone.Text);

                CheckPassword(txtPassword.Text);

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    //MessageBox.Show("Password và confirm password không giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtConfirmPassword.Clear();
                    throw new Exception("PASSWORD AND CONFIRM PASSWORD WAS NOT SIMILAR");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        //CHECK VALIDATION
        private void btnRegister_Click(object sender, EventArgs e)
        {
            byte tmpGender;
            try
            {
                if (ValidateInputs() == true)
                {
                    if (rbMale.Checked == true)
                    {
                        tmpGender = 1;
                    }
                    else
                    {
                        tmpGender = 0;
                    }
                    User user = new User()
                    {
                        Username = txtUserName.Text,
                        Email = txtEmail.Text,
                        Role = "CUSTOMER",
                        Password = txtPassword.Text,
                        Name = txtName.Text,
                        Phone = txtPhone.Text,
                        Gender = tmpGender,
                        Yob = int.Parse(cbYob.Text),
                        Address = txtAddress.Text,
                        Avatar = null,
                        Enabled = true
                    };
                    DialogResult d;
                    d = MessageBox.Show($"Confirm register ", "Profile", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        userRepository.Create(user);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInformation();
        }

        private void ResetInformation()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtName.Text = string.Empty;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
