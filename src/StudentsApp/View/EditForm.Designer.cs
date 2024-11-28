namespace StudentsApp.View
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            StudentsAppGroupBox = new GroupBox();
            StudentsDeletePictureBox = new PictureBox();
            GroupTextBox = new TextBox();
            StudentsEditPictureBox = new PictureBox();
            GroupLabel = new Label();
            FacultyLabel = new Label();
            FacultyComboBox = new ComboBox();
            FormOfEducationLabel = new Label();
            RecordNumberTextBox = new TextBox();
            RecordNumberLabel = new Label();
            FormOfEducationComboBox = new ComboBox();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            StudentsAppGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDeletePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsEditPictureBox).BeginInit();
            SuspendLayout();
            // 
            // StudentsAppGroupBox
            // 
            StudentsAppGroupBox.Controls.Add(StudentsDeletePictureBox);
            StudentsAppGroupBox.Controls.Add(GroupTextBox);
            StudentsAppGroupBox.Controls.Add(StudentsEditPictureBox);
            StudentsAppGroupBox.Controls.Add(GroupLabel);
            StudentsAppGroupBox.Controls.Add(FacultyLabel);
            StudentsAppGroupBox.Controls.Add(FacultyComboBox);
            StudentsAppGroupBox.Controls.Add(FormOfEducationLabel);
            StudentsAppGroupBox.Controls.Add(RecordNumberTextBox);
            StudentsAppGroupBox.Controls.Add(RecordNumberLabel);
            StudentsAppGroupBox.Controls.Add(FormOfEducationComboBox);
            StudentsAppGroupBox.Controls.Add(FullNameTextBox);
            StudentsAppGroupBox.Controls.Add(FullNameLabel);
            StudentsAppGroupBox.Dock = DockStyle.Fill;
            StudentsAppGroupBox.Location = new Point(0, 0);
            StudentsAppGroupBox.Margin = new Padding(10);
            StudentsAppGroupBox.Name = "StudentsAppGroupBox";
            StudentsAppGroupBox.Size = new Size(629, 755);
            StudentsAppGroupBox.TabIndex = 3;
            StudentsAppGroupBox.TabStop = false;
            StudentsAppGroupBox.Text = "StudentsApp";
            // 
            // StudentsDeletePictureBox
            // 
            StudentsDeletePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentsDeletePictureBox.ErrorImage = (Image)resources.GetObject("StudentsDeletePictureBox.ErrorImage");
            StudentsDeletePictureBox.Image = (Image)resources.GetObject("StudentsDeletePictureBox.Image");
            StudentsDeletePictureBox.InitialImage = (Image)resources.GetObject("StudentsDeletePictureBox.InitialImage");
            StudentsDeletePictureBox.Location = new Point(405, 577);
            StudentsDeletePictureBox.Name = "StudentsDeletePictureBox";
            StudentsDeletePictureBox.Size = new Size(50, 50);
            StudentsDeletePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentsDeletePictureBox.TabIndex = 12;
            StudentsDeletePictureBox.TabStop = false;
            StudentsDeletePictureBox.Click += StudentsDeletePictureBox_Click;
            // 
            // GroupTextBox
            // 
            GroupTextBox.Location = new Point(38, 506);
            GroupTextBox.Name = "GroupTextBox";
            GroupTextBox.Size = new Size(549, 31);
            GroupTextBox.TabIndex = 9;
            GroupTextBox.TextChanged += GroupTextBox_TextChanged;
            // 
            // StudentsEditPictureBox
            // 
            StudentsEditPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentsEditPictureBox.ErrorImage = (Image)resources.GetObject("StudentsEditPictureBox.ErrorImage");
            StudentsEditPictureBox.Image = (Image)resources.GetObject("StudentsEditPictureBox.Image");
            StudentsEditPictureBox.InitialImage = (Image)resources.GetObject("StudentsEditPictureBox.InitialImage");
            StudentsEditPictureBox.Location = new Point(122, 577);
            StudentsEditPictureBox.Name = "StudentsEditPictureBox";
            StudentsEditPictureBox.Size = new Size(50, 50);
            StudentsEditPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentsEditPictureBox.TabIndex = 11;
            StudentsEditPictureBox.TabStop = false;
            StudentsEditPictureBox.Click += StudentsEditPictureBox_Click;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(38, 478);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(107, 25);
            GroupLabel.TabIndex = 8;
            GroupLabel.Text = "GroupLabel:";
            // 
            // FacultyLabel
            // 
            FacultyLabel.AutoSize = true;
            FacultyLabel.Location = new Point(38, 369);
            FacultyLabel.Name = "FacultyLabel";
            FacultyLabel.Size = new Size(70, 25);
            FacultyLabel.TabIndex = 7;
            FacultyLabel.Text = "Faculty:";
            // 
            // FacultyComboBox
            // 
            FacultyComboBox.FormattingEnabled = true;
            FacultyComboBox.Location = new Point(38, 397);
            FacultyComboBox.Name = "FacultyComboBox";
            FacultyComboBox.Size = new Size(549, 33);
            FacultyComboBox.TabIndex = 6;
            FacultyComboBox.SelectedIndexChanged += FacultyComboBox_SelectedIndexChanged;
            // 
            // FormOfEducationLabel
            // 
            FormOfEducationLabel.AutoSize = true;
            FormOfEducationLabel.Location = new Point(38, 265);
            FormOfEducationLabel.Name = "FormOfEducationLabel";
            FormOfEducationLabel.Size = new Size(163, 25);
            FormOfEducationLabel.TabIndex = 5;
            FormOfEducationLabel.Text = "Form of education:";
            // 
            // RecordNumberTextBox
            // 
            RecordNumberTextBox.Location = new Point(38, 197);
            RecordNumberTextBox.Name = "RecordNumberTextBox";
            RecordNumberTextBox.Size = new Size(549, 31);
            RecordNumberTextBox.TabIndex = 4;
            // 
            // RecordNumberLabel
            // 
            RecordNumberLabel.AutoSize = true;
            RecordNumberLabel.Location = new Point(38, 169);
            RecordNumberLabel.Name = "RecordNumberLabel";
            RecordNumberLabel.Size = new Size(138, 25);
            RecordNumberLabel.TabIndex = 3;
            RecordNumberLabel.Text = "Record number:";
            // 
            // FormOfEducationComboBox
            // 
            FormOfEducationComboBox.FormattingEnabled = true;
            FormOfEducationComboBox.Location = new Point(38, 293);
            FormOfEducationComboBox.Name = "FormOfEducationComboBox";
            FormOfEducationComboBox.Size = new Size(549, 33);
            FormOfEducationComboBox.TabIndex = 2;
            FormOfEducationComboBox.SelectedIndexChanged += FormOfEducationComboBox_SelectedIndexChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(38, 99);
            FullNameTextBox.Margin = new Padding(3, 20, 3, 20);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(549, 31);
            FullNameTextBox.TabIndex = 1;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(38, 70);
            FullNameLabel.Margin = new Padding(3, 20, 3, 20);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(92, 25);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "Full name:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 755);
            Controls.Add(StudentsAppGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(651, 811);
            Name = "EditForm";
            Text = "Students Add";
            StudentsAppGroupBox.ResumeLayout(false);
            StudentsAppGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDeletePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsEditPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentsAppGroupBox;
        private PictureBox StudentsDeletePictureBox;
        private TextBox GroupTextBox;
        private PictureBox StudentsEditPictureBox;
        private Label GroupLabel;
        private Label FacultyLabel;
        private ComboBox FacultyComboBox;
        private Label FormOfEducationLabel;
        private TextBox RecordNumberTextBox;
        private Label RecordNumberLabel;
        private ComboBox FormOfEducationComboBox;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
    }
}