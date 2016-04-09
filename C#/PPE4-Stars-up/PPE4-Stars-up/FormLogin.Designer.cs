namespace PPE4_Stars_up
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbAfficherMdp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCorrect1 = new System.Windows.Forms.PictureBox();
            this.pbCorrect2 = new System.Windows.Forms.PictureBox();
            this.pbIncorrect2 = new System.Windows.Forms.PictureBox();
            this.pbIncorrect1 = new System.Windows.Forms.PictureBox();
            this.lbLogin = new System.Windows.Forms.ListBox();
            this.lbMdp = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.tbNom.ForeColor = System.Drawing.Color.Gray;
            this.tbNom.Location = new System.Drawing.Point(125, 46);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(164, 29);
            this.tbNom.TabIndex = 0;
            this.tbNom.Text = "Nom";
            this.tbNom.Click += new System.EventHandler(this.tbNom_Click);
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNom_KeyDown);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // tbMdp
            // 
            this.tbMdp.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.tbMdp.ForeColor = System.Drawing.Color.Gray;
            this.tbMdp.Location = new System.Drawing.Point(125, 105);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(164, 29);
            this.tbMdp.TabIndex = 1;
            this.tbMdp.Text = "Mot de passe";
            this.tbMdp.Click += new System.EventHandler(this.tbMdp_Click);
            this.tbMdp.TextChanged += new System.EventHandler(this.tbMdp_TextChanged);
            this.tbMdp.Enter += new System.EventHandler(this.tbMdp_Enter);
            this.tbMdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMdp_KeyDown);
            this.tbMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMdp_KeyPress);
            this.tbMdp.Leave += new System.EventHandler(this.tbMdp_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.btnOK.Location = new System.Drawing.Point(139, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 33);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Se connecter";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // cbAfficherMdp
            // 
            this.cbAfficherMdp.AutoSize = true;
            this.cbAfficherMdp.BackColor = System.Drawing.Color.Transparent;
            this.cbAfficherMdp.Font = new System.Drawing.Font("Gentium Basic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAfficherMdp.Location = new System.Drawing.Point(101, 141);
            this.cbAfficherMdp.Name = "cbAfficherMdp";
            this.cbAfficherMdp.Size = new System.Drawing.Size(209, 21);
            this.cbAfficherMdp.TabIndex = 4;
            this.cbAfficherMdp.Text = "Afficher / Cacher le mot de passe";
            this.cbAfficherMdp.UseVisualStyleBackColor = false;
            this.cbAfficherMdp.CheckedChanged += new System.EventHandler(this.cbAfficherMdp_CheckedChanged);
            this.cbAfficherMdp.Click += new System.EventHandler(this.cbAfficherMdp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources._15679_babasse_cadenas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbCorrect1
            // 
            this.pbCorrect1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Accept_icon;
            this.pbCorrect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCorrect1.Location = new System.Drawing.Point(267, 54);
            this.pbCorrect1.Name = "pbCorrect1";
            this.pbCorrect1.Size = new System.Drawing.Size(16, 16);
            this.pbCorrect1.TabIndex = 11;
            this.pbCorrect1.TabStop = false;
            this.pbCorrect1.Visible = false;
            // 
            // pbCorrect2
            // 
            this.pbCorrect2.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Accept_icon;
            this.pbCorrect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCorrect2.Location = new System.Drawing.Point(267, 113);
            this.pbCorrect2.Name = "pbCorrect2";
            this.pbCorrect2.Size = new System.Drawing.Size(16, 16);
            this.pbCorrect2.TabIndex = 12;
            this.pbCorrect2.TabStop = false;
            this.pbCorrect2.Visible = false;
            // 
            // pbIncorrect2
            // 
            this.pbIncorrect2.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Erreur_icon;
            this.pbIncorrect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbIncorrect2.Location = new System.Drawing.Point(267, 113);
            this.pbIncorrect2.Name = "pbIncorrect2";
            this.pbIncorrect2.Size = new System.Drawing.Size(16, 16);
            this.pbIncorrect2.TabIndex = 13;
            this.pbIncorrect2.TabStop = false;
            this.pbIncorrect2.Visible = false;
            // 
            // pbIncorrect1
            // 
            this.pbIncorrect1.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.Erreur_icon;
            this.pbIncorrect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbIncorrect1.Location = new System.Drawing.Point(267, 54);
            this.pbIncorrect1.Name = "pbIncorrect1";
            this.pbIncorrect1.Size = new System.Drawing.Size(16, 16);
            this.pbIncorrect1.TabIndex = 14;
            this.pbIncorrect1.TabStop = false;
            this.pbIncorrect1.Visible = false;
            // 
            // lbLogin
            // 
            this.lbLogin.FormattingEnabled = true;
            this.lbLogin.Location = new System.Drawing.Point(2, 31);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(93, 199);
            this.lbLogin.TabIndex = 15;
            this.lbLogin.Visible = false;
            // 
            // lbMdp
            // 
            this.lbMdp.FormattingEnabled = true;
            this.lbMdp.Location = new System.Drawing.Point(332, 31);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(93, 199);
            this.lbMdp.TabIndex = 16;
            this.lbMdp.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.cool_washing_basic_collor_blue_black_rain_hd_wallpaper_112685;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.pbIncorrect1);
            this.Controls.Add(this.pbIncorrect2);
            this.Controls.Add(this.pbCorrect2);
            this.Controls.Add(this.pbCorrect1);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbAfficherMdp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Se connecter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Leave += new System.EventHandler(this.FormLogin_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbAfficherMdp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbCorrect1;
        private System.Windows.Forms.PictureBox pbCorrect2;
        private System.Windows.Forms.PictureBox pbIncorrect2;
        private System.Windows.Forms.PictureBox pbIncorrect1;
        private System.Windows.Forms.ListBox lbLogin;
        private System.Windows.Forms.ListBox lbMdp;
    }
}