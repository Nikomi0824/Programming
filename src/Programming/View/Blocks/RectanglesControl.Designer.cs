namespace Programming.View.Blocks
{
    partial class RectanglesControl
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
            RectanglesGroupBox = new GroupBox();
            IdTextBoxlable = new Label();
            IdTextBox = new TextBox();
            CenterY = new Label();
            CenterX = new Label();
            CenterYTextBox = new TextBox();
            CenterXTextBox = new TextBox();
            FindButton = new Button();
            ColorsTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            ColorsLabel = new Label();
            WidthLabel = new Label();
            HeigthLabel = new Label();
            RectanglesListBox = new ListBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(IdTextBoxlable);
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(CenterY);
            RectanglesGroupBox.Controls.Add(CenterX);
            RectanglesGroupBox.Controls.Add(CenterYTextBox);
            RectanglesGroupBox.Controls.Add(CenterXTextBox);
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(ColorsTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(HeightTextBox);
            RectanglesGroupBox.Controls.Add(ColorsLabel);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(HeigthLabel);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Margin = new Padding(4, 5, 4, 5);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Padding = new Padding(4, 5, 4, 5);
            RectanglesGroupBox.Size = new Size(1209, 987);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBoxlable
            // 
            IdTextBoxlable.AutoSize = true;
            IdTextBoxlable.ImeMode = ImeMode.On;
            IdTextBoxlable.Location = new Point(267, 366);
            IdTextBoxlable.Margin = new Padding(4, 0, 4, 0);
            IdTextBoxlable.Name = "IdTextBoxlable";
            IdTextBoxlable.Size = new Size(108, 25);
            IdTextBoxlable.TabIndex = 14;
            IdTextBoxlable.Text = "IdRectangle:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(267, 396);
            IdTextBox.Margin = new Padding(4, 5, 4, 5);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(213, 31);
            IdTextBox.TabIndex = 13;
            // 
            // CenterY
            // 
            CenterY.AutoSize = true;
            CenterY.ImeMode = ImeMode.On;
            CenterY.Location = new Point(269, 300);
            CenterY.Margin = new Padding(4, 0, 4, 0);
            CenterY.Name = "CenterY";
            CenterY.Size = new Size(77, 25);
            CenterY.TabIndex = 12;
            CenterY.Text = "CenterY:";
            // 
            // CenterX
            // 
            CenterX.AutoSize = true;
            CenterX.ImeMode = ImeMode.On;
            CenterX.Location = new Point(269, 234);
            CenterX.Margin = new Padding(4, 0, 4, 0);
            CenterX.Name = "CenterX";
            CenterX.Size = new Size(78, 25);
            CenterX.TabIndex = 11;
            CenterX.Text = "CenterX:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(267, 330);
            CenterYTextBox.Margin = new Padding(4, 5, 4, 5);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.Size = new Size(213, 31);
            CenterYTextBox.TabIndex = 10;
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(268, 264);
            CenterXTextBox.Margin = new Padding(4, 5, 4, 5);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.Size = new Size(213, 31);
            CenterXTextBox.TabIndex = 9;
            // 
            // FindButton
            // 
            FindButton.BackColor = Color.Silver;
            FindButton.Cursor = Cursors.Hand;
            FindButton.FlatAppearance.BorderColor = Color.Gray;
            FindButton.FlatAppearance.BorderSize = 2;
            FindButton.FlatAppearance.MouseDownBackColor = Color.White;
            FindButton.FlatAppearance.MouseOverBackColor = Color.White;
            FindButton.FlatStyle = FlatStyle.Flat;
            FindButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FindButton.ImeMode = ImeMode.On;
            FindButton.Location = new Point(270, 456);
            FindButton.Margin = new Padding(4, 5, 4, 5);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(213, 61);
            FindButton.TabIndex = 8;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // ColorsTextBox
            // 
            ColorsTextBox.Location = new Point(267, 198);
            ColorsTextBox.Margin = new Padding(4, 5, 4, 5);
            ColorsTextBox.Name = "ColorsTextBox";
            ColorsTextBox.Size = new Size(213, 31);
            ColorsTextBox.TabIndex = 6;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(267, 132);
            WidthTextBox.Margin = new Padding(4, 5, 4, 5);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(213, 31);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(267, 66);
            HeightTextBox.Margin = new Padding(4, 5, 4, 5);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(213, 31);
            HeightTextBox.TabIndex = 4;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // ColorsLabel
            // 
            ColorsLabel.AutoSize = true;
            ColorsLabel.ImeMode = ImeMode.On;
            ColorsLabel.Location = new Point(267, 168);
            ColorsLabel.Margin = new Padding(4, 0, 4, 0);
            ColorsLabel.Name = "ColorsLabel";
            ColorsLabel.Size = new Size(67, 25);
            ColorsLabel.TabIndex = 3;
            ColorsLabel.Text = "Colors:";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.ImeMode = ImeMode.On;
            WidthLabel.Location = new Point(270, 102);
            WidthLabel.Margin = new Padding(4, 0, 4, 0);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(64, 25);
            WidthLabel.TabIndex = 2;
            WidthLabel.Text = "Width:";
            // 
            // HeigthLabel
            // 
            HeigthLabel.AutoSize = true;
            HeigthLabel.ImeMode = ImeMode.On;
            HeigthLabel.Location = new Point(267, 36);
            HeigthLabel.Margin = new Padding(4, 0, 4, 0);
            HeigthLabel.Name = "HeigthLabel";
            HeigthLabel.Size = new Size(69, 25);
            HeigthLabel.TabIndex = 1;
            HeigthLabel.Text = "Heigth:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 25;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(17, 38);
            RectanglesListBox.Margin = new Padding(4, 5, 4, 5);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(243, 479);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesControl";
            Size = new Size(1209, 987);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label IdTextBoxlable;
        private TextBox IdTextBox;
        private Label CenterY;
        private Label CenterX;
        private TextBox CenterYTextBox;
        private TextBox CenterXTextBox;
        private Button FindButton;
        private TextBox ColorsTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Label ColorsLabel;
        private Label WidthLabel;
        private Label HeigthLabel;
        private ListBox RectanglesListBox;
    }
}
