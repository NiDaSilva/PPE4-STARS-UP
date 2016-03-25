namespace PPE4_Stars_up
{
    partial class FormHistorique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxHistorique = new System.Windows.Forms.ListBox();
            this.dataGridViewHistorique = new System.Windows.Forms.DataGridView();
            this.pbRetour = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.gbAffichage = new System.Windows.Forms.GroupBox();
            this.rbListe = new System.Windows.Forms.RadioButton();
            this.rbTableau = new System.Windows.Forms.RadioButton();
            this.gbTri = new System.Windows.Forms.GroupBox();
            this.rbTriEtoile = new System.Windows.Forms.RadioButton();
            this.rbTriDepartement = new System.Windows.Forms.RadioButton();
            this.rbTriDate = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.gbAffichage.SuspendLayout();
            this.gbTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Gentium Basic", 28F, System.Drawing.FontStyle.Underline);
            this.lblTitre.Location = new System.Drawing.Point(222, 4);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(354, 44);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Historique des visites";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources._2395551_5_x11_wide_spread_professional_high_res_background_template_layout_that_can_be_used_for_any_kind_of_marketing_material_magazines_articles_scrapbook_and_even_advertisements;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.listBoxHistorique);
            this.panel1.Controls.Add(this.dataGridViewHistorique);
            this.panel1.Location = new System.Drawing.Point(-2, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 305);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBoxHistorique
            // 
            this.listBoxHistorique.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.listBoxHistorique.FormattingEnabled = true;
            this.listBoxHistorique.ItemHeight = 19;
            this.listBoxHistorique.Location = new System.Drawing.Point(89, 12);
            this.listBoxHistorique.Name = "listBoxHistorique";
            this.listBoxHistorique.Size = new System.Drawing.Size(606, 270);
            this.listBoxHistorique.TabIndex = 40;
            // 
            // dataGridViewHistorique
            // 
            this.dataGridViewHistorique.AllowUserToAddRows = false;
            this.dataGridViewHistorique.AllowUserToDeleteRows = false;
            this.dataGridViewHistorique.AllowUserToResizeColumns = false;
            this.dataGridViewHistorique.AllowUserToResizeRows = false;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridViewHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorique.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dataGridViewHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistorique.DefaultCellStyle = dataGridViewCellStyle48;
            this.dataGridViewHistorique.GridColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(89, 12);
            this.dataGridViewHistorique.MultiSelect = false;
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.ReadOnly = true;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorique.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.RowsDefaultCellStyle = dataGridViewCellStyle50;
            this.dataGridViewHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorique.Size = new System.Drawing.Size(606, 281);
            this.dataGridViewHistorique.TabIndex = 39;
            // 
            // pbRetour
            // 
            this.pbRetour.BackColor = System.Drawing.Color.Transparent;
            this.pbRetour.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Fleche_navigation_bleue_gauche;
            this.pbRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRetour.Location = new System.Drawing.Point(3, 4);
            this.pbRetour.Name = "pbRetour";
            this.pbRetour.Size = new System.Drawing.Size(48, 44);
            this.pbRetour.TabIndex = 3;
            this.pbRetour.TabStop = false;
            this.pbRetour.Click += new System.EventHandler(this.pbRetour_Click);
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.Transparent;
            this.pbSave.BackgroundImage = global::PPE4_Stars_up.Properties.Resources._19057_bubka_totalCommander;
            this.pbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSave.Location = new System.Drawing.Point(732, 4);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(48, 44);
            this.pbSave.TabIndex = 4;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // gbAffichage
            // 
            this.gbAffichage.BackColor = System.Drawing.Color.Transparent;
            this.gbAffichage.Controls.Add(this.rbListe);
            this.gbAffichage.Controls.Add(this.rbTableau);
            this.gbAffichage.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbAffichage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbAffichage.Location = new System.Drawing.Point(12, 55);
            this.gbAffichage.Name = "gbAffichage";
            this.gbAffichage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAffichage.Size = new System.Drawing.Size(371, 63);
            this.gbAffichage.TabIndex = 5;
            this.gbAffichage.TabStop = false;
            this.gbAffichage.Text = "Affichage";
            // 
            // rbListe
            // 
            this.rbListe.AutoSize = true;
            this.rbListe.Location = new System.Drawing.Point(217, 25);
            this.rbListe.Name = "rbListe";
            this.rbListe.Size = new System.Drawing.Size(61, 24);
            this.rbListe.TabIndex = 4;
            this.rbListe.Text = "Liste";
            this.rbListe.UseVisualStyleBackColor = true;
            this.rbListe.CheckedChanged += new System.EventHandler(this.rbListe_CheckedChanged);
            this.rbListe.Click += new System.EventHandler(this.rbListe_Click);
            // 
            // rbTableau
            // 
            this.rbTableau.AutoSize = true;
            this.rbTableau.Checked = true;
            this.rbTableau.Location = new System.Drawing.Point(85, 25);
            this.rbTableau.Name = "rbTableau";
            this.rbTableau.Size = new System.Drawing.Size(83, 24);
            this.rbTableau.TabIndex = 3;
            this.rbTableau.TabStop = true;
            this.rbTableau.Text = "Tableau";
            this.rbTableau.UseVisualStyleBackColor = true;
            this.rbTableau.Click += new System.EventHandler(this.rbTableau_Click);
            // 
            // gbTri
            // 
            this.gbTri.BackColor = System.Drawing.Color.Transparent;
            this.gbTri.Controls.Add(this.rbTriEtoile);
            this.gbTri.Controls.Add(this.rbTriDepartement);
            this.gbTri.Controls.Add(this.rbTriDate);
            this.gbTri.Enabled = false;
            this.gbTri.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbTri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbTri.Location = new System.Drawing.Point(401, 55);
            this.gbTri.Name = "gbTri";
            this.gbTri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbTri.Size = new System.Drawing.Size(371, 63);
            this.gbTri.TabIndex = 6;
            this.gbTri.TabStop = false;
            this.gbTri.Text = "Trier par";
            // 
            // rbTriEtoile
            // 
            this.rbTriEtoile.AutoSize = true;
            this.rbTriEtoile.Location = new System.Drawing.Point(264, 25);
            this.rbTriEtoile.Name = "rbTriEtoile";
            this.rbTriEtoile.Size = new System.Drawing.Size(68, 24);
            this.rbTriEtoile.TabIndex = 5;
            this.rbTriEtoile.Text = "Etoile";
            this.rbTriEtoile.UseVisualStyleBackColor = true;
            this.rbTriEtoile.Click += new System.EventHandler(this.rbTriEtoile_Click);
            // 
            // rbTriDepartement
            // 
            this.rbTriDepartement.AutoSize = true;
            this.rbTriDepartement.Location = new System.Drawing.Point(121, 25);
            this.rbTriDepartement.Name = "rbTriDepartement";
            this.rbTriDepartement.Size = new System.Drawing.Size(118, 24);
            this.rbTriDepartement.TabIndex = 4;
            this.rbTriDepartement.Text = "Département";
            this.rbTriDepartement.UseVisualStyleBackColor = true;
            this.rbTriDepartement.Click += new System.EventHandler(this.rbTriDepartement_Click);
            // 
            // rbTriDate
            // 
            this.rbTriDate.AutoSize = true;
            this.rbTriDate.Checked = true;
            this.rbTriDate.Location = new System.Drawing.Point(40, 25);
            this.rbTriDate.Name = "rbTriDate";
            this.rbTriDate.Size = new System.Drawing.Size(59, 24);
            this.rbTriDate.TabIndex = 3;
            this.rbTriDate.TabStop = true;
            this.rbTriDate.Text = "Date";
            this.rbTriDate.UseVisualStyleBackColor = true;
            this.rbTriDate.Click += new System.EventHandler(this.rbTriDate_Click);
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.gbTri);
            this.Controls.Add(this.gbAffichage);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbRetour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormHistorique";
            this.Text = "Historique des visites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHistorique_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.gbAffichage.ResumeLayout(false);
            this.gbAffichage.PerformLayout();
            this.gbTri.ResumeLayout(false);
            this.gbTri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRetour;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridView dataGridViewHistorique;
        private System.Windows.Forms.GroupBox gbAffichage;
        private System.Windows.Forms.RadioButton rbListe;
        private System.Windows.Forms.RadioButton rbTableau;
        private System.Windows.Forms.GroupBox gbTri;
        private System.Windows.Forms.RadioButton rbTriEtoile;
        private System.Windows.Forms.RadioButton rbTriDepartement;
        private System.Windows.Forms.RadioButton rbTriDate;
        private System.Windows.Forms.ListBox listBoxHistorique;
    }
}