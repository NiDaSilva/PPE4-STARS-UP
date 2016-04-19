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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
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
            this.timerHHmm = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.pbFrance = new System.Windows.Forms.PictureBox();
            this.pbAngleterre = new System.Windows.Forms.PictureBox();
            this.pbAllemagne = new System.Windows.Forms.PictureBox();
            this.lblInfoNbVisiteTotal = new System.Windows.Forms.Label();
            this.lbldont = new System.Windows.Forms.Label();
            this.lblNbVisiteTotal = new System.Windows.Forms.Label();
            this.lblNbVisitePassees = new System.Windows.Forms.Label();
            this.lblTiret = new System.Windows.Forms.Label();
            this.lblPassees = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTiret2 = new System.Windows.Forms.Label();
            this.lblNbVisiteToday = new System.Windows.Forms.Label();
            this.lblPasseeNonEvaluee = new System.Windows.Forms.Label();
            this.lblNbVisitePasseeNonRemplie = new System.Windows.Forms.Label();
            this.lblPrevue = new System.Windows.Forms.Label();
            this.lblTiret4 = new System.Windows.Forms.Label();
            this.lblNbVisitePrevue = new System.Windows.Forms.Label();
            this.pbEspagne = new System.Windows.Forms.PictureBox();
            this.pbParametre = new System.Windows.Forms.PictureBox();
            this.pbPDP = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngleterre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllemagne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspagne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParametre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDP)).BeginInit();
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
            this.paramètreToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.paramètreToolStripMenuItem.Text = "Paramètres";
            this.paramètreToolStripMenuItem.Click += new System.EventHandler(this.paramètreToolStripMenuItem_Click);
            // 
            // lblInspecteur
            // 
            this.lblInspecteur.AutoSize = true;
            this.lblInspecteur.BackColor = System.Drawing.Color.Transparent;
            this.lblInspecteur.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecteur.Location = new System.Drawing.Point(175, 440);
            this.lblInspecteur.Name = "lblInspecteur";
            this.lblInspecteur.Size = new System.Drawing.Size(167, 19);
            this.lblInspecteur.TabIndex = 2;
            this.lblInspecteur.Text = "Import données requis";
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
            this.lblheure.Location = new System.Drawing.Point(647, 66);
            this.lblheure.Name = "lblheure";
            this.lblheure.Size = new System.Drawing.Size(52, 19);
            this.lblheure.TabIndex = 9;
            this.lblheure.Text = "Heure";
            // 
            // timerHHmm
            // 
            this.timerHHmm.Interval = 1000;
            this.timerHHmm.Tick += new System.EventHandler(this.timerHHmm_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(3, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // pbFrance
            // 
            this.pbFrance.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.france;
            this.pbFrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFrance.Location = new System.Drawing.Point(648, 40);
            this.pbFrance.Name = "pbFrance";
            this.pbFrance.Size = new System.Drawing.Size(30, 15);
            this.pbFrance.TabIndex = 12;
            this.pbFrance.TabStop = false;
            this.pbFrance.Click += new System.EventHandler(this.pbFrance_Click);
            // 
            // pbAngleterre
            // 
            this.pbAngleterre.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.angleterre;
            this.pbAngleterre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAngleterre.Location = new System.Drawing.Point(680, 40);
            this.pbAngleterre.Name = "pbAngleterre";
            this.pbAngleterre.Size = new System.Drawing.Size(30, 15);
            this.pbAngleterre.TabIndex = 14;
            this.pbAngleterre.TabStop = false;
            this.pbAngleterre.Click += new System.EventHandler(this.pbAngleterre_Click);
            // 
            // pbAllemagne
            // 
            this.pbAllemagne.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.allemagne;
            this.pbAllemagne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAllemagne.Location = new System.Drawing.Point(712, 40);
            this.pbAllemagne.Name = "pbAllemagne";
            this.pbAllemagne.Size = new System.Drawing.Size(30, 15);
            this.pbAllemagne.TabIndex = 16;
            this.pbAllemagne.TabStop = false;
            this.pbAllemagne.Click += new System.EventHandler(this.pbAllemagne_Click);
            // 
            // lblInfoNbVisiteTotal
            // 
            this.lblInfoNbVisiteTotal.AutoSize = true;
            this.lblInfoNbVisiteTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoNbVisiteTotal.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblInfoNbVisiteTotal.Location = new System.Drawing.Point(3, 106);
            this.lblInfoNbVisiteTotal.Name = "lblInfoNbVisiteTotal";
            this.lblInfoNbVisiteTotal.Size = new System.Drawing.Size(230, 20);
            this.lblInfoNbVisiteTotal.TabIndex = 18;
            this.lblInfoNbVisiteTotal.Text = "Vous êtes et avez été assigné à ";
            // 
            // lbldont
            // 
            this.lbldont.AutoSize = true;
            this.lbldont.BackColor = System.Drawing.Color.Transparent;
            this.lbldont.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lbldont.Location = new System.Drawing.Point(257, 106);
            this.lbldont.Name = "lbldont";
            this.lbldont.Size = new System.Drawing.Size(100, 20);
            this.lbldont.TabIndex = 19;
            this.lbldont.Text = "visites dont :";
            // 
            // lblNbVisiteTotal
            // 
            this.lblNbVisiteTotal.AutoSize = true;
            this.lblNbVisiteTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblNbVisiteTotal.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisiteTotal.Location = new System.Drawing.Point(230, 107);
            this.lblNbVisiteTotal.Name = "lblNbVisiteTotal";
            this.lblNbVisiteTotal.Size = new System.Drawing.Size(23, 19);
            this.lblNbVisiteTotal.TabIndex = 20;
            this.lblNbVisiteTotal.Text = "??";
            // 
            // lblNbVisitePassees
            // 
            this.lblNbVisitePassees.AutoSize = true;
            this.lblNbVisitePassees.BackColor = System.Drawing.Color.Transparent;
            this.lblNbVisitePassees.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisitePassees.Location = new System.Drawing.Point(22, 177);
            this.lblNbVisitePassees.Name = "lblNbVisitePassees";
            this.lblNbVisitePassees.Size = new System.Drawing.Size(23, 19);
            this.lblNbVisitePassees.TabIndex = 21;
            this.lblNbVisitePassees.Text = "??";
            // 
            // lblTiret
            // 
            this.lblTiret.AutoSize = true;
            this.lblTiret.BackColor = System.Drawing.Color.Transparent;
            this.lblTiret.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblTiret.Location = new System.Drawing.Point(12, 177);
            this.lblTiret.Name = "lblTiret";
            this.lblTiret.Size = new System.Drawing.Size(15, 20);
            this.lblTiret.TabIndex = 22;
            this.lblTiret.Text = "-";
            // 
            // lblPassees
            // 
            this.lblPassees.AutoSize = true;
            this.lblPassees.BackColor = System.Drawing.Color.Transparent;
            this.lblPassees.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblPassees.Location = new System.Drawing.Point(51, 176);
            this.lblPassees.Name = "lblPassees";
            this.lblPassees.Size = new System.Drawing.Size(134, 20);
            this.lblPassees.TabIndex = 23;
            this.lblPassees.Text = "sont passées mais";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblToday.Location = new System.Drawing.Point(51, 143);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(190, 20);
            this.lblToday.TabIndex = 27;
            this.lblToday.Text = "sont prévues aujourd\'hui.";
            // 
            // lblTiret2
            // 
            this.lblTiret2.AutoSize = true;
            this.lblTiret2.BackColor = System.Drawing.Color.Transparent;
            this.lblTiret2.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblTiret2.Location = new System.Drawing.Point(12, 144);
            this.lblTiret2.Name = "lblTiret2";
            this.lblTiret2.Size = new System.Drawing.Size(15, 20);
            this.lblTiret2.TabIndex = 26;
            this.lblTiret2.Text = "-";
            // 
            // lblNbVisiteToday
            // 
            this.lblNbVisiteToday.AutoSize = true;
            this.lblNbVisiteToday.BackColor = System.Drawing.Color.Transparent;
            this.lblNbVisiteToday.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisiteToday.Location = new System.Drawing.Point(22, 144);
            this.lblNbVisiteToday.Name = "lblNbVisiteToday";
            this.lblNbVisiteToday.Size = new System.Drawing.Size(23, 19);
            this.lblNbVisiteToday.TabIndex = 25;
            this.lblNbVisiteToday.Text = "??";
            // 
            // lblPasseeNonEvaluee
            // 
            this.lblPasseeNonEvaluee.AutoSize = true;
            this.lblPasseeNonEvaluee.BackColor = System.Drawing.Color.Transparent;
            this.lblPasseeNonEvaluee.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblPasseeNonEvaluee.Location = new System.Drawing.Point(217, 176);
            this.lblPasseeNonEvaluee.Name = "lblPasseeNonEvaluee";
            this.lblPasseeNonEvaluee.Size = new System.Drawing.Size(145, 20);
            this.lblPasseeNonEvaluee.TabIndex = 30;
            this.lblPasseeNonEvaluee.Text = "reste non évaluées.";
            // 
            // lblNbVisitePasseeNonRemplie
            // 
            this.lblNbVisitePasseeNonRemplie.AutoSize = true;
            this.lblNbVisitePasseeNonRemplie.BackColor = System.Drawing.Color.Transparent;
            this.lblNbVisitePasseeNonRemplie.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisitePasseeNonRemplie.Location = new System.Drawing.Point(188, 177);
            this.lblNbVisitePasseeNonRemplie.Name = "lblNbVisitePasseeNonRemplie";
            this.lblNbVisitePasseeNonRemplie.Size = new System.Drawing.Size(23, 19);
            this.lblNbVisitePasseeNonRemplie.TabIndex = 28;
            this.lblNbVisitePasseeNonRemplie.Text = "??";
            // 
            // lblPrevue
            // 
            this.lblPrevue.AutoSize = true;
            this.lblPrevue.BackColor = System.Drawing.Color.Transparent;
            this.lblPrevue.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblPrevue.Location = new System.Drawing.Point(51, 210);
            this.lblPrevue.Name = "lblPrevue";
            this.lblPrevue.Size = new System.Drawing.Size(258, 20);
            this.lblPrevue.TabIndex = 33;
            this.lblPrevue.Text = "sont prévues dans les jours à venir.";
            // 
            // lblTiret4
            // 
            this.lblTiret4.AutoSize = true;
            this.lblTiret4.BackColor = System.Drawing.Color.Transparent;
            this.lblTiret4.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblTiret4.Location = new System.Drawing.Point(12, 211);
            this.lblTiret4.Name = "lblTiret4";
            this.lblTiret4.Size = new System.Drawing.Size(15, 20);
            this.lblTiret4.TabIndex = 32;
            this.lblTiret4.Text = "-";
            // 
            // lblNbVisitePrevue
            // 
            this.lblNbVisitePrevue.AutoSize = true;
            this.lblNbVisitePrevue.BackColor = System.Drawing.Color.Transparent;
            this.lblNbVisitePrevue.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbVisitePrevue.Location = new System.Drawing.Point(22, 211);
            this.lblNbVisitePrevue.Name = "lblNbVisitePrevue";
            this.lblNbVisitePrevue.Size = new System.Drawing.Size(23, 19);
            this.lblNbVisitePrevue.TabIndex = 31;
            this.lblNbVisitePrevue.Text = "??";
            // 
            // pbEspagne
            // 
            this.pbEspagne.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.espagne;
            this.pbEspagne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEspagne.Location = new System.Drawing.Point(744, 40);
            this.pbEspagne.Name = "pbEspagne";
            this.pbEspagne.Size = new System.Drawing.Size(30, 15);
            this.pbEspagne.TabIndex = 35;
            this.pbEspagne.TabStop = false;
            this.pbEspagne.Click += new System.EventHandler(this.pbEspagne_Click);
            // 
            // pbParametre
            // 
            this.pbParametre.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.tool;
            this.pbParametre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbParametre.Location = new System.Drawing.Point(744, 61);
            this.pbParametre.Name = "pbParametre";
            this.pbParametre.Size = new System.Drawing.Size(30, 30);
            this.pbParametre.TabIndex = 37;
            this.pbParametre.TabStop = false;
            this.pbParametre.Click += new System.EventHandler(this.pbParametre_Click);
            // 
            // pbPDP
            // 
            this.pbPDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPDP.ImageLocation = "";
            this.pbPDP.Location = new System.Drawing.Point(712, 356);
            this.pbPDP.Name = "pbPDP";
            this.pbPDP.Size = new System.Drawing.Size(56, 100);
            this.pbPDP.TabIndex = 39;
            this.pbPDP.TabStop = false;
            this.pbPDP.Visible = false;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pbPDP);
            this.Controls.Add(this.pbParametre);
            this.Controls.Add(this.pbEspagne);
            this.Controls.Add(this.lblPrevue);
            this.Controls.Add(this.lblTiret4);
            this.Controls.Add(this.lblNbVisitePrevue);
            this.Controls.Add(this.lblPasseeNonEvaluee);
            this.Controls.Add(this.lblNbVisitePasseeNonRemplie);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblTiret2);
            this.Controls.Add(this.lblNbVisiteToday);
            this.Controls.Add(this.lblPassees);
            this.Controls.Add(this.lblTiret);
            this.Controls.Add(this.lblNbVisitePassees);
            this.Controls.Add(this.lblNbVisiteTotal);
            this.Controls.Add(this.lbldont);
            this.Controls.Add(this.lblInfoNbVisiteTotal);
            this.Controls.Add(this.pbAllemagne);
            this.Controls.Add(this.pbAngleterre);
            this.Controls.Add(this.pbFrance);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblheure);
            this.Controls.Add(this.lblinfo2);
            this.Controls.Add(this.lblSpecialite);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblInspecteur);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormIndex";
            this.Text = "Accueil";
            this.Activated += new System.EventHandler(this.FormIndex_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIndex_FormClosed);
            this.Load += new System.EventHandler(this.FormIndex_Load);
            this.Enter += new System.EventHandler(this.FormIndex_Enter);
            this.MouseHover += new System.EventHandler(this.FormIndex_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAngleterre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAllemagne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEspagne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParametre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDP)).EndInit();
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
        private System.Windows.Forms.Timer timerHHmm;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pbFrance;
        private System.Windows.Forms.PictureBox pbAngleterre;
        private System.Windows.Forms.PictureBox pbAllemagne;
        private System.Windows.Forms.Label lblInfoNbVisiteTotal;
        private System.Windows.Forms.Label lbldont;
        private System.Windows.Forms.Label lblNbVisiteTotal;
        private System.Windows.Forms.Label lblNbVisitePassees;
        private System.Windows.Forms.Label lblTiret;
        private System.Windows.Forms.Label lblPassees;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTiret2;
        private System.Windows.Forms.Label lblNbVisiteToday;
        private System.Windows.Forms.Label lblPasseeNonEvaluee;
        private System.Windows.Forms.Label lblNbVisitePasseeNonRemplie;
        private System.Windows.Forms.Label lblPrevue;
        private System.Windows.Forms.Label lblTiret4;
        private System.Windows.Forms.Label lblNbVisitePrevue;
        private System.Windows.Forms.PictureBox pbEspagne;
        private System.Windows.Forms.PictureBox pbParametre;
        private System.Windows.Forms.PictureBox pbPDP;
    }
}

