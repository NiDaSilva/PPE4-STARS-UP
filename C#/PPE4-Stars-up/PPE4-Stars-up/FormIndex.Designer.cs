namespace PPE4_Stars_up
{
    partial class FormIndex
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInspecteur = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblinfo2 = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.lblheure = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.vista_wallpaper_aurora_2;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.planningToolStripMenuItem,
            this.historiqueDesVisitesToolStripMenuItem,
            this.imprimerPDFToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.paramètreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // planningToolStripMenuItem
            // 
            this.planningToolStripMenuItem.Enabled = false;
            this.planningToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.planningToolStripMenuItem.Name = "planningToolStripMenuItem";
            this.planningToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.planningToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.planningToolStripMenuItem.Text = "Planning";
            this.planningToolStripMenuItem.Click += new System.EventHandler(this.planningToolStripMenuItem_Click);
            // 
            // historiqueDesVisitesToolStripMenuItem
            // 
            this.historiqueDesVisitesToolStripMenuItem.Enabled = false;
            this.historiqueDesVisitesToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.historiqueDesVisitesToolStripMenuItem.Name = "historiqueDesVisitesToolStripMenuItem";
            this.historiqueDesVisitesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.historiqueDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.historiqueDesVisitesToolStripMenuItem.Text = "Historique des visites";
            this.historiqueDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.historiqueDesVisitesToolStripMenuItem_Click);
            // 
            // imprimerPDFToolStripMenuItem
            // 
            this.imprimerPDFToolStripMenuItem.Enabled = false;
            this.imprimerPDFToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.imprimerPDFToolStripMenuItem.Name = "imprimerPDFToolStripMenuItem";
            this.imprimerPDFToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.imprimerPDFToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.imprimerPDFToolStripMenuItem.Text = "Imprimer PDF";
            this.imprimerPDFToolStripMenuItem.Click += new System.EventHandler(this.imprimerPDFToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quitterToolStripMenuItem.Enabled = false;
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // paramètreToolStripMenuItem
            // 
            this.paramètreToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            this.paramètreToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.paramètreToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.paramètreToolStripMenuItem.Text = "Paramètre";
            // 
            // lblInspecteur
            // 
            this.lblInspecteur.AutoSize = true;
            this.lblInspecteur.BackColor = System.Drawing.Color.Transparent;
            this.lblInspecteur.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecteur.Location = new System.Drawing.Point(175, 440);
            this.lblInspecteur.Name = "lblInspecteur";
            this.lblInspecteur.Size = new System.Drawing.Size(99, 19);
            this.lblInspecteur.TabIndex = 2;
            this.lblInspecteur.Text = "Prénom Nom";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblinfo.Location = new System.Drawing.Point(3, 440);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(166, 20);
            this.lblinfo.TabIndex = 3;
            this.lblinfo.Text = "Connecté en tant que :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 462);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblinfo2
            // 
            this.lblinfo2.AutoSize = true;
            this.lblinfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo2.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblinfo2.Location = new System.Drawing.Point(380, 440);
            this.lblinfo2.Name = "lblinfo2";
            this.lblinfo2.Size = new System.Drawing.Size(86, 20);
            this.lblinfo2.TabIndex = 8;
            this.lblinfo2.Text = "Spécialité :";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialite.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialite.Location = new System.Drawing.Point(475, 440);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(167, 19);
            this.lblSpecialite.TabIndex = 7;
            this.lblSpecialite.Text = "Import données requis";
            // 
            // lblheure
            // 
            this.lblheure.AutoSize = true;
            this.lblheure.BackColor = System.Drawing.Color.Transparent;
            this.lblheure.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheure.Location = new System.Drawing.Point(734, 440);
            this.lblheure.Name = "lblheure";
            this.lblheure.Size = new System.Drawing.Size(61, 19);
            this.lblheure.TabIndex = 9;
            this.lblheure.Text = "HH:mm";
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.lblheure);
            this.Controls.Add(this.lblinfo2);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblInspecteur);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormIndex";
            this.Text = "Accueil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex_FormClosed);
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.Enter += new System.EventHandler(this.FormIndex_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;

        public System.Windows.Forms.MenuStrip MenuStrip1
        {
            get { return menuStrip1; }
            set { menuStrip1 = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planningToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem PlanningToolStripMenuItem
        {
            get { return planningToolStripMenuItem; }
            set { planningToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem historiqueDesVisitesToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem HistoriqueDesVisitesToolStripMenuItem
        {
            get { return historiqueDesVisitesToolStripMenuItem; }
            set { historiqueDesVisitesToolStripMenuItem = value; }
        }

        private System.Windows.Forms.ToolStripMenuItem imprimerPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
        private System.Windows.Forms.Label lblInspecteur;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblinfo2;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.Label lblheure;
    }
}

