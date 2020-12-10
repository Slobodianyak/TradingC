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
    public partial class newPositionForm : Form
    {
        private readonly ICustomer _customer;
        private readonly int _orderID;
        public newPositionForm(ICustomer customer, int orderID )
        {
            _customer = customer;
            _orderID = orderID;
            InitializeComponent();
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPositionForm_Load(object sender, EventArgs e)
        {

        }

        private void newPositionButton_Click(object sender, EventArgs e)
        {
            try {
                AddToOrderDTO position = new AddToOrderDTO
                {
                    OrderIDKEY = _orderID,
                    ItemIDKEY = Convert.ToInt32(ItemIDOrder.Text),
                    Amount = Convert.ToInt32(AmountOrder.Text)
            };
                _customer.AddPosition(position);
                ItemIDOrder.Clear();
                AmountOrder.Clear();
            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}
