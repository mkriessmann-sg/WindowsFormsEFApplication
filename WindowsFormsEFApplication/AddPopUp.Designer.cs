namespace WindowsFormsEFApplication
{
    partial class AddPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddNameTextBox = new TextBox();
            AddPriceTextBox = new TextBox();
            AddStockTextBox = new TextBox();
            AddDescriptionTextBox = new TextBox();
            PopUpCancelButton = new Button();
            PopUpAddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 116);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 167);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 213);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Desciption";
            // 
            // AddNameTextBox
            // 
            AddNameTextBox.Location = new Point(59, 87);
            AddNameTextBox.Name = "AddNameTextBox";
            AddNameTextBox.Size = new Size(100, 23);
            AddNameTextBox.TabIndex = 4;
            // 
            // AddPriceTextBox
            // 
            AddPriceTextBox.Location = new Point(59, 134);
            AddPriceTextBox.Name = "AddPriceTextBox";
            AddPriceTextBox.Size = new Size(100, 23);
            AddPriceTextBox.TabIndex = 5;
            // 
            // AddStockTextBox
            // 
            AddStockTextBox.Location = new Point(59, 185);
            AddStockTextBox.Name = "AddStockTextBox";
            AddStockTextBox.Size = new Size(100, 23);
            AddStockTextBox.TabIndex = 6;
            // 
            // AddDescriptionTextBox
            // 
            AddDescriptionTextBox.Location = new Point(59, 231);
            AddDescriptionTextBox.Name = "AddDescriptionTextBox";
            AddDescriptionTextBox.Size = new Size(100, 23);
            AddDescriptionTextBox.TabIndex = 7;
            // 
            // PopUpCancelButton
            // 
            PopUpCancelButton.Location = new Point(59, 275);
            PopUpCancelButton.Name = "PopUpCancelButton";
            PopUpCancelButton.Size = new Size(75, 23);
            PopUpCancelButton.TabIndex = 8;
            PopUpCancelButton.Text = "Cancel";
            PopUpCancelButton.UseVisualStyleBackColor = true;
            PopUpCancelButton.Click += PopUpButton_Click;
            // 
            // PopUpAddButton
            // 
            PopUpAddButton.Location = new Point(171, 275);
            PopUpAddButton.Name = "PopUpAddButton";
            PopUpAddButton.Size = new Size(75, 23);
            PopUpAddButton.TabIndex = 9;
            PopUpAddButton.Text = "Add";
            PopUpAddButton.UseVisualStyleBackColor = true;
            PopUpAddButton.Click += PopUpAddButton_Click;
            // 
            // AddPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 359);
            Controls.Add(PopUpAddButton);
            Controls.Add(PopUpCancelButton);
            Controls.Add(AddDescriptionTextBox);
            Controls.Add(AddStockTextBox);
            Controls.Add(AddPriceTextBox);
            Controls.Add(AddNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPopUp";
            Text = "AddPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AddNameTextBox;
        private TextBox AddPriceTextBox;
        private TextBox AddStockTextBox;
        private TextBox AddDescriptionTextBox;
        private Button PopUpCancelButton;
        private Button PopUpAddButton;
    }
}