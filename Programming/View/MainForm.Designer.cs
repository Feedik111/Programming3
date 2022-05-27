using System.ComponentModel;

namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EnumTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleTabPage = new System.Windows.Forms.TabPage();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.enumerationControl1 = new Programming.View.Controls.EnumerationControl();
            this.rectangleControl1 = new Programming.View.Controls.RectangleControl();
            this.movieControl1 = new Programming.View.Controls.MovieControl();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.seasonControl1 = new Programming.View.Controls.SeasonControl();
            this.MainTabControl.SuspendLayout();
            this.EnumTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.RectangleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.RectangleTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(612, 456);
            this.MainTabControl.TabIndex = 0;
            // 
            // EnumTabPage
            // 
            this.EnumTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Name = "EnumTabPage";
            this.EnumTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.EnumTabPage.Size = new System.Drawing.Size(604, 430);
            this.EnumTabPage.TabIndex = 1;
            this.EnumTabPage.Text = "Enums";
            this.EnumTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.seasonControl1);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(300, 208);
            this.SeasonHandleGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(288, 161);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(4, 208);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(292, 161);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.enumerationControl1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(4, 0);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(584, 209);
            this.EnumerationsGroupBox.TabIndex = 0;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumeration";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Controls.Add(this.MovieGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(604, 430);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectangleControl1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(5, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(282, 368);
            this.RectanglesGroupBox.TabIndex = 2;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.movieControl1);
            this.MovieGroupBox.Location = new System.Drawing.Point(292, 0);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(296, 369);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // RectangleTabPage
            // 
            this.RectangleTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectangleTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectangleTabPage.Name = "RectangleTabPage";
            this.RectangleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectangleTabPage.Size = new System.Drawing.Size(604, 430);
            this.RectangleTabPage.TabIndex = 3;
            this.RectangleTabPage.Text = "Rectangle";
            this.RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(2, 15);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(288, 144);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationControl1.Location = new System.Drawing.Point(2, 15);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(580, 192);
            this.enumerationControl1.TabIndex = 0;
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleControl1.Location = new System.Drawing.Point(3, 16);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.Size = new System.Drawing.Size(276, 349);
            this.rectangleControl1.TabIndex = 0;
            // 
            // movieControl1
            // 
            this.movieControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieControl1.Location = new System.Drawing.Point(3, 16);
            this.movieControl1.Name = "movieControl1";
            this.movieControl1.Size = new System.Drawing.Size(290, 350);
            this.movieControl1.TabIndex = 0;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(598, 424);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // seasonControl1
            // 
            this.seasonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonControl1.Location = new System.Drawing.Point(2, 15);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(284, 144);
            this.seasonControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 456);
            this.Controls.Add(this.MainTabControl);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.MainTabControl.ResumeLayout(false);
            this.EnumTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.RectangleTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox RectanglesGroupBox;

        private System.Windows.Forms.TabPage RectangleTabPage;

        private System.Windows.Forms.GroupBox MovieGroupBox;


        private System.Windows.Forms.TabPage ClassesTabPage;

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;

        private System.Windows.Forms.GroupBox EnumerationsGroupBox;


        private System.Windows.Forms.TabPage EnumTabPage;

        #endregion

        private View.Controls.MovieControl movieControl1;
        private View.Controls.RectangleControl rectangleControl1;
        private View.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Controls.EnumerationControl enumerationControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeasonControl seasonControl1;
    }
}