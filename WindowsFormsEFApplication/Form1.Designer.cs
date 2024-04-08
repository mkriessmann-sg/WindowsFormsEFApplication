namespace WindowsFormsEFApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("One");
            ListViewItem listViewItem2 = new ListViewItem("Two");
            TsukaButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            xName = new ColumnHeader();
            Description = new ColumnHeader();
            Price = new ColumnHeader();
            Stock = new ColumnHeader();
            QueryStockMaxBox = new TextBox();
            QueryStockMinBox = new TextBox();
            ResetSearchButton = new Button();
            StockLabel = new Label();
            StockMinLabel = new Label();
            StockMaxLabel = new Label();
            PriceLabelMax = new Label();
            PriceLabelMin = new Label();
            PriceLabel = new Label();
            QueryPriceMinBox = new TextBox();
            QueryPriceMaxBox = new TextBox();
            QueryDescriptionBox = new TextBox();
            QueryDescription = new Label();
            QueryName = new Label();
            QueryNameBox = new TextBox();
            SortLabel = new Label();
            comboBox1 = new ComboBox();
            WarningLabelPrice = new Label();
            WarningLabelStock = new Label();
            EditButton = new Button();
            SuspendLayout();
            // 
            // TsukaButton
            // 
            TsukaButton.Location = new Point(584, 698);
            TsukaButton.Name = "TsukaButton";
            TsukaButton.Size = new Size(75, 23);
            TsukaButton.TabIndex = 0;
            TsukaButton.Text = "Add";
            TsukaButton.UseVisualStyleBackColor = true;
            TsukaButton.Click += TsukaButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(686, 698);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(584, 654);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Columns.AddRange(new ColumnHeader[] { ID, xName, Description, Price, Stock });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewItem1.Tag = "One";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(12, 43);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(539, 685);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // xName
            // 
            xName.Text = "Name";
            // 
            // Description
            // 
            Description.Text = "Description";
            // 
            // Price
            // 
            Price.Text = "Price";
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            // 
            // QueryStockMaxBox
            // 
            QueryStockMaxBox.Location = new Point(686, 250);
            QueryStockMaxBox.Name = "QueryStockMaxBox";
            QueryStockMaxBox.Size = new Size(75, 23);
            QueryStockMaxBox.TabIndex = 4;
            // 
            // QueryStockMinBox
            // 
            QueryStockMinBox.Location = new Point(584, 250);
            QueryStockMinBox.Name = "QueryStockMinBox";
            QueryStockMinBox.Size = new Size(75, 23);
            QueryStockMinBox.TabIndex = 5;
            // 
            // ResetSearchButton
            // 
            ResetSearchButton.Location = new Point(686, 654);
            ResetSearchButton.Name = "ResetSearchButton";
            ResetSearchButton.Size = new Size(75, 23);
            ResetSearchButton.TabIndex = 6;
            ResetSearchButton.Text = "ResetQuery";
            ResetSearchButton.UseVisualStyleBackColor = true;
            ResetSearchButton.Click += ResetSearchButton_Click;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Location = new Point(650, 215);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(36, 15);
            StockLabel.TabIndex = 7;
            StockLabel.Text = "Stock";
            // 
            // StockMinLabel
            // 
            StockMinLabel.AutoSize = true;
            StockMinLabel.Location = new Point(605, 232);
            StockMinLabel.Name = "StockMinLabel";
            StockMinLabel.Size = new Size(28, 15);
            StockMinLabel.TabIndex = 8;
            StockMinLabel.Text = "Min";
            // 
            // StockMaxLabel
            // 
            StockMaxLabel.AutoSize = true;
            StockMaxLabel.Location = new Point(709, 232);
            StockMaxLabel.Name = "StockMaxLabel";
            StockMaxLabel.Size = new Size(30, 15);
            StockMaxLabel.TabIndex = 9;
            StockMaxLabel.Text = "Max";
            // 
            // PriceLabelMax
            // 
            PriceLabelMax.AutoSize = true;
            PriceLabelMax.Location = new Point(707, 156);
            PriceLabelMax.Name = "PriceLabelMax";
            PriceLabelMax.Size = new Size(30, 15);
            PriceLabelMax.TabIndex = 14;
            PriceLabelMax.Text = "Max";
            // 
            // PriceLabelMin
            // 
            PriceLabelMin.AutoSize = true;
            PriceLabelMin.Location = new Point(603, 156);
            PriceLabelMin.Name = "PriceLabelMin";
            PriceLabelMin.Size = new Size(28, 15);
            PriceLabelMin.TabIndex = 13;
            PriceLabelMin.Text = "Min";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(650, 139);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 12;
            PriceLabel.Text = "Price";
            // 
            // QueryPriceMinBox
            // 
            QueryPriceMinBox.Location = new Point(582, 174);
            QueryPriceMinBox.Name = "QueryPriceMinBox";
            QueryPriceMinBox.Size = new Size(75, 23);
            QueryPriceMinBox.TabIndex = 11;
            // 
            // QueryPriceMaxBox
            // 
            QueryPriceMaxBox.Location = new Point(684, 174);
            QueryPriceMaxBox.Name = "QueryPriceMaxBox";
            QueryPriceMaxBox.Size = new Size(75, 23);
            QueryPriceMaxBox.TabIndex = 10;
            // 
            // QueryDescriptionBox
            // 
            QueryDescriptionBox.Location = new Point(584, 103);
            QueryDescriptionBox.Name = "QueryDescriptionBox";
            QueryDescriptionBox.Size = new Size(177, 23);
            QueryDescriptionBox.TabIndex = 16;
            // 
            // QueryDescription
            // 
            QueryDescription.AutoSize = true;
            QueryDescription.Location = new Point(584, 85);
            QueryDescription.Name = "QueryDescription";
            QueryDescription.Size = new Size(101, 15);
            QueryDescription.TabIndex = 17;
            QueryDescription.Text = "Query description";
            // 
            // QueryName
            // 
            QueryName.AutoSize = true;
            QueryName.Location = new Point(584, 25);
            QueryName.Name = "QueryName";
            QueryName.Size = new Size(73, 15);
            QueryName.TabIndex = 19;
            QueryName.Text = "Query Name";
            // 
            // QueryNameBox
            // 
            QueryNameBox.Location = new Point(584, 43);
            QueryNameBox.Name = "QueryNameBox";
            QueryNameBox.Size = new Size(177, 23);
            QueryNameBox.TabIndex = 18;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Location = new Point(380, 17);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(44, 15);
            SortLabel.TabIndex = 21;
            SortLabel.Text = "Sort by";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stock acending", "stock decending", "price acending", "price decending" });
            comboBox1.Location = new Point(430, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // WarningLabelPrice
            // 
            WarningLabelPrice.AutoSize = true;
            WarningLabelPrice.ForeColor = Color.Red;
            WarningLabelPrice.Location = new Point(603, 200);
            WarningLabelPrice.Name = "WarningLabelPrice";
            WarningLabelPrice.Size = new Size(144, 15);
            WarningLabelPrice.TabIndex = 23;
            WarningLabelPrice.Text = "Please enter only integers!";
            WarningLabelPrice.Visible = false;
            // 
            // WarningLabelStock
            // 
            WarningLabelStock.AutoSize = true;
            WarningLabelStock.ForeColor = Color.Red;
            WarningLabelStock.Location = new Point(605, 276);
            WarningLabelStock.Name = "WarningLabelStock";
            WarningLabelStock.Size = new Size(144, 15);
            WarningLabelStock.TabIndex = 24;
            WarningLabelStock.Text = "Please enter only integers!";
            WarningLabelStock.Visible = false;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(782, 654);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 25;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 759);
            Controls.Add(EditButton);
            Controls.Add(WarningLabelStock);
            Controls.Add(WarningLabelPrice);
            Controls.Add(comboBox1);
            Controls.Add(SortLabel);
            Controls.Add(QueryName);
            Controls.Add(QueryNameBox);
            Controls.Add(QueryDescription);
            Controls.Add(QueryDescriptionBox);
            Controls.Add(PriceLabelMax);
            Controls.Add(PriceLabelMin);
            Controls.Add(PriceLabel);
            Controls.Add(QueryPriceMinBox);
            Controls.Add(QueryPriceMaxBox);
            Controls.Add(StockMaxLabel);
            Controls.Add(StockMinLabel);
            Controls.Add(StockLabel);
            Controls.Add(ResetSearchButton);
            Controls.Add(QueryStockMinBox);
            Controls.Add(QueryStockMaxBox);
            Controls.Add(listView1);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(TsukaButton);
            Name = "Form1";
            Text = "Stock Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TsukaButton;
        private Button DeleteButton;
        private Button SearchButton;
        private ListView listView1;
        private TextBox QueryStockMaxBox;
        private TextBox QueryStockMinBox;
        private Button ResetSearchButton;
        private Label StockLabel;
        private Label StockMinLabel;
        private Label StockMaxLabel;
        private Label PriceLabelMax;
        private Label PriceLabelMin;
        private Label PriceLabel;
        private TextBox QueryPriceMinBox;
        private TextBox QueryPriceMaxBox;
        private TextBox QueryDescriptionBox;
        private Label QueryDescription;
        private Label QueryName;
        private TextBox QueryNameBox;
        private Label SortLabel;
        private ComboBox comboBox1;
        private ColumnHeader xName;
        private ColumnHeader Description;
        private ColumnHeader Price;
        private ColumnHeader Stock;
        private Label WarningLabelPrice;
        private Label WarningLabelStock;
        public ColumnHeader ID;
        private Button EditButton;
    }
}
