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
        public FormIndex()
        {
            InitializeComponent();
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
            Planning.Semaine.FormPlanningSemaine FPS = new Planning.Semaine.FormPlanningSemaine();
            FPS.MdiParent = this;

            FPS.Show();
        }
    }
}
