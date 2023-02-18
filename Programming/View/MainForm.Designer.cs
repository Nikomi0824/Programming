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
            this.parsingBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValuePaesing = new System.Windows.Forms.Label();
            this.SeasonHandle = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.goButtn = new System.Windows.Forms.Button();
            this.Enumeration = new System.Windows.Forms.GroupBox();
            this.Int = new System.Windows.Forms.TextBox();
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
            this.WeekdayParsing.Controls.Add(this.parsingBut);
            this.WeekdayParsing.Controls.Add(this.textBox1);
            this.WeekdayParsing.Controls.Add(this.label2);
            this.WeekdayParsing.Controls.Add(this.ValuePaesing);
            resources.ApplyResources(this.WeekdayParsing, "WeekdayParsing");
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.TabStop = false;
            // 
            // parsingBut
            // 
            this.parsingBut.BackColor = System.Drawing.Color.Silver;
            this.parsingBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parsingBut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.parsingBut.FlatAppearance.BorderSize = 2;
            this.parsingBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.parsingBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.parsingBut, "parsingBut");
            this.parsingBut.Name = "parsingBut";
            this.parsingBut.UseVisualStyleBackColor = false;
            this.parsingBut.Click += new System.EventHandler(this.parsingBut_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ValuePaesing
            // 
            resources.ApplyResources(this.ValuePaesing, "ValuePaesing");
            this.ValuePaesing.Name = "ValuePaesing";
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.label1);
            this.SeasonHandle.Controls.Add(this.textBox2);
            this.SeasonHandle.Controls.Add(this.goButtn);
            resources.ApplyResources(this.SeasonHandle, "SeasonHandle");
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // goButtn
            // 
            this.goButtn.BackColor = System.Drawing.Color.Silver;
            this.goButtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goButtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.goButtn.FlatAppearance.BorderSize = 2;
            this.goButtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.goButtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.goButtn, "goButtn");
            this.goButtn.Name = "goButtn";
            this.goButtn.UseVisualStyleBackColor = false;
            this.goButtn.Click += new System.EventHandler(this.goButtn_Click);
            // 
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.Int);
            this.Enumeration.Controls.Add(this.ValuesListBox);
            this.Enumeration.Controls.Add(this.EnumsListBox);
            this.Enumeration.Controls.Add(this.IntValue);
            this.Enumeration.Controls.Add(this.ChooseValue);
            this.Enumeration.Controls.Add(this.ChooseEnumaration);
            resources.ApplyResources(this.Enumeration, "Enumeration");
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.TabStop = false;
            // 
            // Int
            // 
            resources.ApplyResources(this.Int, "Int");
            this.Int.Name = "Int";
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
        private TextBox Int;
        private Label IntValue;
        private Label ChooseValue;
        private Label ChooseEnumaration;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Button parsingBut;
        private TextBox textBox1;
        private Label label2;
        private Label ValuePaesing;
        private Label label1;
        private TextBox textBox2;
        private Button goButtn;
    }
}