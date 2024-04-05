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
            TsukaButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            listView1 = new ListView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ResetSearchButton = new Button();
            StockLabel = new Label();
            StockMinLabel = new Label();
            StockMaxLabel = new Label();
            PriceLabelMax = new Label();
            PriceLabelMin = new Label();
            PriceLabel = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            QueryDescription = new Label();
            QueryName = new Label();
            textBox6 = new TextBox();
            menuStrip1 = new MenuStrip();
            SortLabel = new Label();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1.SuspendLayout();
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
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(686, 698);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(584, 654);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 43);
            listView1.Name = "listView1";
            listView1.Size = new Size(539, 685);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(686, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(584, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 5;
            // 
            // ResetSearchButton
            // 
            ResetSearchButton.Location = new Point(686, 654);
            ResetSearchButton.Name = "ResetSearchButton";
            ResetSearchButton.Size = new Size(75, 23);
            ResetSearchButton.TabIndex = 6;
            ResetSearchButton.Text = "ResetQuery";
            ResetSearchButton.UseVisualStyleBackColor = true;
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
            PriceLabel.Click += PriceLabel_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(582, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(684, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(584, 103);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 16;
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
            // textBox6
            // 
            textBox6.Location = new Point(584, 43);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            menuStrip1.Location = new Point(407, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(131, 27);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "SortMenu";
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Location = new Point(343, 18);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(44, 15);
            SortLabel.TabIndex = 21;
            SortLabel.Text = "Sort by";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 759);
            Controls.Add(SortLabel);
            Controls.Add(QueryName);
            Controls.Add(textBox6);
            Controls.Add(QueryDescription);
            Controls.Add(textBox5);
            Controls.Add(PriceLabelMax);
            Controls.Add(PriceLabelMin);
            Controls.Add(PriceLabel);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(StockMaxLabel);
            Controls.Add(StockMinLabel);
            Controls.Add(StockLabel);
            Controls.Add(ResetSearchButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(TsukaButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Stock Management System";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TsukaButton;
        private Button DeleteButton;
        private Button SearchButton;
        private ListView listView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ResetSearchButton;
        private Label StockLabel;
        private Label StockMinLabel;
        private Label StockMaxLabel;
        private Label PriceLabelMax;
        private Label PriceLabelMin;
        private Label PriceLabel;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label QueryDescription;
        private Label QueryName;
        private TextBox textBox6;
        private MenuStrip menuStrip1;
        private Label SortLabel;
        private ToolStripComboBox toolStripComboBox1;
    }
}
