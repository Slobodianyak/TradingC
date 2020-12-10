using BusinessLogic.Interfaces;
using DTO;
using System;
using System.Windows.Forms;

namespace CourseProjectWF
{
    public partial class newItemForm : Form
    {
        private readonly IUser _shipper;
        public newItemForm(IUser shipper)
        {
            _shipper = shipper;
            InitializeComponent();
        }

        private void newItemForm_Load(object sender, EventArgs e)
        {

        }

        private void newItemConfirmButton_Click(object sender, EventArgs e)
        {
          

            if (newItemName.Text.Length==0|| newItemPrice.Text.Length == 0|| newItemOnStock.Text.Length == 0)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                ItemDTO newItem = new ItemDTO
                {
                    Name = newItemName.Text,
                    Price = Convert.ToDouble(newItemPrice.Text),
                    OnStock = Convert.ToInt32(newItemOnStock.Text)
                };
                _shipper.AddItem(newItem);
                MessageBox.Show("Item was successfully created!");
                this.Close();
            }
        }
    }
}
