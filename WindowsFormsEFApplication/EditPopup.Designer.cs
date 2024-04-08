namespace WindowsFormsEFApplication
{
    partial class EditPopup
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
            EditPopupStockWarning = new Label();
            EditPopupPriceWarning = new Label();
            EditPopUpAddButton = new Button();
            EditPopUpCancelButton = new Button();
            EditDescriptionTextBox = new TextBox();
            EditStockTextBox = new TextBox();
            EditPriceTextBox = new TextBox();
            EditNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // EditPopupStockWarning
            // 
            EditPopupStockWarning.AutoSize = true;
            EditPopupStockWarning.ForeColor = Color.Red;
            EditPopupStockWarning.Location = new Point(136, 147);
            EditPopupStockWarning.Name = "EditPopupStockWarning";
            EditPopupStockWarning.Size = new Size(141, 15);
            EditPopupStockWarning.TabIndex = 23;
            EditPopupStockWarning.Text = "Please enter valid integer!";
            EditPopupStockWarning.Visible = false;
            // 
            // EditPopupPriceWarning
            // 
            EditPopupPriceWarning.AutoSize = true;
            EditPopupPriceWarning.ForeColor = Color.Red;
            EditPopupPriceWarning.Location = new Point(136, 96);
            EditPopupPriceWarning.Name = "EditPopupPriceWarning";
            EditPopupPriceWarning.Size = new Size(141, 15);
            EditPopupPriceWarning.TabIndex = 22;
            EditPopupPriceWarning.Text = "Please enter valid integer!";
            EditPopupPriceWarning.Visible = false;
            // 
            // EditPopUpAddButton
            // 
            EditPopUpAddButton.Location = new Point(142, 234);
            EditPopUpAddButton.Name = "EditPopUpAddButton";
            EditPopUpAddButton.Size = new Size(75, 23);
            EditPopUpAddButton.TabIndex = 21;
            EditPopUpAddButton.Text = "Edit";
            EditPopUpAddButton.UseVisualStyleBackColor = true;
            EditPopUpAddButton.Click += PopUpAddButton_Click;
            // 
            // EditPopUpCancelButton
            // 
            EditPopUpCancelButton.Location = new Point(30, 234);
            EditPopUpCancelButton.Name = "EditPopUpCancelButton";
            EditPopUpCancelButton.Size = new Size(75, 23);
            EditPopUpCancelButton.TabIndex = 20;
            EditPopUpCancelButton.Text = "Cancel";
            EditPopUpCancelButton.UseVisualStyleBackColor = true;
            EditPopUpCancelButton.Click += PopUpCancelButton_Click;
            // 
            // EditDescriptionTextBox
            // 
            EditDescriptionTextBox.Location = new Point(30, 190);
            EditDescriptionTextBox.Name = "EditDescriptionTextBox";
            EditDescriptionTextBox.Size = new Size(100, 23);
            EditDescriptionTextBox.TabIndex = 19;
            // 
            // EditStockTextBox
            // 
            EditStockTextBox.Location = new Point(30, 144);
            EditStockTextBox.Name = "EditStockTextBox";
            EditStockTextBox.Size = new Size(100, 23);
            EditStockTextBox.TabIndex = 18;
            // 
            // EditPriceTextBox
            // 
            EditPriceTextBox.Location = new Point(30, 93);
            EditPriceTextBox.Name = "EditPriceTextBox";
            EditPriceTextBox.Size = new Size(100, 23);
            EditPriceTextBox.TabIndex = 17;
            // 
            // EditNameTextBox
            // 
            EditNameTextBox.Location = new Point(30, 46);
            EditNameTextBox.Name = "EditNameTextBox";
            EditNameTextBox.Size = new Size(100, 23);
            EditNameTextBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 172);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 15;
            label4.Text = "Desciption";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 126);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 13;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // EditPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 292);
            Controls.Add(EditPopupStockWarning);
            Controls.Add(EditPopupPriceWarning);
            Controls.Add(EditPopUpAddButton);
            Controls.Add(EditPopUpCancelButton);
            Controls.Add(EditDescriptionTextBox);
            Controls.Add(EditStockTextBox);
            Controls.Add(EditPriceTextBox);
            Controls.Add(EditNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditPopup";
            Text = "EditPopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditPopupStockWarning;
        private Label EditPopupPriceWarning;
        private Button EditPopUpAddButton;
        private Button EditPopUpCancelButton;
        private TextBox EditDescriptionTextBox;
        private TextBox EditStockTextBox;
        private TextBox EditPriceTextBox;
        private TextBox EditNameTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}