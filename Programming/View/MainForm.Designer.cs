namespace Programming
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
            this.Enums = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsing = new System.Windows.Forms.GroupBox();
            this.ParsingBut = new System.Windows.Forms.Button();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParseLabel = new System.Windows.Forms.Label();
            this.ValuePaesing = new System.Windows.Forms.Label();
            this.SeasonHandle = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSesonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.ChooseEnumaration = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorsTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeigthTextBox = new System.Windows.Forms.TextBox();
            this.ColorsLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeigthLabel = new System.Windows.Forms.Label();
            this.ReactanglesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.Enumeration.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tabPage1);
            this.Enums.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.Enums, "Enums");
            this.Enums.Name = "Enums";
            this.Enums.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Enumeration, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.WeekdayParsing, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SeasonHandle, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.ParsingBut);
            this.WeekdayParsing.Controls.Add(this.ParseTextBox);
            this.WeekdayParsing.Controls.Add(this.ParseLabel);
            this.WeekdayParsing.Controls.Add(this.ValuePaesing);
            resources.ApplyResources(this.WeekdayParsing, "WeekdayParsing");
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.TabStop = false;
            // 
            // ParsingBut
            // 
            this.ParsingBut.BackColor = System.Drawing.Color.Silver;
            this.ParsingBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParsingBut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ParsingBut.FlatAppearance.BorderSize = 2;
            this.ParsingBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ParsingBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ParsingBut, "ParsingBut");
            this.ParsingBut.Name = "ParsingBut";
            this.ParsingBut.UseVisualStyleBackColor = false;
            this.ParsingBut.Click += new System.EventHandler(this.ParsingBut_Click);
            // 
            // ParseTextBox
            // 
            resources.ApplyResources(this.ParseTextBox, "ParseTextBox");
            this.ParseTextBox.Name = "ParseTextBox";
            // 
            // ParseLabel
            // 
            resources.ApplyResources(this.ParseLabel, "ParseLabel");
            this.ParseLabel.Name = "ParseLabel";
            // 
            // ValuePaesing
            // 
            resources.ApplyResources(this.ValuePaesing, "ValuePaesing");
            this.ValuePaesing.Name = "ValuePaesing";
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.ChooseSesonLabel);
            this.SeasonHandle.Controls.Add(this.GoButton);
            resources.ApplyResources(this.SeasonHandle, "SeasonHandle");
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.TabStop = false;
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.SeasonComboBox, "SeasonComboBox");
            this.SeasonComboBox.Name = "SeasonComboBox";
            // 
            // ChooseSesonLabel
            // 
            resources.ApplyResources(this.ChooseSesonLabel, "ChooseSesonLabel");
            this.ChooseSesonLabel.Name = "ChooseSesonLabel";
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.Silver;
            this.GoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.GoButton.FlatAppearance.BorderSize = 2;
            this.GoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.GoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.GoButton, "GoButton");
            this.GoButton.Name = "GoButton";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.GoButtn_Click);
            // 
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.IntTextBox);
            this.Enumeration.Controls.Add(this.ValuesListBox);
            this.Enumeration.Controls.Add(this.EnumsListBox);
            this.Enumeration.Controls.Add(this.IntValue);
            this.Enumeration.Controls.Add(this.ChooseValue);
            this.Enumeration.Controls.Add(this.ChooseEnumaration);
            resources.ApplyResources(this.Enumeration, "Enumeration");
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.TabStop = false;
            // 
            // IntTextBox
            // 
            resources.ApplyResources(this.IntTextBox, "IntTextBox");
            this.IntTextBox.Name = "IntTextBox";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ValuesListBox, "ValuesListBox");
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.EnumsListBox, "EnumsListBox");
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.Enumeration_SelectedIndexChanged);
            // 
            // IntValue
            // 
            resources.ApplyResources(this.IntValue, "IntValue");
            this.IntValue.Name = "IntValue";
            // 
            // ChooseValue
            // 
            resources.ApplyResources(this.ChooseValue, "ChooseValue");
            this.ChooseValue.Name = "ChooseValue";
            // 
            // ChooseEnumaration
            // 
            resources.ApplyResources(this.ChooseEnumaration, "ChooseEnumaration");
            this.ChooseEnumaration.Name = "ChooseEnumaration";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorsTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.HeigthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorsLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.HeigthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ReactanglesListBox);
            resources.ApplyResources(this.RectanglesGroupBox, "RectanglesGroupBox");
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Enter += new System.EventHandler(this.RectanglesGroupBox_Enter);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.Silver;
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FindButton.FlatAppearance.BorderSize = 2;
            this.FindButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FindButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.FindButton, "FindButton");
            this.FindButton.Name = "FindButton";
            this.FindButton.UseVisualStyleBackColor = false;
            // 
            // ColorsTextBox
            // 
            resources.ApplyResources(this.ColorsTextBox, "ColorsTextBox");
            this.ColorsTextBox.Name = "ColorsTextBox";
            this.ColorsTextBox.TextChanged += new System.EventHandler(this.ColorsTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            resources.ApplyResources(this.WidthTextBox, "WidthTextBox");
            this.WidthTextBox.Name = "WidthTextBox";
            // 
            // HeigthTextBox
            // 
            resources.ApplyResources(this.HeigthTextBox, "HeigthTextBox");
            this.HeigthTextBox.Name = "HeigthTextBox";
            // 
            // ColorsLabel
            // 
            resources.ApplyResources(this.ColorsLabel, "ColorsLabel");
            this.ColorsLabel.Name = "ColorsLabel";
            // 
            // WidthLabel
            // 
            resources.ApplyResources(this.WidthLabel, "WidthLabel");
            this.WidthLabel.Name = "WidthLabel";
            // 
            // HeigthLabel
            // 
            resources.ApplyResources(this.HeigthLabel, "HeigthLabel");
            this.HeigthLabel.Name = "HeigthLabel";
            // 
            // ReactanglesListBox
            // 
            this.ReactanglesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ReactanglesListBox, "ReactanglesListBox");
            this.ReactanglesListBox.Items.AddRange(new object[] {
            resources.GetString("ReactanglesListBox.Items"),
            resources.GetString("ReactanglesListBox.Items1"),
            resources.GetString("ReactanglesListBox.Items2"),
            resources.GetString("ReactanglesListBox.Items3"),
            resources.GetString("ReactanglesListBox.Items4")});
            this.ReactanglesListBox.Name = "ReactanglesListBox";
            this.ReactanglesListBox.SelectedIndexChanged += new System.EventHandler(this.ReactanglesListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Enums);
            this.Name = "MainForm";
            this.Enums.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.Enumeration.ResumeLayout(false);
            this.Enumeration.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Enums;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox WeekdayParsing;
        private GroupBox SeasonHandle;
        private GroupBox Enumeration;
        private TextBox IntTextBox;
        private Label IntValue;
        private Label ChooseValue;
        private Label ChooseEnumaration;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Button ParsingBut;
        private TextBox ParseTextBox;
        private Label ParseLabel;
        private Label ValuePaesing;
        private Label ChooseSesonLabel;
        private Button GoButton;
        private ComboBox SeasonComboBox;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox RectanglesGroupBox;
        private TextBox ColorsTextBox;
        private TextBox WidthTextBox;
        private TextBox HeigthTextBox;
        private Label ColorsLabel;
        private Label WidthLabel;
        private Label HeigthLabel;
        private ListBox ReactanglesListBox;
        private GroupBox groupBox2;
        private Button FindButton;
        private FontDialog fontDialog1;
    }
}