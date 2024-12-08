namespace ObjectOrientedPractics.View
{
    partial class CartsTab
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
            TotalLabel = new Label();
            panel3 = new Panel();
            TotalTotalLabel = new Label();
            AddToCartButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            TotalDiscountLabel = new Label();
            DiscountAmountLabel = new Label();
            DiscountsСheckedListBox = new CheckedListBox();
            DiscountGroupBox = new GroupBox();
            CartListBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            TotalAmountLabel = new Label();
            CartGroupBox = new GroupBox();
            AmountLabel = new Label();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            ItemsListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsGroupBox = new GroupBox();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            DiscountGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            CartGroupBox.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(440, 3);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(64, 28);
            TotalLabel.TabIndex = 0;
            TotalLabel.Text = "Total:";
            // 
            // panel3
            // 
            panel3.Controls.Add(TotalTotalLabel);
            panel3.Controls.Add(TotalLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(572, 816);
            panel3.Name = "panel3";
            panel3.Size = new Size(563, 96);
            panel3.TabIndex = 3;
            // 
            // TotalTotalLabel
            // 
            TotalTotalLabel.AutoSize = true;
            TotalTotalLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalTotalLabel.Location = new Point(440, 43);
            TotalTotalLabel.Name = "TotalTotalLabel";
            TotalTotalLabel.Size = new Size(33, 38);
            TotalTotalLabel.TabIndex = 1;
            TotalTotalLabel.Text = "0";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(3, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(178, 54);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart ";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(AddToCartButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 816);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(563, 96);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // TotalDiscountLabel
            // 
            TotalDiscountLabel.AutoSize = true;
            TotalDiscountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalDiscountLabel.Location = new Point(430, 58);
            TotalDiscountLabel.Name = "TotalDiscountLabel";
            TotalDiscountLabel.Size = new Size(33, 38);
            TotalDiscountLabel.TabIndex = 2;
            TotalDiscountLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(345, 30);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(183, 28);
            DiscountAmountLabel.TabIndex = 1;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsСheckedListBox
            // 
            DiscountsСheckedListBox.FormattingEnabled = true;
            DiscountsСheckedListBox.Location = new Point(6, 30);
            DiscountsСheckedListBox.Name = "DiscountsСheckedListBox";
            DiscountsСheckedListBox.Size = new Size(313, 284);
            DiscountsСheckedListBox.TabIndex = 0;
            DiscountsСheckedListBox.SelectedIndexChanged += DiscountsСheckedListBox_SelectedIndexChanged;
            // 
            // DiscountGroupBox
            // 
            DiscountGroupBox.Controls.Add(TotalDiscountLabel);
            DiscountGroupBox.Controls.Add(DiscountAmountLabel);
            DiscountGroupBox.Controls.Add(DiscountsСheckedListBox);
            DiscountGroupBox.Dock = DockStyle.Fill;
            DiscountGroupBox.Location = new Point(3, 444);
            DiscountGroupBox.Name = "DiscountGroupBox";
            DiscountGroupBox.Size = new Size(543, 346);
            DiscountGroupBox.TabIndex = 1;
            DiscountGroupBox.TabStop = false;
            DiscountGroupBox.Text = "Discount:";
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 25;
            CartListBox.Location = new Point(6, 30);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(531, 204);
            CartListBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.94402F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.05598F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tableLayoutPanel3.Controls.Add(CreateOrderButton, 0, 0);
            tableLayoutPanel3.Controls.Add(RemoveItemButton, 1, 0);
            tableLayoutPanel3.Controls.Add(ClearCartButton, 2, 0);
            tableLayoutPanel3.Location = new Point(0, 306);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(543, 59);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(3, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(168, 53);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Right;
            RemoveItemButton.Location = new Point(250, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(140, 53);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Dock = DockStyle.Left;
            ClearCartButton.Location = new Point(396, 3);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(140, 53);
            ClearCartButton.TabIndex = 2;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalAmountLabel.Location = new Point(430, 265);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(33, 38);
            TotalAmountLabel.TabIndex = 3;
            TotalAmountLabel.Text = "0";
            // 
            // CartGroupBox
            // 
            CartGroupBox.Controls.Add(TotalAmountLabel);
            CartGroupBox.Controls.Add(AmountLabel);
            CartGroupBox.Controls.Add(tableLayoutPanel3);
            CartGroupBox.Controls.Add(CartListBox);
            CartGroupBox.Dock = DockStyle.Fill;
            CartGroupBox.Location = new Point(3, 68);
            CartGroupBox.Name = "CartGroupBox";
            CartGroupBox.Size = new Size(543, 370);
            CartGroupBox.TabIndex = 0;
            CartGroupBox.TabStop = false;
            CartGroupBox.Text = "Cart:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(430, 237);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(93, 28);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "Amount:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(6, 10);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(93, 25);
            CustomerLabel.TabIndex = 1;
            CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(101, 10);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(435, 33);
            CustomerComboBox.TabIndex = 2;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(CustomerLabel);
            panel2.Controls.Add(CustomerComboBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 59);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 0);
            tableLayoutPanel4.Controls.Add(CartGroupBox, 0, 1);
            tableLayoutPanel4.Controls.Add(DiscountGroupBox, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.772727F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 85.22727F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 351F));
            tableLayoutPanel4.Size = new Size(549, 793);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(579, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 793);
            panel1.TabIndex = 1;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(10, 34);
            ItemsListBox.Margin = new Padding(20);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(543, 763);
            ItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ItemsGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.95089F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0491076F));
            tableLayoutPanel1.Size = new Size(1138, 915);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(10);
            ItemsGroupBox.Size = new Size(563, 807);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(1138, 915);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            DiscountGroupBox.ResumeLayout(false);
            DiscountGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            CartGroupBox.ResumeLayout(false);
            CartGroupBox.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TotalLabel;
        private Panel panel3;
        private Label TotalTotalLabel;
        private Button AddToCartButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label TotalDiscountLabel;
        private Label DiscountAmountLabel;
        private CheckedListBox DiscountsСheckedListBox;
        private GroupBox DiscountGroupBox;
        private ListBox CartListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CreateOrderButton;
        private Button RemoveItemButton;
        private Button ClearCartButton;
        private Label TotalAmountLabel;
        private GroupBox CartGroupBox;
        private Label AmountLabel;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ItemsGroupBox;
    }
}
