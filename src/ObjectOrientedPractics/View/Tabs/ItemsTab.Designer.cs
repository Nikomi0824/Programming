namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            SelectedItemsGroupBox = new GroupBox();
            FindTextBox = new TextBox();
            FindLabel = new Label();
            OrderByComboBox = new ComboBox();
            OrderByLabel = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            IDLabel = new Label();
            ItemsTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemsGroupBox.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedItemsGroupBox
            // 
            SelectedItemsGroupBox.Controls.Add(FindTextBox);
            SelectedItemsGroupBox.Controls.Add(FindLabel);
            SelectedItemsGroupBox.Controls.Add(OrderByComboBox);
            SelectedItemsGroupBox.Controls.Add(OrderByLabel);
            SelectedItemsGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemsGroupBox.Controls.Add(CategoryLabel);
            SelectedItemsGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemsGroupBox.Controls.Add(NameTextBox);
            SelectedItemsGroupBox.Controls.Add(CostTextBox);
            SelectedItemsGroupBox.Controls.Add(IDTextBox);
            SelectedItemsGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemsGroupBox.Controls.Add(NameLabel);
            SelectedItemsGroupBox.Controls.Add(CostLabel);
            SelectedItemsGroupBox.Controls.Add(IDLabel);
            SelectedItemsGroupBox.Dock = DockStyle.Fill;
            SelectedItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SelectedItemsGroupBox.Location = new Point(485, 3);
            SelectedItemsGroupBox.Name = "SelectedItemsGroupBox";
            SelectedItemsGroupBox.Size = new Size(476, 703);
            SelectedItemsGroupBox.TabIndex = 4;
            SelectedItemsGroupBox.TabStop = false;
            SelectedItemsGroupBox.Text = "Selected Items";
            // 
            // FindTextBox
            // 
            FindTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindTextBox.Location = new Point(118, 242);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(227, 31);
            FindTextBox.TabIndex = 13;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindLabel.Location = new Point(26, 242);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(50, 25);
            FindLabel.TabIndex = 12;
            FindLabel.Text = "Find:";
            // 
            // OrderByComboBox
            // 
            OrderByComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByComboBox.FormattingEnabled = true;
            OrderByComboBox.Location = new Point(118, 191);
            OrderByComboBox.Name = "OrderByComboBox";
            OrderByComboBox.Size = new Size(227, 33);
            OrderByComboBox.TabIndex = 11;
            OrderByComboBox.SelectedIndexChanged += OrderByComboBox_SelectedIndexChanged_1;
            // 
            // OrderByLabel
            // 
            OrderByLabel.AutoSize = true;
            OrderByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByLabel.Location = new Point(25, 194);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(87, 25);
            OrderByLabel.TabIndex = 10;
            OrderByLabel.Text = "Order by:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(118, 144);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(227, 33);
            CategoryComboBox.TabIndex = 9;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CategoryLabel.Location = new Point(24, 147);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(88, 25);
            CategoryLabel.TabIndex = 8;
            CategoryLabel.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionTextBox.Location = new Point(24, 493);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(429, 163);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged_1;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(24, 319);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(429, 118);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CostTextBox.Location = new Point(118, 98);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(227, 31);
            CostTextBox.TabIndex = 5;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDTextBox.Location = new Point(118, 55);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(227, 31);
            IDTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionLabel.Location = new Point(24, 452);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(106, 25);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(24, 279);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 25);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CostLabel.Location = new Point(24, 98);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(52, 25);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
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
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 2;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ItemsTableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(ItemsListBox, 0, 0);
            ItemsTableLayoutPanel.Controls.Add(SelectedItemsGroupBox, 1, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(0, 0);
            ItemsTableLayoutPanel.Margin = new Padding(5);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 2;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            ItemsTableLayoutPanel.Size = new Size(964, 798);
            ItemsTableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.61111F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.38889F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 712);
            tableLayoutPanel1.Margin = new Padding(10, 3, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(469, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(157, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(149, 59);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click_1;
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
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(15, 15);
            ItemsListBox.Margin = new Padding(15);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(452, 679);
            ItemsListBox.TabIndex = 3;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsTableLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(964, 798);
            SelectedItemsGroupBox.ResumeLayout(false);
            SelectedItemsGroupBox.PerformLayout();
            ItemsTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectedItemsGroupBox;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private Label IDLabel;
        private TableLayoutPanel ItemsTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private TextBox FindTextBox;
        private Label FindLabel;
        private ComboBox OrderByComboBox;
        private Label OrderByLabel;
    }
}
