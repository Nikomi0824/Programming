namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Model.Orders.PriorityOrder priorityOrder1 = new Model.Orders.PriorityOrder();
            Model.Address address1 = new Model.Address();
            TabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            CartsTabPage = new TabPage();
            CartsTab = new View.CartsTab();
            OrdersTabPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            PriorityOrdersTabPage = new TabPage();
            TabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            PriorityOrdersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Controls.Add(CartsTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Controls.Add(PriorityOrdersTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1382, 1093);
            TabControl.TabIndex = 0;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 34);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1374, 1055);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(1368, 1049);
            ItemsTab.TabIndex = 0;
            ItemsTab.Load += ItemsTab_Load;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 34);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(1374, 1055);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Customers = null;
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(1368, 1049);
            CustomersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartsTab);
            CartsTabPage.Location = new Point(4, 34);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(1374, 1055);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "CartsTab";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1368, 1049);
            CartsTab.TabIndex = 1;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab);
            OrdersTabPage.Location = new Point(4, 34);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(1374, 1055);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "OrdersTab";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1368, 1049);
            OrdersTab.TabIndex = 0;
            // 
            // PriorityOrdersTabPage
            // 
            PriorityOrdersTabPage.Location = new Point(4, 34);
            PriorityOrdersTabPage.Name = "PriorityOrdersTabPage";
            PriorityOrdersTabPage.Padding = new Padding(3);
            PriorityOrdersTabPage.Size = new Size(1374, 1055);
            PriorityOrdersTabPage.TabIndex = 4;
            PriorityOrdersTabPage.Text = "PriorityOrders";
            PriorityOrdersTabPage.UseVisualStyleBackColor = true;

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 1093);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1404, 1149);
            Name = "MainForm";
            Text = "ObjectOrientedPractics";
            TabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            PriorityOrdersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage CartsTabPage;
        private View.Tabs.OrdersTab userControl11;
        private TabPage OrdersTabPage;
        private TabPage PriorityOrdersTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.CartsTab CartsTab;
        private View.Tabs.OrdersTab OrdersTab;
    }
}
