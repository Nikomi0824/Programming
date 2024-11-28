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
            ItemsTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            tabPage2 = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            ItemsTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsTabControl
            // 
            ItemsTabControl.Controls.Add(ItemsTabPage);
            ItemsTabControl.Controls.Add(tabPage2);
            ItemsTabControl.Dock = DockStyle.Fill;
            ItemsTabControl.Location = new Point(0, 0);
            ItemsTabControl.Name = "ItemsTabControl";
            ItemsTabControl.SelectedIndex = 0;
            ItemsTabControl.Size = new Size(1122, 811);
            ItemsTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 34);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(1114, 773);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1114, 773);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1108, 767);
            itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 811);
            Controls.Add(ItemsTabControl);
            MinimumSize = new Size(1144, 867);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ItemsTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ItemsTabControl;
        private TabPage ItemsTabPage;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab1;
    }
}
