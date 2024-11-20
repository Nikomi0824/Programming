namespace Programming.View.Blocks
{
    partial class ReactanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactanglesCollisionControl));
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            RemoveRectanglePictureBox = new PictureBox();
            AddRectanglePictureBox = new PictureBox();
            ReactanglesListBoxListBox2 = new ListBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            HeightTextBox2 = new TextBox();
            WidthTextBox2 = new TextBox();
            YTextBox2 = new TextBox();
            XTextBox2 = new TextBox();
            IdTextBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CanvasPanel = new Panel();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectanglePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddRectanglePictureBox).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2646637F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.73534F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(CanvasPanel, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1182, 911);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(15);
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50.2937737F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 49.7062263F));
            tableLayoutPanel5.Size = new Size(410, 905);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RemoveRectanglePictureBox);
            groupBox1.Controls.Add(AddRectanglePictureBox);
            groupBox1.Controls.Add(ReactanglesListBoxListBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(18, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(374, 434);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rectangles:";
            // 
            // RemoveRectanglePictureBox
            // 
            RemoveRectanglePictureBox.Image = (Image)resources.GetObject("RemoveRectanglePictureBox.Image");
            RemoveRectanglePictureBox.ImeMode = ImeMode.On;
            RemoveRectanglePictureBox.Location = new Point(253, 336);
            RemoveRectanglePictureBox.Name = "RemoveRectanglePictureBox";
            RemoveRectanglePictureBox.Size = new Size(24, 24);
            RemoveRectanglePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            RemoveRectanglePictureBox.TabIndex = 4;
            RemoveRectanglePictureBox.TabStop = false;
            RemoveRectanglePictureBox.Click += RemoveRectanglePictureBox_Click;
            // 
            // AddRectanglePictureBox
            // 
            AddRectanglePictureBox.Image = (Image)resources.GetObject("AddRectanglePictureBox.Image");
            AddRectanglePictureBox.ImeMode = ImeMode.NoControl;
            AddRectanglePictureBox.Location = new Point(93, 336);
            AddRectanglePictureBox.Name = "AddRectanglePictureBox";
            AddRectanglePictureBox.Size = new Size(24, 24);
            AddRectanglePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            AddRectanglePictureBox.TabIndex = 3;
            AddRectanglePictureBox.TabStop = false;
            AddRectanglePictureBox.Click += AddRectanglePictureBox_Click_1;
            // 
            // ReactanglesListBoxListBox2
            // 
            ReactanglesListBoxListBox2.Dock = DockStyle.Top;
            ReactanglesListBoxListBox2.FormattingEnabled = true;
            ReactanglesListBoxListBox2.ItemHeight = 25;
            ReactanglesListBoxListBox2.Location = new Point(15, 39);
            ReactanglesListBoxListBox2.Margin = new Padding(15);
            ReactanglesListBoxListBox2.Name = "ReactanglesListBoxListBox2";
            ReactanglesListBoxListBox2.Size = new Size(344, 254);
            ReactanglesListBoxListBox2.TabIndex = 0;
            ReactanglesListBoxListBox2.SelectedIndexChanged += ReactanglesListBoxListBox2_SelectedIndexChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(HeightTextBox2);
            groupBox2.Controls.Add(WidthTextBox2);
            groupBox2.Controls.Add(YTextBox2);
            groupBox2.Controls.Add(XTextBox2);
            groupBox2.Controls.Add(IdTextBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(18, 458);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 429);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Rectangle:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.On;
            label1.Location = new Point(11, 224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 22;
            label1.Text = "Hight:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.On;
            label2.Location = new Point(7, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 21;
            label2.Text = "Width:";
            // 
            // HeightTextBox2
            // 
            HeightTextBox2.Location = new Point(93, 218);
            HeightTextBox2.Margin = new Padding(4, 5, 4, 5);
            HeightTextBox2.Name = "HeightTextBox2";
            HeightTextBox2.Size = new Size(213, 31);
            HeightTextBox2.TabIndex = 20;
            HeightTextBox2.TextChanged += HeightTextBox2_TextChanged_1;
            // 
            // WidthTextBox2
            // 
            WidthTextBox2.Location = new Point(93, 177);
            WidthTextBox2.Margin = new Padding(4, 5, 4, 5);
            WidthTextBox2.Name = "WidthTextBox2";
            WidthTextBox2.Size = new Size(213, 31);
            WidthTextBox2.TabIndex = 19;
            WidthTextBox2.TextChanged += WidthTextBox2_TextChanged;
            // 
            // YTextBox2
            // 
            YTextBox2.Location = new Point(93, 136);
            YTextBox2.Margin = new Padding(4, 5, 4, 5);
            YTextBox2.Name = "YTextBox2";
            YTextBox2.Size = new Size(213, 31);
            YTextBox2.TabIndex = 18;
            YTextBox2.TextChanged += YTextBox2_TextChanged_1;
            // 
            // XTextBox2
            // 
            XTextBox2.Location = new Point(93, 95);
            XTextBox2.Margin = new Padding(4, 5, 4, 5);
            XTextBox2.Name = "XTextBox2";
            XTextBox2.Size = new Size(213, 31);
            XTextBox2.TabIndex = 17;
            XTextBox2.TextChanged += XTextBox2_TextChanged_1;
            // 
            // IdTextBox2
            // 
            IdTextBox2.Location = new Point(93, 54);
            IdTextBox2.Margin = new Padding(4, 5, 4, 5);
            IdTextBox2.Name = "IdTextBox2";
            IdTextBox2.Size = new Size(213, 31);
            IdTextBox2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.On;
            label3.Location = new Point(45, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 15;
            label3.Text = "Y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.On;
            label4.Location = new Point(44, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 14;
            label4.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.On;
            label5.Location = new Point(39, 57);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 25);
            label5.TabIndex = 13;
            label5.Text = "Id:";
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Dock = DockStyle.Fill;
            CanvasPanel.Location = new Point(431, 15);
            CanvasPanel.Margin = new Padding(15);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(736, 881);
            CanvasPanel.TabIndex = 1;
            // 
            // ReactanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel4);
            Name = "ReactanglesCollisionControl";
            Size = new Size(1182, 911);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectanglePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddRectanglePictureBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox1;
        private PictureBox RemoveRectanglePictureBox;
        private PictureBox AddRectanglePictureBox;
        private ListBox ReactanglesListBoxListBox2;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private TextBox HeightTextBox2;
        private TextBox WidthTextBox2;
        private TextBox YTextBox2;
        private TextBox XTextBox2;
        private TextBox IdTextBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel CanvasPanel;
    }
}
