﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AddButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            RemoveButton = new Button();
            ItemsTableLayoutPanel = new TableLayoutPanel();
            CustomersListBox = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            SelectedCustomerGroupBox = new GroupBox();
            IsPriorityCheckBox = new CheckBox();
            FullNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            FullNameLabel = new Label();
            IDLabel = new Label();
            DiscountGroupBox = new GroupBox();
            RemoveDiscountButton = new Button();
            AddDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            AddressControl = new Controls.AddressControl();
            tableLayoutPanel1.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            DiscountGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 59);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.61111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.38889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 892);
            tableLayoutPanel1.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(538, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(191, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(149, 59);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 2;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.7795029F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.2204971F));
            ItemsTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(CustomersListBox, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(tableLayoutPanel2, 1, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Margin = new Padding(5);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 2;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90.25522F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.74478F));
            ItemsTableLayoutPanel.Size = new Size(1288, 986);
            ItemsTableLayoutPanel.TabIndex = 2;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 25;
            CustomersListBox.Location = new Point(15, 15);
            CustomersListBox.Margin = new Padding(15);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(521, 854);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(SelectedCustomerGroupBox, 0, 0);
            tableLayoutPanel2.Controls.Add(DiscountGroupBox, 0, 2);
            tableLayoutPanel2.Controls.Add(AddressControl, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(554, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.6504059F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.3495941F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 254F));
            tableLayoutPanel2.Size = new Size(731, 883);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IDTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Dock = DockStyle.Fill;
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(3, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(725, 249);
            SelectedCustomerGroupBox.TabIndex = 5;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IsPriorityCheckBox.Location = new Point(118, 151);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(112, 29);
            IsPriorityCheckBox.TabIndex = 9;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameTextBox.Location = new Point(118, 98);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(399, 31);
            FullNameTextBox.TabIndex = 5;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDTextBox.Location = new Point(118, 55);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(227, 31);
            IDTextBox.TabIndex = 4;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(24, 98);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(95, 25);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDLabel.Location = new Point(24, 58);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(34, 25);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(RemoveDiscountButton);
            DiscountGroupBox.Controls.Add(AddDiscountButton);
            DiscountGroupBox.Controls.Add(DiscountsListBox);
            DiscountGroupBox.Dock = DockStyle.Fill;
            DiscountGroupBox.Location = new Point(3, 631);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(725, 249);
            DiscountGroupBox.TabIndex = 6;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discounts:";
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Location = new Point(365, 105);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(141, 69);
            RemoveDiscountButton.TabIndex = 2;
            RemoveDiscountButton.Text = "Remove ";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(365, 30);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(141, 69);
            AddDiscountButton.TabIndex = 1;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 25;
            DiscountsListBox.Location = new Point(24, 30);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(335, 179);
            DiscountsListBox.TabIndex = 0;
            // 
            // AddressControl
            // 
            AddressControl.Address = null;
            AddressControl.Dock = DockStyle.Fill;
            AddressControl.Location = new Point(3, 258);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(725, 367);
            AddressControl.TabIndex = 7;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(1288, 986);
            tableLayoutPanel1.ResumeLayout(false);
            ItemsTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            DiscountGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button RemoveButton;
        private TextBox FindTextBox;
        private Label FindLabel;
        private ComboBox OrderByComboBox;
        private Label OrderByLabel;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox DescriptionTextBox;
        private TableLayoutPanel ItemsTableLayoutPanel;
        private ListBox CustomersListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox SelectedCustomerGroupBox;
        private CheckBox IsPriorityCheckBox;
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
        private Label FullNameLabel;
        private Label IDLabel;
        private GroupBox DiscountGroupBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
        private ListBox DiscountsListBox;
        private Controls.AddressControl AddressControl;
    }
}
