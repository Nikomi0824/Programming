namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            tableLayoutPanel2 = new TableLayoutPanel();
            OrderItemsGroupBox = new GroupBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ClearOrderButton = new Button();
            TotalTotalLabel = new Label();
            TotalLabel = new Label();
            OrderItemsListBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedOrderGroupBox = new GroupBox();
            StatusComboBox = new ComboBox();
            DataTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            DataLabel = new Label();
            IdLabel = new Label();
            PriorityOrders = new GroupBox();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            AddressControl = new Controls.AddressControl();
            tableLayoutPanel2.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SelectedOrderGroupBox.SuspendLayout();
            PriorityOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(OrderItemsGroupBox, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(AddressControl, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1365776F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8634224F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 402F));
            tableLayoutPanel2.Size = new Size(955, 980);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Controls.Add(RemoveItemButton);
            OrderItemsGroupBox.Controls.Add(AddItemButton);
            OrderItemsGroupBox.Controls.Add(ClearOrderButton);
            OrderItemsGroupBox.Controls.Add(TotalTotalLabel);
            OrderItemsGroupBox.Controls.Add(TotalLabel);
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Dock = DockStyle.Fill;
            OrderItemsGroupBox.Location = new Point(3, 580);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Size = new Size(949, 397);
            OrderItemsGroupBox.TabIndex = 2;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "Order Items";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(196, 331);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(129, 45);
            RemoveItemButton.TabIndex = 5;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(54, 331);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(129, 45);
            AddItemButton.TabIndex = 4;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Location = new Point(688, 331);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(129, 45);
            ClearOrderButton.TabIndex = 3;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // TotalTotalLabel
            // 
            TotalTotalLabel.AutoSize = true;
            TotalTotalLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalTotalLabel.Location = new Point(694, 290);
            TotalTotalLabel.Name = "TotalTotalLabel";
            TotalTotalLabel.Size = new Size(33, 38);
            TotalTotalLabel.TabIndex = 2;
            TotalTotalLabel.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(694, 262);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(91, 28);
            TotalLabel.TabIndex = 1;
            TotalLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 25;
            OrderItemsListBox.Location = new Point(54, 45);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(731, 204);
            OrderItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.81481F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.18518519F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(949, 278);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SelectedOrderGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(PriorityOrders, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(931, 272);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(DataTextBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(DataLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Dock = DockStyle.Fill;
            SelectedOrderGroupBox.Location = new Point(3, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(459, 266);
            SelectedOrderGroupBox.TabIndex = 1;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(123, 165);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(196, 33);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(123, 107);
            DataTextBox.Name = "DataTextBox";
            DataTextBox.ReadOnly = true;
            DataTextBox.Size = new Size(196, 31);
            DataTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(123, 49);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(196, 31);
            IdTextBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(32, 176);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // DataLabel
            // 
            DataLabel.AutoSize = true;
            DataLabel.Location = new Point(32, 113);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new Size(53, 25);
            DataLabel.TabIndex = 1;
            DataLabel.Text = "Data:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(29, 55);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(34, 25);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // PriorityOrders
            // 
            PriorityOrders.Controls.Add(DeliveryTimeComboBox);
            PriorityOrders.Controls.Add(DeliveryTimeLabel);
            PriorityOrders.Dock = DockStyle.Fill;
            PriorityOrders.Location = new Point(468, 3);
            PriorityOrders.Name = "PriorityOrders";
            PriorityOrders.Size = new Size(460, 266);
            PriorityOrders.TabIndex = 2;
            PriorityOrders.TabStop = false;
            PriorityOrders.Text = " Priority Orders";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(164, 80);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(182, 33);
            DeliveryTimeComboBox.TabIndex = 1;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(36, 83);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(122, 25);
            DeliveryTimeLabel.TabIndex = 0;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // AddressControl
            // 
            AddressControl.Address = null;
            AddressControl.Dock = DockStyle.Fill;
            AddressControl.Location = new Point(3, 287);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(949, 287);
            AddressControl.TabIndex = 4;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "PriorityOrdersTab";
            Size = new Size(955, 980);
            tableLayoutPanel2.ResumeLayout(false);
            OrderItemsGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            PriorityOrders.ResumeLayout(false);
            PriorityOrders.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox OrderItemsGroupBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Button ClearOrderButton;
        private Label TotalTotalLabel;
        private Label TotalLabel;
        private ListBox OrderItemsListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SelectedOrderGroupBox;
        private ComboBox StatusComboBox;
        private TextBox DataTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label DataLabel;
        private Label IdLabel;
        private GroupBox PriorityOrders;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Controls.AddressControl AddressControl;
    }
}
