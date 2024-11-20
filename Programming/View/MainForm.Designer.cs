
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
            fontDialog1 = new FontDialog();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            moviesControl1 = new View.Blocks.MoviesControl();
            reactanglesControl2 = new View.Blocks.ReactanglesControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            weekdayControl1 = new View.Blocks.WeekdayControl();
            seasonControl1 = new View.Blocks.SeasonControl();
            enumerationControl1 = new View.Blocks.EnumerationControl();
            Rectangles = new TabControl();
            Rectaangle = new TabPage();
            reactanglesCollisionControl1 = new View.Blocks.ReactanglesCollisionControl();
            process1 = new System.Diagnostics.Process();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            Rectangles.SuspendLayout();
            Rectaangle.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(moviesControl1, 1, 0);
            tableLayoutPanel3.Controls.Add(reactanglesControl2, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // moviesControl1
            // 
            resources.ApplyResources(moviesControl1, "moviesControl1");
            moviesControl1.Name = "moviesControl1";
            // 
            // reactanglesControl2
            // 
            resources.ApplyResources(reactanglesControl2, "reactanglesControl2");
            reactanglesControl2.Name = "reactanglesControl2";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(enumerationControl1, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(weekdayControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(seasonControl1, 1, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // weekdayControl1
            // 
            resources.ApplyResources(weekdayControl1, "weekdayControl1");
            weekdayControl1.Name = "weekdayControl1";
            // 
            // seasonControl1
            // 
            resources.ApplyResources(seasonControl1, "seasonControl1");
            seasonControl1.Name = "seasonControl1";
            // 
            // enumerationControl1
            // 
            resources.ApplyResources(enumerationControl1, "enumerationControl1");
            enumerationControl1.Name = "enumerationControl1";
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(tabPage1);
            Rectangles.Controls.Add(tabPage2);
            Rectangles.Controls.Add(Rectaangle);
            resources.ApplyResources(Rectangles, "Rectangles");
            Rectangles.Name = "Rectangles";
            Rectangles.SelectedIndex = 0;
            Rectangles.Tag = "";
            // 
            // Rectaangle
            // 
            Rectaangle.Controls.Add(reactanglesCollisionControl1);
            resources.ApplyResources(Rectaangle, "Rectaangle");
            Rectaangle.Name = "Rectaangle";
            Rectaangle.UseVisualStyleBackColor = true;
            // 
            // reactanglesCollisionControl1
            // 
            resources.ApplyResources(reactanglesCollisionControl1, "reactanglesCollisionControl1");
            reactanglesCollisionControl1.Name = "reactanglesCollisionControl1";
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Rectangles);
            Name = "MainForm";
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectaangle.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Enumeration_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private FontDialog fontDialog1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabControl Rectangles;
        private System.Diagnostics.Process process1;
        private TabPage Rectaangle;
        private View.Blocks.ReactanglesCollisionControl reactanglesCollisionControl1;
        private View.Blocks.MoviesControl moviesControl1;
        private View.Blocks.ReactanglesControl reactanglesControl1;
        private View.Blocks.EnumerationControl enumerationControl1;
        private View.Blocks.WeekdayControl weekdayControl1;
        private View.Blocks.ReactanglesControl reactanglesControl2;
        private View.Blocks.SeasonControl seasonControl1;
    }
}