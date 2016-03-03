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
using System.IO;

namespace PPE4_Stars_up
{
    public partial class FormIndex : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        private MySqlDataAdapter mySqlDataAdapterTP7 = new MySqlDataAdapter();
        private DataSet dataSetTP7 = new DataSet();
        private DataView dv_specialite = new DataView();


        // creation d’une liste des logins inspecteurs
        List<KeyValuePair<int, string>> FListSpe = new List<KeyValuePair<int, string>>();

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

                lblSpecialite.Text = controleur.Vmodele.Dv_specialite.ToTable().Rows[0][0].ToString() + "\n"; // Récupère la spécialité 
                ecrireFichier();
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
            chargedgv();

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

            var pos3 = this.PointToScreen(lblinfo2.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            lblinfo2.Parent = pictureBox1;
            lblinfo2.Location = pos3;
            lblinfo2.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(lblSpecialite.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            lblSpecialite.Parent = pictureBox1;
            lblSpecialite.Location = pos4;
            lblSpecialite.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(lblheure.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            lblheure.Parent = pictureBox1;
            lblheure.Location = pos6;
            lblheure.BackColor = Color.Transparent;

            FormLogin FL = new FormLogin();
            
            lblInspecteur.Text = NI + " " + PI;
            lblheure.Text = DateTime.Now.ToString("HH:mm");
        }

        private void historiqueDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void imprimerPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        public void chargedgv()
        {

        }

        private void ecrireFichier()
        {
            string lines = lblSpecialite.Text;
            System.IO.File.AppendAllText(@"C:\PPE4_DR\Preferences_PPE4_DR.txt", lines);
        }
    }
}
