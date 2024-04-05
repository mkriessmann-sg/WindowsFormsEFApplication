using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEFApplication
{
    public partial class AddPopUp : Form
    {
        public AddPopUp()
        {
            InitializeComponent();
        }
        //Cancel button function
        private void PopUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUpAddButton_Click(object sender, EventArgs e)
        {
            DatabaseHandler databaseHandler = new DatabaseHandler();
            Product product = new Product();
            product.Id = databaseHandler.GetFirstAvailableId();
            product.Name = AddNameTextBox.Text;
            product.Description = AddDescriptionTextBox.Text;
            //TODO:implement input safety for integer inputs
            product.Price = Convert.ToInt32(AddPriceTextBox.Text);
            product.stock = Convert.ToInt32(AddStockTextBox.Text);
            databaseHandler.AddProduct(product);
            this.Close();
        }
    }
}
