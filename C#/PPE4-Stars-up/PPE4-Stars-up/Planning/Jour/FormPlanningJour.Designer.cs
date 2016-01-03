namespace PPE4_Stars_up
{
    partial class FormPlanningJour
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
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange6 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange7 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange8 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange9 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange10 = new PPE4_Stars_up.CalendarHighlightRange();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.calendar1 = new PPE4_Stars_up.Calendar();
            this.dataGridViewPersonnes = new System.Windows.Forms.DataGridView();
            this.monthView1 = new PPE4_Stars_up.MonthView2();
            this.calendar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(185, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 462);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // calendar1
            // 
            this.calendar1.Controls.Add(this.dataGridViewPersonnes);
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new PPE4_Stars_up.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.calendar1.Location = new System.Drawing.Point(188, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(596, 462);
            this.calendar1.TabIndex = 2;
            this.calendar1.Text = "calendar1";
            this.calendar1.LoadItems += new PPE4_Stars_up.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
            this.calendar1.DayHeaderClick += new PPE4_Stars_up.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
            this.calendar1.ItemCreated += new PPE4_Stars_up.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemCreated);
            this.calendar1.ItemDeleted += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemDeleted);
            this.calendar1.ItemClick += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemClick);
            this.calendar1.ItemDoubleClick += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);
            this.calendar1.ItemMouseHover += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemMouseHover);
            // 
            // dataGridViewPersonnes
            // 
            this.dataGridViewPersonnes.AllowUserToAddRows = false;
            this.dataGridViewPersonnes.AllowUserToDeleteRows = false;
            this.dataGridViewPersonnes.AllowUserToResizeColumns = false;
            this.dataGridViewPersonnes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPersonnes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPersonnes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonnes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonnes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPersonnes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPersonnes.GridColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewPersonnes.Location = new System.Drawing.Point(68, 73);
            this.dataGridViewPersonnes.MultiSelect = false;
            this.dataGridViewPersonnes.Name = "dataGridViewPersonnes";
            this.dataGridViewPersonnes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonnes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPersonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonnes.Size = new System.Drawing.Size(491, 364);
            this.dataGridViewPersonnes.TabIndex = 38;
            this.dataGridViewPersonnes.Visible = false;
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColor = System.Drawing.Color.Transparent;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.monthView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(0, 0);
            this.monthView1.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(185, 462);
            this.monthView1.TabIndex = 0;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColor = System.Drawing.Color.Maroon;
            this.monthView1.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // FormPlanningJour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.monthView1);
            this.Name = "FormPlanningJour";
            this.Text = "Planning - Jour";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPlanningJour_Load);
            this.calendar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthView2 monthView1;
        private System.Windows.Forms.Splitter splitter1;
        private Calendar calendar1;
        private System.Windows.Forms.DataGridView dataGridViewPersonnes;
    }
}