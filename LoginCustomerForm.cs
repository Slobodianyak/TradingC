using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectWF
{
    public partial class LoginCustomerForm : Form
    {
        private readonly ICustomer _customer;
        public LoginCustomerForm(ICustomer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private void LoginCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void customerLoginButton_Click(object sender, EventArgs e)
        {
            if (_customer.Log(customerLoginText.Text, customerPasswordText.Text))
            {
                DialogResult = DialogResult.OK;

                var CustomerMenu = new customerMenuForm(_customer, _customer.GetCustomerByLogin(customerLoginText.Text).CustomerID);
                CustomerMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void customerSignUpFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var SignUpCustomer = new SignUpCustomerForm(_customer);
        }
    }
}
