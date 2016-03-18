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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRetour = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.dataGridViewHistorique = new System.Windows.Forms.DataGridView();
            this.gbInformations = new System.Windows.Forms.GroupBox();
            this.rbListe = new System.Windows.Forms.RadioButton();
            this.rbTableau = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).BeginInit();
            this.gbInformations.SuspendLayout();
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
            this.panel1.Controls.Add(this.dataGridViewHistorique);
            this.panel1.Location = new System.Drawing.Point(-2, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 305);
            this.panel1.TabIndex = 2;
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
            // dataGridViewHistorique
            // 
            this.dataGridViewHistorique.AllowUserToAddRows = false;
            this.dataGridViewHistorique.AllowUserToDeleteRows = false;
            this.dataGridViewHistorique.AllowUserToResizeColumns = false;
            this.dataGridViewHistorique.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorique.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorique.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistorique.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewHistorique.GridColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewHistorique.Location = new System.Drawing.Point(89, 12);
            this.dataGridViewHistorique.MultiSelect = false;
            this.dataGridViewHistorique.Name = "dataGridViewHistorique";
            this.dataGridViewHistorique.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistorique.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewHistorique.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewHistorique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistorique.Size = new System.Drawing.Size(606, 281);
            this.dataGridViewHistorique.TabIndex = 39;
            // 
            // gbInformations
            // 
            this.gbInformations.BackColor = System.Drawing.Color.Transparent;
            this.gbInformations.Controls.Add(this.rbListe);
            this.gbInformations.Controls.Add(this.rbTableau);
            this.gbInformations.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.gbInformations.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbInformations.Location = new System.Drawing.Point(207, 55);
            this.gbInformations.Name = "gbInformations";
            this.gbInformations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbInformations.Size = new System.Drawing.Size(371, 63);
            this.gbInformations.TabIndex = 5;
            this.gbInformations.TabStop = false;
            this.gbInformations.Text = "Affichage";
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
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.gbInformations);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbRetour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormHistorique";
            this.Text = "Historique des visites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHistorique_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorique)).EndInit();
            this.gbInformations.ResumeLayout(false);
            this.gbInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRetour;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.DataGridView dataGridViewHistorique;
        private System.Windows.Forms.GroupBox gbInformations;
        private System.Windows.Forms.RadioButton rbListe;
        private System.Windows.Forms.RadioButton rbTableau;
    }
}