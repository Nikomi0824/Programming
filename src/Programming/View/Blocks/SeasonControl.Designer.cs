namespace Programming.View.Blocks
{
    partial class SeasonControl
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
            SeasonHandle = new GroupBox();
            SeasonComboBox = new ComboBox();
            ChooseSesonLabel = new Label();
            GoButton = new Button();
            SeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(ChooseSesonLabel);
            SeasonHandle.Controls.Add(GoButton);
            SeasonHandle.Dock = DockStyle.Fill;
            SeasonHandle.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SeasonHandle.Location = new Point(0, 0);
            SeasonHandle.Margin = new Padding(4, 5, 4, 5);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Padding = new Padding(4, 5, 4, 5);
            SeasonHandle.Size = new Size(896, 738);
            SeasonHandle.TabIndex = 2;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(33, 145);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(370, 34);
            SeasonComboBox.TabIndex = 7;
            // 
            // ChooseSesonLabel
            // 
            ChooseSesonLabel.AutoSize = true;
            ChooseSesonLabel.ImeMode = ImeMode.On;
            ChooseSesonLabel.Location = new Point(33, 112);
            ChooseSesonLabel.Margin = new Padding(4, 0, 4, 0);
            ChooseSesonLabel.Name = "ChooseSesonLabel";
            ChooseSesonLabel.Size = new Size(152, 26);
            ChooseSesonLabel.TabIndex = 6;
            ChooseSesonLabel.Text = "Choose seson :";
            // 
            // GoButton
            // 
            GoButton.BackColor = Color.Silver;
            GoButton.Cursor = Cursors.Hand;
            GoButton.FlatAppearance.BorderColor = Color.Gray;
            GoButton.FlatAppearance.BorderSize = 2;
            GoButton.FlatAppearance.MouseDownBackColor = Color.White;
            GoButton.FlatAppearance.MouseOverBackColor = Color.White;
            GoButton.FlatStyle = FlatStyle.Flat;
            GoButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            GoButton.ImeMode = ImeMode.On;
            GoButton.Location = new Point(411, 145);
            GoButton.Margin = new Padding(4, 5, 4, 5);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(174, 42);
            GoButton.TabIndex = 4;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = false;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandle);
            Name = "SeasonControl";
            Size = new Size(896, 738);
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandle;
        private ComboBox SeasonComboBox;
        private Label ChooseSesonLabel;
        private Button GoButton;
    }
}
