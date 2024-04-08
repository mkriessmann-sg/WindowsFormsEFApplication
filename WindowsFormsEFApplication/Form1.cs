using System.Globalization;

namespace WindowsFormsEFApplication
{
    public partial class Form1 : Form
    {

        //0stock larger, 1stock smaller, 2price larger, 3price smaller
        int orderIndex;
        List<Product> currentProducts;
        public QueryObject query = new QueryObject();
        public int selectedProductID;



        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            UpdateList();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }




        public void UpdateList()
        {
            
            DatabaseHandler databaseHandler = new DatabaseHandler();
            currentProducts = databaseHandler.GetProducts(query);
            currentProducts = ChangeOrder(currentProducts);
            listView1.Clear();
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Stock");
            listView1.Columns.Add("Description");

            foreach (Product product in currentProducts)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());

                // Add sub-items for each property
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price?.ToString());
                item.SubItems.Add(product.stock?.ToString());
                item.SubItems.Add(product.Description);

                listView1.Items.Add(item);
            }
            
            listView1.Refresh();
        }

        private void TsukaButton_Click(object sender, EventArgs e)
        {
            AddPopUp addPopUp = new AddPopUp();

            addPopUp.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DatabaseHandler databaseHandler = new DatabaseHandler();

            if (listView1.SelectedItems.Count > 0)
            {
                // Iterate over the selected items
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    // Access the property of each selected item
                    int productID = Convert.ToInt32(selectedItem.Text);
                    databaseHandler.DeleteProduct(productID);
                    databaseHandler.GetProducts(query);
                    UpdateList();
                }
            }
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            query.minPrice = null;
            query.maxPrice = null;
            query.minStock = null;
            query.maxStock = null;
            query.descriptionQuery = null;
            query.nameQuery = null;
            UpdateList();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query.nameQuery = QueryNameBox.Text;
            query.descriptionQuery = QueryDescriptionBox.Text;
            WarningLabelPrice.Visible = false;
            WarningLabelStock.Visible = false;

            //TODO:Ducttape solution. Find elegant solution to this input problem

            if (string.IsNullOrEmpty(QueryPriceMaxBox.Text))
            {
                query.maxPrice = null;
            }
            else
            {
                if (int.TryParse(QueryPriceMaxBox.Text, out int resultMaxPrice))
                {
                    query.maxPrice = resultMaxPrice;
                }
                else
                {
                    WarningLabelPrice.Visible = true;
                    return;

                }
            }

            if (string.IsNullOrEmpty(QueryPriceMinBox.Text))
            {
                query.minPrice = null;
            }
            else
            {
                if (int.TryParse(QueryPriceMinBox.Text, out int resultMinPrice))
                {
                    query.minPrice = resultMinPrice;
                }
                else
                {
                    WarningLabelPrice.Visible = true;
                    return;

                }
            }

            if (string.IsNullOrEmpty(QueryStockMinBox.Text))
            {
                query.minStock = null;
            }
            else
            {
                if (int.TryParse(QueryStockMinBox.Text, out int resultMinStock))
                {
                    query.minStock = resultMinStock;
                }
                else
                {
                    WarningLabelStock.Visible = true;
                    return;

                }
            }

            if (string.IsNullOrEmpty(QueryStockMaxBox.Text))
            {
                query.maxStock = null;
            }
            else
            {
                if (int.TryParse(QueryStockMinBox.Text, out int resultMaxStock))
                {
                    query.maxStock = resultMaxStock;
                }
                else
                {
                    WarningLabelStock.Visible = true;
                    return;

                }
            }
            UpdateList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                selectedProductID = Convert.ToInt16(item.Text);
            }
            EditPopup editPopup = new EditPopup();
            editPopup.SetData(selectedProductID);
            editPopup.ShowDialog();
            UpdateList();
        }

        private List<Product> ChangeOrder(List<Product> products)
        {
            string sortby = OrderSelect.Text;
            switch (sortby)
            {
                case "ID":
                    return products.OrderBy(products => products.Id).ToList();
                case "Name":
                    return products.OrderBy(products => products.Name).ToList();
                case "price acending":
                    return products.OrderBy(products => products.Price).ToList();
                case "price decending":
                    return products.OrderByDescending(products => products.Price).ToList();
                case "Stock acending":
                    return products.OrderBy(products => products.stock).ToList();
                case "stock decending":
                    return products.OrderByDescending(products => products.stock).ToList();
                default:
                    return products.OrderBy(products => products.Id).ToList();

            }
        }

    }
}
