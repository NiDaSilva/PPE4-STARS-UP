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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbAfficherMdp = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbLogin = new System.Windows.Forms.RichTextBox();
            this.rtbMdp = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tbMdp.Enter += new System.EventHandler(this.tbMdp_Enter);
            this.tbMdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMdp_KeyDown);
            this.tbMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMdp_KeyPress);
            this.tbMdp.Leave += new System.EventHandler(this.tbMdp_Leave);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Gentium Basic", 14.25F);
            this.btnOK.Location = new System.Drawing.Point(143, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(130, 33);
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
            // rtbLogin
            // 
            this.rtbLogin.Location = new System.Drawing.Point(12, 46);
            this.rtbLogin.Name = "rtbLogin";
            this.rtbLogin.Size = new System.Drawing.Size(100, 96);
            this.rtbLogin.TabIndex = 9;
            this.rtbLogin.Text = "";
            this.rtbLogin.Visible = false;
            // 
            // rtbMdp
            // 
            this.rtbMdp.Location = new System.Drawing.Point(315, 46);
            this.rtbMdp.Name = "rtbMdp";
            this.rtbMdp.Size = new System.Drawing.Size(100, 96);
            this.rtbMdp.TabIndex = 10;
            this.rtbMdp.Text = "";
            this.rtbMdp.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.cool_washing_basic_collor_blue_black_rain_hd_wallpaper_112685;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbAfficherMdp);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbMdp);
            this.Controls.Add(this.rtbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Se connecter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Leave += new System.EventHandler(this.FormLogin_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RichTextBox rtbLogin;
        private System.Windows.Forms.RichTextBox rtbMdp;
    }
}