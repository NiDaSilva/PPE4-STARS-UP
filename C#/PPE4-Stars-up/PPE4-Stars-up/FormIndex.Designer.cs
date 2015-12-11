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
            this.jourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.planningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jourToolStripMenuItem,
            this.semaineToolStripMenuItem});
            this.planningToolStripMenuItem.Enabled = false;
            this.planningToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.planningToolStripMenuItem.Name = "planningToolStripMenuItem";
            this.planningToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.planningToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.planningToolStripMenuItem.Text = "Planning";
            // 
            // jourToolStripMenuItem
            // 
            this.jourToolStripMenuItem.Name = "jourToolStripMenuItem";
            this.jourToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.jourToolStripMenuItem.Text = "Jour";
            this.jourToolStripMenuItem.Click += new System.EventHandler(this.jourToolStripMenuItem_Click);
            // 
            // semaineToolStripMenuItem
            // 
            this.semaineToolStripMenuItem.Name = "semaineToolStripMenuItem";
            this.semaineToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.semaineToolStripMenuItem.Text = "Semaine";
            // 
            // historiqueDesVisitesToolStripMenuItem
            // 
            this.historiqueDesVisitesToolStripMenuItem.Enabled = false;
            this.historiqueDesVisitesToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.historiqueDesVisitesToolStripMenuItem.Name = "historiqueDesVisitesToolStripMenuItem";
            this.historiqueDesVisitesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.historiqueDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.historiqueDesVisitesToolStripMenuItem.Text = "Historique des visites";
            // 
            // imprimerPDFToolStripMenuItem
            // 
            this.imprimerPDFToolStripMenuItem.Enabled = false;
            this.imprimerPDFToolStripMenuItem.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.imprimerPDFToolStripMenuItem.Name = "imprimerPDFToolStripMenuItem";
            this.imprimerPDFToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 4, 0);
            this.imprimerPDFToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.imprimerPDFToolStripMenuItem.Text = "Imprimer PDF";
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
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormIndex";
            this.Text = "Accueil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex_FormClosed);
            this.Enter += new System.EventHandler(this.FormIndex_Enter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDesVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
    }
}

