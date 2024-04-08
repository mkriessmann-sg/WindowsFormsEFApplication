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
    public partial class EditPopup : Form
    {

        int id;
        public EditPopup()
        {
            InitializeComponent();
        }

        private void PopUpCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetData(int IDtoEdit)
        {

            id = IDtoEdit;
            DatabaseHandler databaseHandler = new DatabaseHandler();
            Product product = databaseHandler.GetProductById(id);
            EditDescriptionTextBox.Text = product.Description;
            EditNameTextBox.Text = product.Name;
            EditPriceTextBox.Text= Convert.ToString(product.Price);
            EditStockTextBox.Text = Convert.ToString(product.stock);

        }

        private void PopUpAddButton_Click(object sender, EventArgs e)
        {
            EditPopupPriceWarning.Visible = false;
            EditPopupStockWarning.Visible = false;
            DatabaseHandler databaseHandler = new DatabaseHandler();
            Product product = new Product();
            product.Id = id;
            product.Name = EditNameTextBox.Text;
            product.Description = EditDescriptionTextBox.Text;

            //TODO: Make this more elegant
            if (string.IsNullOrEmpty(EditPriceTextBox.Text) || !int.TryParse(EditPriceTextBox.Text, out int resultPrice))
            {
                EditPopupPriceWarning.Visible = true;
                return;
            }
            else
            {
                product.Price = resultPrice;
            }

            if (string.IsNullOrEmpty(EditStockTextBox.Text) || !int.TryParse(EditStockTextBox.Text, out int resultStock))
            {
                EditPopupStockWarning.Visible = true;
                return;
            }
            else
            {
                product.Price = resultStock;
            }

            product.Price = Convert.ToInt32(EditPriceTextBox.Text);
            product.stock = Convert.ToInt32(EditStockTextBox.Text);
            databaseHandler.UpdateEntrybyID(product);
            this.Close();
        }
    }
}
