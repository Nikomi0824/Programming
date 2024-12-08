namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            OrdersGroupBox = new GroupBox();
            OrdersDataGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            OrderItemsGroupBox = new GroupBox();
            TotalTotalLabel = new Label();
            TotalLabel = new Label();
            OrderItemsListBox = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            SelectedOrderGroupBox = new GroupBox();
            StatusComboBox = new ComboBox();
            DataTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            DataLabel = new Label();
            IdLabel = new Label();
            AddressControl = new Controls.AddressControl();
            tableLayoutPanel1.SuspendLayout();
            OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SelectedOrderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.03169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.96831F));
            tableLayoutPanel1.Controls.Add(OrdersGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.43974F));
            tableLayoutPanel1.Size = new Size(1346, 1046);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // OrdersGroupBox
            // 
            OrdersGroupBox.Controls.Add(OrdersDataGridView);
            OrdersGroupBox.Dock = DockStyle.Fill;
            OrdersGroupBox.Location = new Point(0, 0);
            OrdersGroupBox.Margin = new Padding(0);
            OrdersGroupBox.Name = "OrdersGroupBox";
            OrdersGroupBox.Padding = new Padding(10);
            OrdersGroupBox.Size = new Size(659, 1046);
            OrdersGroupBox.TabIndex = 0;
            OrdersGroupBox.TabStop = false;
            OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AccessibleRole = AccessibleRole.Grip;
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(10, 34);
            OrdersDataGridView.Margin = new Padding(20);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 62;
            OrdersDataGridView.Size = new Size(639, 1002);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.CellContentClick += OrdersDataGridView_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(OrderItemsGroupBox, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(AddressControl, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(662, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1365776F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8634224F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 402F));
            tableLayoutPanel2.Size = new Size(681, 1040);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Controls.Add(TotalTotalLabel);
            OrderItemsGroupBox.Controls.Add(TotalLabel);
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Dock = DockStyle.Fill;
            OrderItemsGroupBox.Location = new Point(3, 640);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Size = new Size(675, 397);
            OrderItemsGroupBox.TabIndex = 2;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "Order Items";
            // 
            // TotalTotalLabel
            // 
            TotalTotalLabel.AutoSize = true;
            TotalTotalLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalTotalLabel.Location = new Point(556, 301);
            TotalTotalLabel.Name = "TotalTotalLabel";
            TotalTotalLabel.Size = new Size(33, 38);
            TotalTotalLabel.TabIndex = 2;
            TotalTotalLabel.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(556, 263);
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
            OrderItemsListBox.Size = new Size(593, 204);
            OrderItemsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.81481F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.18518519F));
            tableLayoutPanel3.Controls.Add(SelectedOrderGroupBox, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(675, 307);
            tableLayoutPanel3.TabIndex = 3;
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
            SelectedOrderGroupBox.Size = new Size(661, 301);
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
            DataTextBox.Size = new Size(196, 31);
            DataTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(123, 49);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(196, 31);
            IdTextBox.TabIndex = 3;
            IdTextBox.ReadOnly = true;
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
            // AddressControl
            // 
            AddressControl.Address = null;
            AddressControl.Dock = DockStyle.Fill;
            AddressControl.Location = new Point(3, 316);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(675, 318);
            AddressControl.TabIndex = 4;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(1346, 1046);
            tableLayoutPanel1.ResumeLayout(false);
            OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            OrderItemsGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox OrdersGroupBox;
        private DataGridView OrdersDataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Controls.AddressControl addressContro1;
        private GroupBox SelectedOrderGroupBox;
        private GroupBox OrderItemsGroupBox;
        private ComboBox StatusComboBox;
        private TextBox DataTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label DataLabel;
        private Label IdLabel;
        private Label TotalTotalLabel;
        private Label TotalLabel;
        private ListBox OrderItemsListBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Controls.AddressControl AddressControl;
    }
}
