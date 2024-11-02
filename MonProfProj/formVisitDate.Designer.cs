namespace MonProfProj
{
    partial class formVisitDate
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
            Hourglass.HourglassOptions hourglassOptions1 = new Hourglass.HourglassOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVisitDate));
            this.hgScheduler1 = new Hourglass.HgScheduler();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthButton = new System.Windows.Forms.Button();
            this.WeekButton = new System.Windows.Forms.Button();
            this.DayButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.calendar2 = new calendar.Calendar();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hgScheduler1
            // 
            this.hgScheduler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.hgScheduler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hgScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hgScheduler1.Location = new System.Drawing.Point(0, 0);
            this.hgScheduler1.Margin = new System.Windows.Forms.Padding(0);
            this.hgScheduler1.Name = "hgScheduler1";
            hourglassOptions1.EventArrangement = null;
            hourglassOptions1.EventClickHandling = null;
            hourglassOptions1.EventDeleteHandling = null;
            hourglassOptions1.EventDoubleClickHandling = null;
            hourglassOptions1.HeaderDateFormat = "dddd";
            hourglassOptions1.StartDate = new System.DateTime(2024, 10, 21, 16, 48, 29, 14);
            hourglassOptions1.ViewType = Hourglass.ViewTypes.Week;
            this.hgScheduler1.Options = hourglassOptions1;
            this.hgScheduler1.Size = new System.Drawing.Size(944, 615);
            this.hgScheduler1.TabIndex = 1;
            this.hgScheduler1.Theme = resources.GetString("hgScheduler1.Theme");
            this.hgScheduler1.OnEventEdit += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler1_OnEventEdit);
            this.hgScheduler1.OnEventMove += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler1_OnEventEdit);
            this.hgScheduler1.OnEventResize += new Hourglass.HgScheduler.EventCancelableEventHandler(this.hgScheduler1_OnEventEdit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1260, 615);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.hgScheduler1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(316, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 615);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.MonthButton);
            this.panel1.Controls.Add(this.WeekButton);
            this.panel1.Controls.Add(this.DayButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.calendar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 615);
            this.panel1.TabIndex = 3;
            // 
            // MonthButton
            // 
            this.MonthButton.Location = new System.Drawing.Point(225, 484);
            this.MonthButton.Name = "MonthButton";
            this.MonthButton.Size = new System.Drawing.Size(75, 23);
            this.MonthButton.TabIndex = 5;
            this.MonthButton.Text = "Month";
            this.MonthButton.UseVisualStyleBackColor = true;
            this.MonthButton.Click += new System.EventHandler(this.MonthButton_Click_2);
            // 
            // WeekButton
            // 
            this.WeekButton.Location = new System.Drawing.Point(131, 484);
            this.WeekButton.Name = "WeekButton";
            this.WeekButton.Size = new System.Drawing.Size(75, 23);
            this.WeekButton.TabIndex = 4;
            this.WeekButton.Text = "Week";
            this.WeekButton.UseVisualStyleBackColor = true;
            this.WeekButton.Click += new System.EventHandler(this.WeekButton_Click_2);
            // 
            // DayButton
            // 
            this.DayButton.Location = new System.Drawing.Point(41, 484);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(75, 23);
            this.DayButton.TabIndex = 3;
            this.DayButton.Text = "Day";
            this.DayButton.UseVisualStyleBackColor = true;
            this.DayButton.Click += new System.EventHandler(this.DayButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendar2
            // 
            this.calendar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.calendar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(238)))), ((int)(((byte)(111)))));
            this.calendar2.ForeColorDatesPrimary = System.Drawing.Color.White;
            this.calendar2.ForeColorDatesSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(134)))), ((int)(((byte)(142)))));
            this.calendar2.Location = new System.Drawing.Point(0, 0);
            this.calendar2.Margin = new System.Windows.Forms.Padding(0);
            this.calendar2.Name = "calendar2";
            this.calendar2.Size = new System.Drawing.Size(316, 362);
            this.calendar2.TabIndex = 0;
            this.calendar2.Value = new System.DateTime(2024, 10, 22, 0, 0, 0, 0);
            this.calendar2.ValueChanged += new System.EventHandler(this.calendar2_ValueChanged);
            // 
            // formVisitDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1260, 615);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVisitDate";
            this.Text = "formVisitDate";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Hourglass.HgScheduler hgScheduler1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private calendar.Calendar calendar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DayButton;
        private System.Windows.Forms.Button MonthButton;
        private System.Windows.Forms.Button WeekButton;
    }
}