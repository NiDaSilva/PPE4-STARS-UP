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
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange1 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange2 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange3 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange4 = new PPE4_Stars_up.CalendarHighlightRange();
            PPE4_Stars_up.CalendarHighlightRange calendarHighlightRange5 = new PPE4_Stars_up.CalendarHighlightRange();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.calendar1 = new PPE4_Stars_up.Calendar();
            this.dGMaj = new System.Windows.Forms.DataGridView();
            this.dataGridViewNbEtoiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPersonnes = new System.Windows.Forms.DataGridView();
            this.monthView1 = new PPE4_Stars_up.MonthView2();
            this.btnRetour = new System.Windows.Forms.Button();
            this.calendar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGMaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNbEtoiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).BeginInit();
            this.monthView1.SuspendLayout();
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
            this.calendar1.Controls.Add(this.dataGridViewNbEtoiles);
            this.calendar1.Controls.Add(this.dataGridViewPersonnes);
            this.calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new PPE4_Stars_up.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(188, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(596, 462);
            this.calendar1.TabIndex = 2;
            this.calendar1.Text = "calendar1";
            this.calendar1.LoadItems += new PPE4_Stars_up.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
            this.calendar1.DayHeaderClick += new PPE4_Stars_up.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
            this.calendar1.ItemCreated += new PPE4_Stars_up.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemCreated);
            this.calendar1.ItemClick += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemClick);
            this.calendar1.ItemDoubleClick += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);
            this.calendar1.ItemMouseHover += new PPE4_Stars_up.Calendar.CalendarItemEventHandler(this.calendar1_ItemMouseHover);
            // 
            // dGMaj
            // 
            this.dGMaj.AllowUserToAddRows = false;
            this.dGMaj.AllowUserToDeleteRows = false;
            this.dGMaj.AllowUserToResizeColumns = false;
            this.dGMaj.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dGMaj.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dGMaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGMaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGMaj.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGMaj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dGMaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGMaj.DefaultCellStyle = dataGridViewCellStyle13;
            this.dGMaj.GridColor = System.Drawing.Color.Black;
            this.dGMaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGMaj.Location = new System.Drawing.Point(-527, 430);
            this.dGMaj.MultiSelect = false;
            this.dGMaj.Name = "dGMaj";
            this.dGMaj.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGMaj.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dGMaj.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dGMaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGMaj.Size = new System.Drawing.Size(578, 229);
            this.dGMaj.TabIndex = 40;
            this.dGMaj.Visible = false;
            // 
            // dataGridViewNbEtoiles
            // 
            this.dataGridViewNbEtoiles.AllowUserToAddRows = false;
            this.dataGridViewNbEtoiles.AllowUserToDeleteRows = false;
            this.dataGridViewNbEtoiles.AllowUserToResizeColumns = false;
            this.dataGridViewNbEtoiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewNbEtoiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNbEtoiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNbEtoiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNbEtoiles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNbEtoiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNbEtoiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNbEtoiles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNbEtoiles.GridColor = System.Drawing.Color.Black;
            this.dataGridViewNbEtoiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewNbEtoiles.Location = new System.Drawing.Point(566, 430);
            this.dataGridViewNbEtoiles.MultiSelect = false;
            this.dataGridViewNbEtoiles.Name = "dataGridViewNbEtoiles";
            this.dataGridViewNbEtoiles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNbEtoiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewNbEtoiles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewNbEtoiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNbEtoiles.Size = new System.Drawing.Size(578, 189);
            this.dataGridViewNbEtoiles.TabIndex = 39;
            this.dataGridViewNbEtoiles.Visible = false;
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
            this.dataGridViewPersonnes.Location = new System.Drawing.Point(557, -188);
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
            this.dataGridViewPersonnes.Size = new System.Drawing.Size(578, 229);
            this.dataGridViewPersonnes.TabIndex = 38;
            this.dataGridViewPersonnes.Visible = false;
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColor = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.monthView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.Controls.Add(this.dGMaj);
            this.monthView1.Controls.Add(this.btnRetour);
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
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(54, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dGMaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNbEtoiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).EndInit();
            this.monthView1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MonthView2 monthView1;
        private System.Windows.Forms.Splitter splitter1;
        private Calendar calendar1;
        private System.Windows.Forms.DataGridView dataGridViewPersonnes;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dataGridViewNbEtoiles;
        private System.Windows.Forms.DataGridView dGMaj;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}