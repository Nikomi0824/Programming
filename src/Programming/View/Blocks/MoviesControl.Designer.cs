namespace Programming.View.Blocks
{
    partial class MoviesControl
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
            FindButton = new Button();
            RatingTextBox = new TextBox();
            YearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            RatingLabel = new Label();
            YearLabel = new Label();
            DurationLable = new Label();
            FilmsListBox = new ListBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(RatingTextBox);
            RectanglesGroupBox.Controls.Add(YearTextBox);
            RectanglesGroupBox.Controls.Add(DurationTextBox);
            RectanglesGroupBox.Controls.Add(RatingLabel);
            RectanglesGroupBox.Controls.Add(YearLabel);
            RectanglesGroupBox.Controls.Add(DurationLable);
            RectanglesGroupBox.Controls.Add(FilmsListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Margin = new Padding(4, 5, 4, 5);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Padding = new Padding(4, 5, 4, 5);
            RectanglesGroupBox.Size = new Size(732, 910);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Movies";
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
            FindButton.Location = new Point(267, 357);
            FindButton.Margin = new Padding(4, 5, 4, 5);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(211, 60);
            FindButton.TabIndex = 8;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = false;
            FindButton.Click += FindButton_Click;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(267, 198);
            RatingTextBox.Margin = new Padding(4, 5, 4, 5);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(213, 31);
            RatingTextBox.TabIndex = 6;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(267, 132);
            YearTextBox.Margin = new Padding(4, 5, 4, 5);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(213, 31);
            YearTextBox.TabIndex = 5;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(265, 66);
            DurationTextBox.Margin = new Padding(4, 5, 4, 5);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(213, 31);
            DurationTextBox.TabIndex = 4;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.ImeMode = ImeMode.On;
            RatingLabel.Location = new Point(265, 168);
            RatingLabel.Margin = new Padding(4, 0, 4, 0);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(67, 25);
            RatingLabel.TabIndex = 3;
            RatingLabel.Text = "Rating:";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.ImeMode = ImeMode.On;
            YearLabel.Location = new Point(265, 102);
            YearLabel.Margin = new Padding(4, 0, 4, 0);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(48, 25);
            YearLabel.TabIndex = 2;
            YearLabel.Text = "Year:";
            // 
            // DurationLable
            // 
            DurationLable.AutoSize = true;
            DurationLable.ImeMode = ImeMode.On;
            DurationLable.Location = new Point(267, 36);
            DurationLable.Margin = new Padding(4, 0, 4, 0);
            DurationLable.Name = "DurationLable";
            DurationLable.Size = new Size(85, 25);
            DurationLable.TabIndex = 1;
            DurationLable.Text = "Duration:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 25;
            FilmsListBox.Items.AddRange(new object[] { "Film 1", "Film 2", "Film 3", "Film 4", "Film 5" });
            FilmsListBox.Location = new Point(17, 38);
            FilmsListBox.Margin = new Padding(4, 5, 4, 5);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(243, 379);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "MoviesControl";
            Size = new Size(732, 910);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Button FindButton;
        private TextBox RatingTextBox;
        private TextBox YearTextBox;
        private TextBox DurationTextBox;
        private Label RatingLabel;
        private Label YearLabel;
        private Label DurationLable;
        private ListBox FilmsListBox;
    }
}
