namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiscountForm));
            PercentDiscountGroupBox = new GroupBox();
            CancelButton = new Button();
            AddButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            PercentDiscountGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PercentDiscountGroupBox
            // 
            PercentDiscountGroupBox.Controls.Add(CancelButton);
            PercentDiscountGroupBox.Controls.Add(AddButton);
            PercentDiscountGroupBox.Controls.Add(CategoryComboBox);
            PercentDiscountGroupBox.Controls.Add(CategoryLabel);
            PercentDiscountGroupBox.Dock = DockStyle.Fill;
            PercentDiscountGroupBox.Location = new Point(20, 20);
            PercentDiscountGroupBox.Margin = new Padding(20);
            PercentDiscountGroupBox.Name = "PercentDiscountGroupBox";
            PercentDiscountGroupBox.Size = new Size(526, 257);
            PercentDiscountGroupBox.TabIndex = 0;
            PercentDiscountGroupBox.TabStop = false;
            PercentDiscountGroupBox.Text = "PercentDiscount:";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(344, 159);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(154, 67);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(138, 159);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(162, 67);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(138, 66);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(360, 33);
            CategoryComboBox.TabIndex = 1;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(44, 69);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(88, 25);
            CategoryLabel.TabIndex = 0;
            CategoryLabel.Text = "Category:";
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 297);
            Controls.Add(PercentDiscountGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(588, 353);
            MinimumSize = new Size(588, 353);
            Name = "AddDiscountForm";
            Padding = new Padding(20);
            Text = "Add Discount";
            PercentDiscountGroupBox.ResumeLayout(false);
            PercentDiscountGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox PercentDiscountGroupBox;
        private Button CancelButton;
        private Button AddButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
    }
}