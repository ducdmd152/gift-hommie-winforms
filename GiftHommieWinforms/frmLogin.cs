﻿using BusinessObjects;
using BussinessObjects;
using GiftHommieWinforms;
using System;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private IUserRepository userRepository = new UserRepository();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {                     
            
                User user = null;
                try
                {
                    user = userRepository.Authenticate(txtEmail.Text, txtPassword.Text);
                    if(user != null)
                    {
                        GlobalData.AuthenticatedUser = user;
                        if (user.Role.Equals("CUSTOMER")) // CUSTOMER
                        {
                            frmCustomer frmCustomer = new frmCustomer();
                            this.Hide();
                            frmCustomer.Show();
                            frmCustomer.FormClosed += delegate
                            {
                                this.Close();
                            };
                        }
                        else if (user.Role.Equals("STAFF")) // STAFF
                        {
                            //frmStaff frmStaff = new frmStaff();
                            //this.Hide();
                            //frmStaff.Show();
                            //frmStaff.FormClosed += delegate
                            //{
                            //    this.Close();
                            //};
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong email or password!!!", "Login Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login Fail");
                }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }

}