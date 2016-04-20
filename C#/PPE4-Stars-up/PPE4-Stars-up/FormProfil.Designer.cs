namespace PPE4_Stars_up
{
    partial class FormProfil
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
            this.pbLeave = new System.Windows.Forms.PictureBox();
            this.pbPDP = new System.Windows.Forms.PictureBox();
            this.lblTitrePN = new System.Windows.Forms.Label();
            this.lblTpsConnexion = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblNationalite = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblResTpsConnexion = new System.Windows.Forms.Label();
            this.lblResDep = new System.Windows.Forms.Label();
            this.lblResNationalite = new System.Windows.Forms.Label();
            this.lblResAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDP)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLeave
            // 
            this.pbLeave.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.sortie;
            this.pbLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLeave.Location = new System.Drawing.Point(729, 384);
            this.pbLeave.Name = "pbLeave";
            this.pbLeave.Size = new System.Drawing.Size(50, 50);
            this.pbLeave.TabIndex = 41;
            this.pbLeave.TabStop = false;
            this.pbLeave.Click += new System.EventHandler(this.pbLeave_Click);
            // 
            // pbPDP
            // 
            this.pbPDP.BackColor = System.Drawing.Color.Transparent;
            this.pbPDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPDP.ImageLocation = "";
            this.pbPDP.Location = new System.Drawing.Point(591, 37);
            this.pbPDP.Name = "pbPDP";
            this.pbPDP.Size = new System.Drawing.Size(143, 148);
            this.pbPDP.TabIndex = 40;
            this.pbPDP.TabStop = false;
            // 
            // lblTitrePN
            // 
            this.lblTitrePN.AutoSize = true;
            this.lblTitrePN.BackColor = System.Drawing.Color.Transparent;
            this.lblTitrePN.Font = new System.Drawing.Font("Gentium Basic", 28F, System.Drawing.FontStyle.Underline);
            this.lblTitrePN.Location = new System.Drawing.Point(241, 37);
            this.lblTitrePN.Name = "lblTitrePN";
            this.lblTitrePN.Size = new System.Drawing.Size(230, 44);
            this.lblTitrePN.TabIndex = 42;
            this.lblTitrePN.Text = "Prénom NOM";
            // 
            // lblTpsConnexion
            // 
            this.lblTpsConnexion.AutoSize = true;
            this.lblTpsConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lblTpsConnexion.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblTpsConnexion.Location = new System.Drawing.Point(441, 279);
            this.lblTpsConnexion.Name = "lblTpsConnexion";
            this.lblTpsConnexion.Size = new System.Drawing.Size(161, 20);
            this.lblTpsConnexion.TabIndex = 43;
            this.lblTpsConnexion.Text = "Temps de connexion :";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.BackColor = System.Drawing.Color.Transparent;
            this.lblDep.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblDep.Location = new System.Drawing.Point(441, 311);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(73, 20);
            this.lblDep.TabIndex = 44;
            this.lblDep.Text = "Localité :";
            // 
            // lblNationalite
            // 
            this.lblNationalite.AutoSize = true;
            this.lblNationalite.BackColor = System.Drawing.Color.Transparent;
            this.lblNationalite.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblNationalite.Location = new System.Drawing.Point(441, 343);
            this.lblNationalite.Name = "lblNationalite";
            this.lblNationalite.Size = new System.Drawing.Size(97, 20);
            this.lblNationalite.TabIndex = 45;
            this.lblNationalite.Text = "Nationalité :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Gentium Basic", 12.25F);
            this.lblAge.Location = new System.Drawing.Point(441, 375);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 46;
            this.lblAge.Text = "Age :";
            // 
            // lblResTpsConnexion
            // 
            this.lblResTpsConnexion.AutoSize = true;
            this.lblResTpsConnexion.BackColor = System.Drawing.Color.Transparent;
            this.lblResTpsConnexion.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResTpsConnexion.Location = new System.Drawing.Point(603, 280);
            this.lblResTpsConnexion.Name = "lblResTpsConnexion";
            this.lblResTpsConnexion.Size = new System.Drawing.Size(59, 19);
            this.lblResTpsConnexion.TabIndex = 47;
            this.lblResTpsConnexion.Text = "??:??:??";
            // 
            // lblResDep
            // 
            this.lblResDep.AutoSize = true;
            this.lblResDep.BackColor = System.Drawing.Color.Transparent;
            this.lblResDep.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResDep.Location = new System.Drawing.Point(520, 311);
            this.lblResDep.Name = "lblResDep";
            this.lblResDep.Size = new System.Drawing.Size(58, 19);
            this.lblResDep.TabIndex = 48;
            this.lblResDep.Text = "???????";
            // 
            // lblResNationalite
            // 
            this.lblResNationalite.AutoSize = true;
            this.lblResNationalite.BackColor = System.Drawing.Color.Transparent;
            this.lblResNationalite.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNationalite.Location = new System.Drawing.Point(542, 344);
            this.lblResNationalite.Name = "lblResNationalite";
            this.lblResNationalite.Size = new System.Drawing.Size(58, 19);
            this.lblResNationalite.TabIndex = 49;
            this.lblResNationalite.Text = "???????";
            // 
            // lblResAge
            // 
            this.lblResAge.AutoSize = true;
            this.lblResAge.BackColor = System.Drawing.Color.Transparent;
            this.lblResAge.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResAge.Location = new System.Drawing.Point(488, 376);
            this.lblResAge.Name = "lblResAge";
            this.lblResAge.Size = new System.Drawing.Size(23, 19);
            this.lblResAge.TabIndex = 50;
            this.lblResAge.Text = "??";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPE4_Stars_up.Properties.Resources.background_profil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.lblResAge);
            this.Controls.Add(this.lblResNationalite);
            this.Controls.Add(this.lblResDep);
            this.Controls.Add(this.lblResTpsConnexion);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNationalite);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblTpsConnexion);
            this.Controls.Add(this.lblTitrePN);
            this.Controls.Add(this.pbLeave);
            this.Controls.Add(this.pbPDP);
            this.Name = "FormProfil";
            this.Text = "Profil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPDP;
        private System.Windows.Forms.PictureBox pbLeave;
        private System.Windows.Forms.Label lblTitrePN;
        private System.Windows.Forms.Label lblTpsConnexion;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblNationalite;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblResTpsConnexion;
        private System.Windows.Forms.Label lblResDep;
        private System.Windows.Forms.Label lblResNationalite;
        private System.Windows.Forms.Label lblResAge;
    }
}