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
            this.label1 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntValue = new System.Windows.Forms.Label();
            this.ChooseValue = new System.Windows.Forms.Label();
            this.ChooseEnumaration = new System.Windows.Forms.Label();
            this.Enums.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.Enumeration.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tabPage1);
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
            this.SeasonHandle.Controls.Add(this.label1);
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
            this.SeasonComboBox.SelectedIndexChanged += new System.EventHandler(this.SesonComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.Enumaration_SelectedIndexChanged);
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Enums);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private Label label1;
        private Button GoButton;
        private ComboBox SeasonComboBox;
    }
}