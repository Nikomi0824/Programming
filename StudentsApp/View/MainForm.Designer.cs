namespace StudentsApp
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
            tabControl1 = new TabControl();
            StudentsApp = new TabPage();
            StudentsTableLayoutPanel = new TableLayoutPanel();
            StudentsListBox = new ListBox();
            panel1 = new Panel();
            StudentsDeletePictureBox = new PictureBox();
            StudentsEditPictureBox = new PictureBox();
            StudentsAddPictureBox = new PictureBox();
            groupBox1 = new GroupBox();
            GroupTextBox = new TextBox();
            GroupLabel = new Label();
            FacultyLabel = new Label();
            FacultyComboBox = new ComboBox();
            FormOfEducationLabel = new Label();
            RecordNumberTextBox = new TextBox();
            RecordNumberLabel = new Label();
            FormOfEducationComboBox = new ComboBox();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            tabControl1.SuspendLayout();
            StudentsApp.SuspendLayout();
            StudentsTableLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDeletePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsEditPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsAddPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(StudentsApp);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1283, 853);
            tabControl1.TabIndex = 0;
            // 
            // StudentsApp
            // 
            StudentsApp.Controls.Add(StudentsTableLayoutPanel);
            StudentsApp.Location = new Point(4, 34);
            StudentsApp.Name = "StudentsApp";
            StudentsApp.Padding = new Padding(3);
            StudentsApp.Size = new Size(1275, 815);
            StudentsApp.TabIndex = 0;
            StudentsApp.Text = "Students";
            StudentsApp.UseVisualStyleBackColor = true;
            // 
            // StudentsTableLayoutPanel
            // 
            StudentsTableLayoutPanel.ColumnCount = 2;
            StudentsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.9227753F));
            StudentsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.0772247F));
            StudentsTableLayoutPanel.Controls.Add(StudentsListBox, 0, 0);
            StudentsTableLayoutPanel.Controls.Add(panel1, 0, 1);
            StudentsTableLayoutPanel.Controls.Add(groupBox1, 1, 0);
            StudentsTableLayoutPanel.Dock = DockStyle.Fill;
            StudentsTableLayoutPanel.Location = new Point(3, 3);
            StudentsTableLayoutPanel.Name = "StudentsTableLayoutPanel";
            StudentsTableLayoutPanel.RowCount = 2;
            StudentsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90.48208F));
            StudentsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 9.517923F));
            StudentsTableLayoutPanel.Size = new Size(1269, 809);
            StudentsTableLayoutPanel.TabIndex = 0;
            // 
            // StudentsListBox
            // 
            StudentsListBox.Dock = DockStyle.Fill;
            StudentsListBox.FormattingEnabled = true;
            StudentsListBox.ItemHeight = 25;
            StudentsListBox.Location = new Point(20, 20);
            StudentsListBox.Margin = new Padding(20);
            StudentsListBox.Name = "StudentsListBox";
            StudentsListBox.Size = new Size(492, 692);
            StudentsListBox.TabIndex = 0;
            StudentsListBox.SelectedIndexChanged += StudentsListBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(StudentsDeletePictureBox);
            panel1.Controls.Add(StudentsEditPictureBox);
            panel1.Controls.Add(StudentsAddPictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 735);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 71);
            panel1.TabIndex = 1;
            // 
            // StudentsDeletePictureBox
            // 
            StudentsDeletePictureBox.BackgroundImage = (Image)resources.GetObject("StudentsDeletePictureBox.BackgroundImage");
            StudentsDeletePictureBox.ErrorImage = (Image)resources.GetObject("StudentsDeletePictureBox.ErrorImage");
            StudentsDeletePictureBox.InitialImage = (Image)resources.GetObject("StudentsDeletePictureBox.InitialImage");
            StudentsDeletePictureBox.Location = new Point(325, 3);
            StudentsDeletePictureBox.Name = "StudentsDeletePictureBox";
            StudentsDeletePictureBox.Size = new Size(50, 50);
            StudentsDeletePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentsDeletePictureBox.TabIndex = 12;
            StudentsDeletePictureBox.TabStop = false;
            StudentsDeletePictureBox.Click += StudentsDeletePictureBox_Click;
            // 
            // StudentsEditPictureBox
            // 
            StudentsEditPictureBox.BackgroundImage = (Image)resources.GetObject("StudentsEditPictureBox.BackgroundImage");
            StudentsEditPictureBox.ErrorImage = (Image)resources.GetObject("StudentsEditPictureBox.ErrorImage");
            StudentsEditPictureBox.InitialImage = (Image)resources.GetObject("StudentsEditPictureBox.InitialImage");
            StudentsEditPictureBox.Location = new Point(202, 3);
            StudentsEditPictureBox.Name = "StudentsEditPictureBox";
            StudentsEditPictureBox.Size = new Size(50, 50);
            StudentsEditPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentsEditPictureBox.TabIndex = 11;
            StudentsEditPictureBox.TabStop = false;
            StudentsEditPictureBox.Click += StudentsEditPictureBox_Click;
            // 
            // StudentsAddPictureBox
            // 
            StudentsAddPictureBox.BackgroundImage = (Image)resources.GetObject("StudentsAddPictureBox.BackgroundImage");
            StudentsAddPictureBox.ErrorImage = (Image)resources.GetObject("StudentsAddPictureBox.ErrorImage");
            StudentsAddPictureBox.InitialImage = (Image)resources.GetObject("StudentsAddPictureBox.InitialImage");
            StudentsAddPictureBox.Location = new Point(67, 3);
            StudentsAddPictureBox.Name = "StudentsAddPictureBox";
            StudentsAddPictureBox.Size = new Size(50, 50);
            StudentsAddPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            StudentsAddPictureBox.TabIndex = 10;
            StudentsAddPictureBox.TabStop = false;
            StudentsAddPictureBox.Click += StudentsAddPictureBox_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GroupTextBox);
            groupBox1.Controls.Add(GroupLabel);
            groupBox1.Controls.Add(FacultyLabel);
            groupBox1.Controls.Add(FacultyComboBox);
            groupBox1.Controls.Add(FormOfEducationLabel);
            groupBox1.Controls.Add(RecordNumberTextBox);
            groupBox1.Controls.Add(RecordNumberLabel);
            groupBox1.Controls.Add(FormOfEducationComboBox);
            groupBox1.Controls.Add(FullNameTextBox);
            groupBox1.Controls.Add(FullNameLabel);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(542, 10);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 712);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // GroupTextBox
            // 
            GroupTextBox.Location = new Point(37, 514);
            GroupTextBox.Name = "GroupTextBox";
            GroupTextBox.Size = new Size(645, 31);
            GroupTextBox.TabIndex = 9;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(37, 477);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(103, 25);
            GroupLabel.TabIndex = 8;
            GroupLabel.Text = "GroupLabel";
            // 
            // FacultyLabel
            // 
            FacultyLabel.AutoSize = true;
            FacultyLabel.Location = new Point(37, 372);
            FacultyLabel.Name = "FacultyLabel";
            FacultyLabel.Size = new Size(66, 25);
            FacultyLabel.TabIndex = 7;
            FacultyLabel.Text = "Faculty";
            // 
            // FacultyComboBox
            // 
            FacultyComboBox.FormattingEnabled = true;
            FacultyComboBox.Location = new Point(37, 417);
            FacultyComboBox.Name = "FacultyComboBox";
            FacultyComboBox.Size = new Size(645, 33);
            FacultyComboBox.TabIndex = 6;
            // 
            // FormOfEducationLabel
            // 
            FormOfEducationLabel.AutoSize = true;
            FormOfEducationLabel.Location = new Point(37, 265);
            FormOfEducationLabel.Name = "FormOfEducationLabel";
            FormOfEducationLabel.Size = new Size(159, 25);
            FormOfEducationLabel.TabIndex = 5;
            FormOfEducationLabel.Text = "Form of education";
            // 
            // RecordNumberTextBox
            // 
            RecordNumberTextBox.Location = new Point(37, 205);
            RecordNumberTextBox.Name = "RecordNumberTextBox";
            RecordNumberTextBox.Size = new Size(645, 31);
            RecordNumberTextBox.TabIndex = 4;
            // 
            // RecordNumberLabel
            // 
            RecordNumberLabel.AutoSize = true;
            RecordNumberLabel.Location = new Point(37, 168);
            RecordNumberLabel.Name = "RecordNumberLabel";
            RecordNumberLabel.Size = new Size(134, 25);
            RecordNumberLabel.TabIndex = 3;
            RecordNumberLabel.Text = "Record number";
            // 
            // FormOfEducationComboBox
            // 
            FormOfEducationComboBox.FormattingEnabled = true;
            FormOfEducationComboBox.Location = new Point(37, 310);
            FormOfEducationComboBox.Name = "FormOfEducationComboBox";
            FormOfEducationComboBox.Size = new Size(645, 33);
            FormOfEducationComboBox.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(37, 107);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(645, 31);
            FullNameTextBox.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(37, 70);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(88, 25);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "Full name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 853);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            StudentsApp.ResumeLayout(false);
            StudentsTableLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentsDeletePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsEditPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsAddPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage StudentsApp;
        private TableLayoutPanel StudentsTableLayoutPanel;
        private ListBox StudentsListBox;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox FormOfEducationComboBox;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private Label FormOfEducationLabel;
        private TextBox RecordNumberTextBox;
        private Label RecordNumberLabel;
        private TextBox GroupTextBox;
        private Label GroupLabel;
        private Label FacultyLabel;
        private ComboBox FacultyComboBox;
        private PictureBox StudentsAddPictureBox;
        private PictureBox StudentsDeletePictureBox;
        private PictureBox StudentsEditPictureBox;
    }
}
