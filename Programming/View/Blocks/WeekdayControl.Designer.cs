namespace Programming.View.Blocks
{
    partial class WeekdayControl
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
            WeekdayParsing = new GroupBox();
            ParsingBut = new Button();
            ParseTextBox = new TextBox();
            ParseLabel = new Label();
            ValuePaesing = new Label();
            WeekdayParsing.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Controls.Add(ParsingBut);
            WeekdayParsing.Controls.Add(ParseTextBox);
            WeekdayParsing.Controls.Add(ParseLabel);
            WeekdayParsing.Controls.Add(ValuePaesing);
            WeekdayParsing.Dock = DockStyle.Fill;
            WeekdayParsing.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            WeekdayParsing.Location = new Point(0, 0);
            WeekdayParsing.Margin = new Padding(4, 5, 4, 5);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Padding = new Padding(4, 5, 4, 5);
            WeekdayParsing.Size = new Size(870, 576);
            WeekdayParsing.TabIndex = 1;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // ParsingBut
            // 
            ParsingBut.BackColor = Color.Silver;
            ParsingBut.Cursor = Cursors.Hand;
            ParsingBut.FlatAppearance.BorderColor = Color.Gray;
            ParsingBut.FlatAppearance.BorderSize = 2;
            ParsingBut.FlatAppearance.MouseDownBackColor = Color.White;
            ParsingBut.FlatAppearance.MouseOverBackColor = Color.White;
            ParsingBut.FlatStyle = FlatStyle.Flat;
            ParsingBut.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ParsingBut.ImeMode = ImeMode.On;
            ParsingBut.Location = new Point(413, 148);
            ParsingBut.Margin = new Padding(4, 5, 4, 5);
            ParsingBut.Name = "ParsingBut";
            ParsingBut.Size = new Size(174, 42);
            ParsingBut.TabIndex = 3;
            ParsingBut.Text = "Parse";
            ParsingBut.UseVisualStyleBackColor = false;
            ParsingBut.Click += ParsingBut_Click;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(37, 148);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(369, 33);
            ParseTextBox.TabIndex = 4;
            // 
            // ParseLabel
            // 
            ParseLabel.AutoSize = true;
            ParseLabel.ImeMode = ImeMode.On;
            ParseLabel.Location = new Point(37, 247);
            ParseLabel.Margin = new Padding(4, 0, 4, 0);
            ParseLabel.Name = "ParseLabel";
            ParseLabel.Size = new Size(0, 26);
            ParseLabel.TabIndex = 1;
            // 
            // ValuePaesing
            // 
            ValuePaesing.AutoSize = true;
            ValuePaesing.ImeMode = ImeMode.On;
            ValuePaesing.Location = new Point(37, 115);
            ValuePaesing.Margin = new Padding(4, 0, 4, 0);
            ValuePaesing.Name = "ValuePaesing";
            ValuePaesing.Size = new Size(234, 26);
            ValuePaesing.TabIndex = 0;
            ValuePaesing.Text = "Type value for parsing :\r\n";
            // 
            // WeekdayControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParsing);
            Name = "WeekdayControl";
            Size = new Size(870, 576);
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayParsing;
        private Button ParsingBut;
        private TextBox ParseTextBox;
        private Label ParseLabel;
        private Label ValuePaesing;
    }
}
