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
    public partial class SignUpShipperForm : Form
    {
        private readonly IUser _shipper;
        public SignUpShipperForm(IUser shipper)
        {
            _shipper = shipper;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SignUpShipperForm_Load(object sender, EventArgs e)
        {

        }

        private void shipperSignUpButtom_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0||textBox2.Text.Length==0||textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                ShipperDTO user = new ShipperDTO
                {
                    Login = textBox1.Text,
                    Password = new ConsoleProject.PasswordActions().PasswordEncryption(textBox2.Text),
                    EMail = textBox3.Text,
                    Addres = textBox4.Text,
                    Phone = textBox5.Text,
                    Description = textBox6.Text
                };

                _shipper.AddShipper(user);
                var shipperMenu = new order_managerMenuForm(_shipper, user.ShipperID);
                shipperMenu.Show();
                this.Hide();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LinkToShipperLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var LoginShipper = new Order_ManagerForm(_shipper);
            LoginShipper.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
