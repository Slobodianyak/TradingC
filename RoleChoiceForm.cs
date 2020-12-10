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
    public partial class RoleChoiceForm : Form
    {
        private readonly IUser _shipper;
        private readonly ICustomer _customer;
        public RoleChoiceForm(IUser shipper, ICustomer customer)
        {
            _shipper = shipper;
            _customer = customer;
            InitializeComponent();
        }

        

        private void RoleChoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void ShipperWelcomeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var shipperRole = new Order_ManagerForm(_shipper);
            shipperRole.Show();
            this.Hide();
        }

        private void CustomerWelcomeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var customerRole = new LoginCustomerForm(_customer);
            customerRole.Show();
            this.Hide();
        }
    }
    }

