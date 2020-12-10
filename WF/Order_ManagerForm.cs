using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Interfaces;

namespace CourseProjectWF
{
    public partial class Order_ManagerForm : Form
    {



        protected readonly IUser _shipper;

        public Order_ManagerForm(IUser shipper)
        {
            
            _shipper= shipper;
            InitializeComponent();
        }
      

        private void LoginShipperForm_Load(object sender, EventArgs e)
        {
        
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void shipperLoginButton_Click(object sender, EventArgs e)
        {
            if (_shipper.Log(shipperLoginText.Text, ShipperPasswordText.Text))
            {
                DialogResult = DialogResult.OK;
                
                var ShipperMenu = new order_managerMenuForm(_shipper, _shipper.GetShipperByLogin(shipperLoginText.Text).ShipperID);
                ShipperMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            
        }

        private void ShipperPasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShipperLoginFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var NewShipper = new SignUpOrder_ManagerForm(_shipper);
            NewShipper.Show();
            this.Hide();

        }
    }
}
