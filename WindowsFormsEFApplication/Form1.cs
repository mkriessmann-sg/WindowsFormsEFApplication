namespace WindowsFormsEFApplication
{
    public partial class Form1 : Form
    {

        //0stock larger, 1stock smaller, 2price larger, 3price smaller
        int orderIndex;
        List<Product> currentProducts;
        public QueryObject query = new QueryObject();



        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Name");
            listView1.Columns.Add("Price");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateList();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderIndex = comboBox1.SelectedIndex;
        }




        public void UpdateList()
        {
            DatabaseHandler databaseHandler = new DatabaseHandler();
            currentProducts = databaseHandler.GetProducts(query);
            listView1.Clear();
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
            Update();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            query.nameQuery = QueryNameBox.Text;
            query.descriptionQuery= QueryDescriptionBox.Text;
            query.maxPrice = Convert.ToInt32(QueryPriceMaxBox.Text);
            query.minPrice= Convert.ToInt32(QueryPriceMinBox.Text);
            query.minStock =Convert.ToInt32(QueryStockMinBox.Text);
            query.maxStock = Convert.ToInt32(QueryStockMaxBox.Text);
            UpdateList();
        }
    }
}
