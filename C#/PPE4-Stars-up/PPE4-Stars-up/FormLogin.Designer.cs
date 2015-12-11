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
            this.tbMdp.Location = new System.Drawing.Point(125, 108);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(164, 29);
            this.tbMdp.TabIndex = 1;
            this.tbMdp.Text = "Mot de passe";
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
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.cool_washing_basic_collor_blue_black_rain_hd_wallpaper_112685;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Se connecter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Leave += new System.EventHandler(this.FormLogin_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button btnOK;
    }
}