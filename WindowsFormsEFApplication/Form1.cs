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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHandler databaseHandler = new DatabaseHandler();
            currentProducts = databaseHandler.GetProducts(query);
            UpdateList();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderIndex = comboBox1.SelectedIndex;


        }




        public void UpdateList()
        {
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

        }
    }
}
