namespace Programming.View.Blocks
{
    partial class EnumerationControl
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
            Enumeration = new GroupBox();
            IntTextBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            IntValue = new Label();
            ChooseValue = new Label();
            ChooseEnumaration = new Label();
            Enumeration.SuspendLayout();
            SuspendLayout();
            // 
            // Enumeration
            // 
            Enumeration.Controls.Add(IntTextBox);
            Enumeration.Controls.Add(ValuesListBox);
            Enumeration.Controls.Add(EnumsListBox);
            Enumeration.Controls.Add(IntValue);
            Enumeration.Controls.Add(ChooseValue);
            Enumeration.Controls.Add(ChooseEnumaration);
            Enumeration.Dock = DockStyle.Fill;
            Enumeration.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Enumeration.Location = new Point(0, 0);
            Enumeration.Margin = new Padding(4, 5, 4, 5);
            Enumeration.Name = "Enumeration";
            Enumeration.Padding = new Padding(4, 5, 4, 5);
            Enumeration.Size = new Size(1352, 534);
            Enumeration.TabIndex = 2;
            Enumeration.TabStop = false;
            Enumeration.Text = "Enumeration";
            // 
            // IntTextBox
            // 
            IntTextBox.Location = new Point(659, 100);
            IntTextBox.Margin = new Padding(4, 5, 4, 5);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(141, 33);
            IntTextBox.TabIndex = 5;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 26;
            ValuesListBox.Location = new Point(353, 100);
            ValuesListBox.Margin = new Padding(4, 5, 4, 5);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(273, 316);
            ValuesListBox.TabIndex = 4;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 26;
            EnumsListBox.Location = new Point(41, 100);
            EnumsListBox.Margin = new Padding(4, 5, 4, 5);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(273, 316);
            EnumsListBox.TabIndex = 3;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.ImeMode = ImeMode.On;
            IntValue.Location = new Point(659, 67);
            IntValue.Margin = new Padding(4, 0, 4, 0);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(106, 26);
            IntValue.TabIndex = 2;
            IntValue.Text = "Int value :";
            // 
            // ChooseValue
            // 
            ChooseValue.AutoSize = true;
            ChooseValue.ImeMode = ImeMode.On;
            ChooseValue.Location = new Point(353, 67);
            ChooseValue.Margin = new Padding(4, 0, 4, 0);
            ChooseValue.Name = "ChooseValue";
            ChooseValue.Size = new Size(150, 26);
            ChooseValue.TabIndex = 1;
            ChooseValue.Text = "Choose value :\r\n";
            // 
            // ChooseEnumaration
            // 
            ChooseEnumaration.AutoSize = true;
            ChooseEnumaration.ImeMode = ImeMode.On;
            ChooseEnumaration.Location = new Point(41, 67);
            ChooseEnumaration.Margin = new Padding(4, 0, 4, 0);
            ChooseEnumaration.Name = "ChooseEnumaration";
            ChooseEnumaration.Size = new Size(216, 26);
            ChooseEnumaration.TabIndex = 0;
            ChooseEnumaration.Text = "Choose enumaration :\r\n";
            // 
            // EnumerationControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Enumeration);
            Name = "EnumerationControl";
            Size = new Size(1352, 534);
            Enumeration.ResumeLayout(false);
            Enumeration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Enumeration;
        private TextBox IntTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label IntValue;
        private Label ChooseValue;
        private Label ChooseEnumaration;
    }
}
