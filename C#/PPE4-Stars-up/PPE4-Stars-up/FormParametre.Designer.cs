namespace PPE4_Stars_up
{
    partial class FormParametre
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
            this.lblRedemRequis = new System.Windows.Forms.Label();
            this.cbTutorielNon = new System.Windows.Forms.CheckBox();
            this.cbTutorielOui = new System.Windows.Forms.CheckBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblNbTransparence = new System.Windows.Forms.Label();
            this.hsTransparence = new System.Windows.Forms.HScrollBar();
            this.cbBoiteInputNon = new System.Windows.Forms.CheckBox();
            this.cbBoiteInputOui = new System.Windows.Forms.CheckBox();
            this.lblTutoriel = new System.Windows.Forms.Label();
            this.lblInputBox = new System.Windows.Forms.Label();
            this.lblTitrePara = new System.Windows.Forms.Label();
            this.lblTransparence = new System.Windows.Forms.Label();
            this.lblLangue = new System.Windows.Forms.Label();
            this.combobLangue = new System.Windows.Forms.ComboBox();
            this.lblCouleurAppli = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.pbPalette = new System.Windows.Forms.PictureBox();
            this.pbPara2 = new System.Windows.Forms.PictureBox();
            this.pbPara1 = new System.Windows.Forms.PictureBox();
            this.btnDefaut = new System.Windows.Forms.Button();
            this.lblRedemRequis2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPara2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPara1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRedemRequis
            // 
            this.lblRedemRequis.AutoSize = true;
            this.lblRedemRequis.BackColor = System.Drawing.Color.Transparent;
            this.lblRedemRequis.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Italic);
            this.lblRedemRequis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRedemRequis.Location = new System.Drawing.Point(45, 132);
            this.lblRedemRequis.Name = "lblRedemRequis";
            this.lblRedemRequis.Size = new System.Drawing.Size(510, 20);
            this.lblRedemRequis.TabIndex = 53;
            this.lblRedemRequis.Text = "Redémarrage requis pour que la transparence soit effective sur la globalité de l\'" +
    "application.";
            this.lblRedemRequis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRedemRequis.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbTutorielNon
            // 
            this.cbTutorielNon.AutoSize = true;
            this.cbTutorielNon.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbTutorielNon.Location = new System.Drawing.Point(266, 224);
            this.cbTutorielNon.Name = "cbTutorielNon";
            this.cbTutorielNon.Size = new System.Drawing.Size(62, 27);
            this.cbTutorielNon.TabIndex = 50;
            this.cbTutorielNon.Text = "Non";
            this.cbTutorielNon.UseVisualStyleBackColor = true;
            this.cbTutorielNon.Click += new System.EventHandler(this.cbTutorielNon_Click);
            // 
            // cbTutorielOui
            // 
            this.cbTutorielOui.AutoSize = true;
            this.cbTutorielOui.Checked = true;
            this.cbTutorielOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTutorielOui.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbTutorielOui.Location = new System.Drawing.Point(203, 224);
            this.cbTutorielOui.Name = "cbTutorielOui";
            this.cbTutorielOui.Size = new System.Drawing.Size(57, 27);
            this.cbTutorielOui.TabIndex = 49;
            this.cbTutorielOui.Text = "Oui";
            this.cbTutorielOui.UseVisualStyleBackColor = true;
            this.cbTutorielOui.Click += new System.EventHandler(this.cbTutorielOui_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblPercent.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPercent.Location = new System.Drawing.Point(402, 101);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(24, 23);
            this.lblPercent.TabIndex = 46;
            this.lblPercent.Text = "%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNbTransparence
            // 
            this.lblNbTransparence.AutoSize = true;
            this.lblNbTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblNbTransparence.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblNbTransparence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNbTransparence.Location = new System.Drawing.Point(370, 101);
            this.lblNbTransparence.Name = "lblNbTransparence";
            this.lblNbTransparence.Size = new System.Drawing.Size(37, 23);
            this.lblNbTransparence.TabIndex = 45;
            this.lblNbTransparence.Text = "100";
            this.lblNbTransparence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hsTransparence
            // 
            this.hsTransparence.Location = new System.Drawing.Point(179, 101);
            this.hsTransparence.Maximum = 109;
            this.hsTransparence.Name = "hsTransparence";
            this.hsTransparence.Size = new System.Drawing.Size(170, 23);
            this.hsTransparence.TabIndex = 44;
            this.hsTransparence.Value = 100;
            this.hsTransparence.ValueChanged += new System.EventHandler(this.hsTransparence_ValueChanged);
            // 
            // cbBoiteInputNon
            // 
            this.cbBoiteInputNon.AutoSize = true;
            this.cbBoiteInputNon.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbBoiteInputNon.Location = new System.Drawing.Point(414, 177);
            this.cbBoiteInputNon.Name = "cbBoiteInputNon";
            this.cbBoiteInputNon.Size = new System.Drawing.Size(62, 27);
            this.cbBoiteInputNon.TabIndex = 43;
            this.cbBoiteInputNon.Text = "Non";
            this.cbBoiteInputNon.UseVisualStyleBackColor = true;
            this.cbBoiteInputNon.Click += new System.EventHandler(this.cbBoiteInputNon_Click);
            // 
            // cbBoiteInputOui
            // 
            this.cbBoiteInputOui.AutoSize = true;
            this.cbBoiteInputOui.Checked = true;
            this.cbBoiteInputOui.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoiteInputOui.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.cbBoiteInputOui.Location = new System.Drawing.Point(351, 177);
            this.cbBoiteInputOui.Name = "cbBoiteInputOui";
            this.cbBoiteInputOui.Size = new System.Drawing.Size(57, 27);
            this.cbBoiteInputOui.TabIndex = 42;
            this.cbBoiteInputOui.Text = "Oui";
            this.cbBoiteInputOui.UseVisualStyleBackColor = true;
            this.cbBoiteInputOui.CheckedChanged += new System.EventHandler(this.cbBoiteInputOui_CheckedChanged);
            this.cbBoiteInputOui.Click += new System.EventHandler(this.cbBoiteInputOui_Click);
            // 
            // lblTutoriel
            // 
            this.lblTutoriel.AutoSize = true;
            this.lblTutoriel.BackColor = System.Drawing.Color.Transparent;
            this.lblTutoriel.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblTutoriel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTutoriel.Location = new System.Drawing.Point(29, 224);
            this.lblTutoriel.Name = "lblTutoriel";
            this.lblTutoriel.Size = new System.Drawing.Size(143, 23);
            this.lblTutoriel.TabIndex = 41;
            this.lblTutoriel.Text = "Afficher Tutoriel :";
            this.lblTutoriel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInputBox
            // 
            this.lblInputBox.AutoSize = true;
            this.lblInputBox.BackColor = System.Drawing.Color.Transparent;
            this.lblInputBox.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblInputBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInputBox.Location = new System.Drawing.Point(29, 177);
            this.lblInputBox.Name = "lblInputBox";
            this.lblInputBox.Size = new System.Drawing.Size(285, 23);
            this.lblInputBox.TabIndex = 39;
            this.lblInputBox.Text = "Afficher les fenêtres de chargement :";
            this.lblInputBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitrePara
            // 
            this.lblTitrePara.AutoSize = true;
            this.lblTitrePara.BackColor = System.Drawing.Color.Transparent;
            this.lblTitrePara.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePara.Location = new System.Drawing.Point(235, 13);
            this.lblTitrePara.Name = "lblTitrePara";
            this.lblTitrePara.Size = new System.Drawing.Size(166, 39);
            this.lblTitrePara.TabIndex = 38;
            this.lblTitrePara.Text = "Paramètres";
            this.lblTitrePara.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransparence
            // 
            this.lblTransparence.AutoSize = true;
            this.lblTransparence.BackColor = System.Drawing.Color.Transparent;
            this.lblTransparence.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblTransparence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTransparence.Location = new System.Drawing.Point(29, 101);
            this.lblTransparence.Name = "lblTransparence";
            this.lblTransparence.Size = new System.Drawing.Size(123, 23);
            this.lblTransparence.TabIndex = 37;
            this.lblTransparence.Text = "Transparence :";
            this.lblTransparence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLangue
            // 
            this.lblLangue.AutoSize = true;
            this.lblLangue.BackColor = System.Drawing.Color.Transparent;
            this.lblLangue.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblLangue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLangue.Location = new System.Drawing.Point(29, 269);
            this.lblLangue.Name = "lblLangue";
            this.lblLangue.Size = new System.Drawing.Size(74, 23);
            this.lblLangue.TabIndex = 54;
            this.lblLangue.Text = "Langue :";
            this.lblLangue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combobLangue
            // 
            this.combobLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobLangue.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobLangue.FormattingEnabled = true;
            this.combobLangue.Items.AddRange(new object[] {
            "Francais",
            "Anglais",
            "Allemand",
            "Espagnol"});
            this.combobLangue.Location = new System.Drawing.Point(124, 269);
            this.combobLangue.Name = "combobLangue";
            this.combobLangue.Size = new System.Drawing.Size(135, 26);
            this.combobLangue.TabIndex = 55;
            this.combobLangue.SelectedIndexChanged += new System.EventHandler(this.combobLangue_SelectedIndexChanged);
            // 
            // lblCouleurAppli
            // 
            this.lblCouleurAppli.AutoSize = true;
            this.lblCouleurAppli.BackColor = System.Drawing.Color.Transparent;
            this.lblCouleurAppli.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.lblCouleurAppli.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCouleurAppli.Location = new System.Drawing.Point(29, 316);
            this.lblCouleurAppli.Name = "lblCouleurAppli";
            this.lblCouleurAppli.Size = new System.Drawing.Size(199, 23);
            this.lblCouleurAppli.TabIndex = 56;
            this.lblCouleurAppli.Text = "Couleur de l\'application :";
            this.lblCouleurAppli.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.BackColor = System.Drawing.Color.Transparent;
            this.lblCouleur.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCouleur.Location = new System.Drawing.Point(300, 317);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(86, 22);
            this.lblCouleur.TabIndex = 58;
            this.lblCouleur.Text = "Par défaut";
            this.lblCouleur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPalette
            // 
            this.pbPalette.BackColor = System.Drawing.SystemColors.Control;
            this.pbPalette.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.colorwheel;
            this.pbPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPalette.Location = new System.Drawing.Point(271, 319);
            this.pbPalette.Name = "pbPalette";
            this.pbPalette.Size = new System.Drawing.Size(20, 20);
            this.pbPalette.TabIndex = 57;
            this.pbPalette.TabStop = false;
            this.pbPalette.Click += new System.EventHandler(this.pbPalette_Click);
            // 
            // pbPara2
            // 
            this.pbPara2.Image = global::PPE4_Stars_up.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            this.pbPara2.Location = new System.Drawing.Point(1, 370);
            this.pbPara2.Name = "pbPara2";
            this.pbPara2.Size = new System.Drawing.Size(643, 2);
            this.pbPara2.TabIndex = 52;
            this.pbPara2.TabStop = false;
            // 
            // pbPara1
            // 
            this.pbPara1.Image = global::PPE4_Stars_up.Properties.Resources.honeycomb_grey_pattern_wallpapers;
            this.pbPara1.Location = new System.Drawing.Point(2, 65);
            this.pbPara1.Name = "pbPara1";
            this.pbPara1.Size = new System.Drawing.Size(643, 2);
            this.pbPara1.TabIndex = 51;
            this.pbPara1.TabStop = false;
            // 
            // btnDefaut
            // 
            this.btnDefaut.Font = new System.Drawing.Font("Palatino Linotype", 12.25F);
            this.btnDefaut.Location = new System.Drawing.Point(229, 313);
            this.btnDefaut.Name = "btnDefaut";
            this.btnDefaut.Size = new System.Drawing.Size(30, 30);
            this.btnDefaut.TabIndex = 59;
            this.btnDefaut.Text = "↻";
            this.btnDefaut.UseVisualStyleBackColor = true;
            this.btnDefaut.Click += new System.EventHandler(this.btnDefaut_Click);
            // 
            // lblRedemRequis2
            // 
            this.lblRedemRequis2.AutoSize = true;
            this.lblRedemRequis2.BackColor = System.Drawing.Color.Transparent;
            this.lblRedemRequis2.Font = new System.Drawing.Font("Palatino Linotype", 10.25F, System.Drawing.FontStyle.Italic);
            this.lblRedemRequis2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRedemRequis2.Location = new System.Drawing.Point(45, 346);
            this.lblRedemRequis2.Name = "lblRedemRequis2";
            this.lblRedemRequis2.Size = new System.Drawing.Size(479, 20);
            this.lblRedemRequis2.TabIndex = 60;
            this.lblRedemRequis2.Text = "Redémarrage requis pour que la couleur soit effective sur la globalité de l\'appli" +
    "cation.";
            this.lblRedemRequis2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 404);
            this.Controls.Add(this.lblRedemRequis2);
            this.Controls.Add(this.btnDefaut);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.pbPalette);
            this.Controls.Add(this.lblCouleurAppli);
            this.Controls.Add(this.combobLangue);
            this.Controls.Add(this.lblLangue);
            this.Controls.Add(this.lblRedemRequis);
            this.Controls.Add(this.pbPara2);
            this.Controls.Add(this.pbPara1);
            this.Controls.Add(this.cbTutorielNon);
            this.Controls.Add(this.cbTutorielOui);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblNbTransparence);
            this.Controls.Add(this.hsTransparence);
            this.Controls.Add(this.cbBoiteInputNon);
            this.Controls.Add(this.cbBoiteInputOui);
            this.Controls.Add(this.lblTutoriel);
            this.Controls.Add(this.lblInputBox);
            this.Controls.Add(this.lblTitrePara);
            this.Controls.Add(this.lblTransparence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParametre";
            this.ShowIcon = false;
            this.Text = "Paramètres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormParametre_FormClosed);
            this.Load += new System.EventHandler(this.FormParametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPara2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPara1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRedemRequis;
        private System.Windows.Forms.PictureBox pbPara2;
        private System.Windows.Forms.PictureBox pbPara1;
        private System.Windows.Forms.CheckBox cbTutorielNon;
        private System.Windows.Forms.CheckBox cbTutorielOui;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblNbTransparence;
        private System.Windows.Forms.HScrollBar hsTransparence;
        private System.Windows.Forms.CheckBox cbBoiteInputNon;
        private System.Windows.Forms.CheckBox cbBoiteInputOui;
        private System.Windows.Forms.Label lblTutoriel;
        private System.Windows.Forms.Label lblInputBox;
        private System.Windows.Forms.Label lblTitrePara;
        private System.Windows.Forms.Label lblTransparence;
        private System.Windows.Forms.Label lblLangue;
        private System.Windows.Forms.ComboBox combobLangue;
        private System.Windows.Forms.Label lblCouleurAppli;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox pbPalette;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Button btnDefaut;
        private System.Windows.Forms.Label lblRedemRequis2;
    }
}