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
    public partial class order_managerMenuForm : Form
    {
        protected readonly IUser _shipper;
        protected readonly int _shipperID;


        public order_managerMenuForm(IUser shipper, int shipperID)
        {
            _shipperID = shipperID;
             _shipper = shipper;
            InitializeComponent();
        }

        private void shipperMenuForm_Load(object sender, EventArgs e)
        {
          
            addItemButton.Hide();
            dataGridView1.Rows.Clear();
            dataGridView1.BringToFront();
            OrderPanel.BringToFront();
            foreach (var order in _shipper.ShowOrders(_shipperID))
            {
                dataGridView1.Rows.Add(order.OrderID, order.CustomerIDKEY, order.Date, order.Comment);
              
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableChoiceBox_Enter(object sender, EventArgs e)
        {

        }

        private void OrdersBox_CheckedChanged(object sender, EventArgs e)
        {
            addItemButton.Hide();
            OrderPanel.BringToFront();
            dataGridView1.BringToFront();
            dataGridView1.Rows.Clear();
           
            foreach (var order in _shipper.ShowOrders(_shipperID))
            {
                dataGridView1.Rows.Add(order.OrderID, order.CustomerIDKEY, order.Date, order.Comment);
                
            }
        }

        private void ItemsBox_CheckedChanged(object sender, EventArgs e)
        {
            
            addItemButton.Show();
            dataGridView2.BringToFront();
            ItemPanel.BringToFront();
            dataGridView1.Rows.Clear();
            
            dataGridView2.Rows.Clear();
            foreach (var item in _shipper.ShowItems())
            {
                dataGridView2.Rows.Add(item.ItemID, item.Name, item.Price, item.OnStock);
              
            }
            
            if (textBox1.Text.Length != 0)
            {
                updateItemButton_Click_1(sender, e);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }




        }

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length != 0)
            {
                if (_shipper.GetItem(Convert.ToInt32(textBox1.Text)).ItemID != Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("Item doesn't exist");
                }
                else
                {
                    _shipper.RemoveItem(Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Item was successfully removed!");
                }
            }
            else
            {
                MessageBox.Show("Invalid data");
            }
        }

      


        private void updateItemButton_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (_shipper.GetItem(Convert.ToInt32(textBox1.Text)).ItemID != Convert.ToInt32(textBox1.Text))
                {
                    MessageBox.Show("Item doesn't exist");
                }
                else
                {
                    ItemDTO item1 = new ItemDTO
                    {
                        ItemID = Convert.ToInt32(textBox1.Text),
                        Name = textBox2.Text,
                        Price = Convert.ToDouble(textBox3.Text),
                        OnStock = Convert.ToInt32(textBox4.Text)
                    };

                    _shipper.ChangeItem(item1);
                    MessageBox.Show("Item was successfully updated!");
                }
            }
            else
            {
                MessageBox.Show("Invalid data");
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var newItem = new newItemForm(_shipper);
            newItem.Show();
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                _shipper.CompleteOrder(Convert.ToInt32(orderIDBoxComplete.Text));
                MessageBox.Show("Order was successfully completed!");
            }
            catch
            {
                MessageBox.Show("You have not enough items to complete order or it doesn't exist");
            }
        }

        private void RejectOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                _shipper.DeleteOrder(Convert.ToInt32(orderIDBoxComplete.Text));
                MessageBox.Show("Order was successfully rejected!");
            }
            catch
            {
                MessageBox.Show("An error occured, try again later");
            }
        }

        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(_shipper.GetOrder(Convert.ToInt32(orderIDBoxComplete.Text)));
            }
            catch
            {
                MessageBox.Show("An order does not exist");
            }
        }

        private void OrderPanel_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LogOut = new Order_ManagerForm(_shipper);
            LogOut.Show();
            this.Hide();
        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Rows.Add(_shipper.GetItem(Convert.ToInt32(textBox5.Text)));
            }
            catch
            {
                MessageBox.Show("An item does not exist");
            }
        }
    }
}
