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
    public partial class customerMenuForm : Form
    {
        private readonly ICustomer _customer;
        private readonly int _customerID;
        public customerMenuForm(ICustomer customer, int customerID)
        {
            _customerID = customerID;
            _customer = customer;
            InitializeComponent();
        }

        private void customerMenuForm_Load(object sender, EventArgs e)
        {
            foreach (var item in _customer.ShowItems())
            {
                dataGridView1.Rows.Add(item.ItemID, item.Name, item.Price, item.OnStock);

            }
        }

        private void LogOutCustomerButton_Click(object sender, EventArgs e)
        {
            var LogOut = new LoginCustomerForm(_customer);
            LogOut.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in _customer.ShowItems())
            {
                dataGridView1.Rows.Add(item.ItemID, item.Name, item.Price, item.OnStock);

            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            var newOrder = new newOrderForm(_customer, _customerID);
            newOrder.Show();
        }
    }
}
