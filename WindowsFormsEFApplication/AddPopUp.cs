﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            PopupPriceWarning.Visible = false;
            PopupStockWarning.Visible = false;
            DatabaseHandler databaseHandler = new DatabaseHandler();
            Product product = new Product();
            product.Id = databaseHandler.GetFirstAvailableId();
            product.Name = AddNameTextBox.Text;
            product.Description = AddDescriptionTextBox.Text;
            

            if (string.IsNullOrEmpty(AddPriceTextBox.Text) || !int.TryParse(AddPriceTextBox.Text, out int resultPrice))
            {
                PopupPriceWarning.Visible = true;
                return;
            }
            else
            {
                product.Price = resultPrice;
            }

            if (string.IsNullOrEmpty(AddStockTextBox.Text) || !int.TryParse(AddStockTextBox.Text, out int resultStock))
            {
                PopupStockWarning.Visible = true;
                return;
            }
            else
            {
                product.Price = resultStock;
            }

            product.Price = Convert.ToInt32(AddPriceTextBox.Text);
            product.stock = Convert.ToInt32(AddStockTextBox.Text);
            databaseHandler.AddProduct(product);
            this.Close();
        }
    }
}
