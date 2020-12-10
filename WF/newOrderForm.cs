using BusinessLogic.Interfaces;
using DTO;
using System;
using System.Windows.Forms;

namespace CourseProjectWF
{
    public partial class newOrderForm : Form
    {
        private readonly ICustomer _customer;
        private readonly int _customerID;
       
        public newOrderForm(ICustomer customer, int customerID)
        {
            
            _customerID = customerID;
            _customer = customer;
            InitializeComponent();
        }

        private void newOrderForm_Load(object sender, EventArgs e)
        {
          
        }



        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDTO order = new OrderDTO
                {
                    ShipperIDKEY = Convert.ToInt32(ShipperIDOrderBox.Text),
                    CustomerIDKEY = _customerID,
                    Comment = CommentBox.Text,
                   Date = DateTime.Now,
                  

                };
                _customer.AddOrder(order);
                var pos = new newPositionForm(_customer, order.OrderID);
                pos.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
        }
    }

