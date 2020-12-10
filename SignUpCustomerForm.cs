using BusinessLogic.Interfaces;
using DTO;
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
    public partial class SignUpCustomerForm : Form
    {
        private readonly ICustomer _customer;
        public SignUpCustomerForm(ICustomer customer)
        {
            _customer = customer;
            InitializeComponent();
        }

        private void SignUpCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void shipperSignUpButtom_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                CustomerDTO user = new CustomerDTO
                {
                    
                    EMail = textBox3.Text,
                    Addres = textBox4.Text,
                    Phone = textBox5.Text,
                    Description = textBox6.Text
                };

                _customer.AddCustomer(user);
                var customerMenu = new customerMenuForm(_customer, user.CustomerID);
                customerMenu.Show();
                this.Hide();
            }
        }

        private void LinkToCustomerLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var LoginCustomer = new LoginCustomerForm(_customer);
            LoginCustomer.Show();
            this.Hide();
        }
    }
}
