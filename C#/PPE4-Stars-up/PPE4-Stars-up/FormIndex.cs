using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE4_Stars_up
{
    public partial class FormIndex : Form
    {
        string NI, PI;
        int II;

        public int II1
        {
            get
            {
                return II;
            }

            set
            {
                II = value;
            }
        }
        
        public FormIndex(string nomInspecteur, string prenomInspecteur, int idInspecteur)
        {
            InitializeComponent();
            
            NI = nomInspecteur;
            PI = prenomInspecteur;
            II = idInspecteur;

        }

        private void jourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlanningJour FPJ = new FormPlanningJour();
            FPJ.MdiParent = this;

            FPJ.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Visible = false;
            //this.Close();

            
            FormLogin FL = new FormLogin();
            FL.Show();

            //FormLogin.ActiveForm.Visible = true;          
        }

        private void FormIndex_Enter(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importToolStripMenuItem.Text == "Import")
            {                
                controleur.init();
                controleur.Vmodele.seconnecter();

                if (controleur.Vmodele.Connopen == false)
                {
                    MessageBox.Show("La connexion n'a pas eu lieu.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controleur.Vmodele.import();

                    controleur.Vmodele.sedeconnecter();
                }

                importToolStripMenuItem.Text = "Export";
                planningToolStripMenuItem.Enabled = true;
                historiqueDesVisitesToolStripMenuItem.Enabled = true;
                imprimerPDFToolStripMenuItem.Enabled = true;
                quitterToolStripMenuItem.Enabled = true;
            }
        }

        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void semaineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            FormPlanningJour FPJ = new FormPlanningJour();
            FPJ.MdiParent = this;

            FPJ.Show();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            var pos = this.PointToScreen(lblinfo.Location);
            pos = pictureBox1.PointToClient(pos);
            lblinfo.Parent = pictureBox1;
            lblinfo.Location = pos;
            lblinfo.BackColor = Color.Transparent;
            var pos2 = this.PointToScreen(lblInspecteur.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            lblInspecteur.Parent = pictureBox1;
            lblInspecteur.Location = pos2;
            lblInspecteur.BackColor = Color.Transparent;

            FormLogin FL = new FormLogin();
            
            lblInspecteur.Text = NI + " " + PI;
        }

        private void historiqueDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void imprimerPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
