using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        private void pbLeave_Click(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;
            form.HistoriqueDesVisitesToolStripMenuItem.Enabled = true;
            form.PlanningToolStripMenuItem.Enabled = true;
            form.Background();
            form.MAJHeure();
            this.Close();
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            if (controleur.Vmodele.Dv_pdp.ToTable().Rows[0][0].ToString() != "")
            {
                // pbPDP.Location = new Point(712, 356);
                pbPDP.SizeMode = PictureBoxSizeMode.Zoom;
                pbPDP.ImageLocation = controleur.Vmodele.Dv_pdp.ToTable().Rows[0][6].ToString(); // Récupère le chemin de la photo
            }
            else
            {
                pbPDP.SizeMode = PictureBoxSizeMode.Zoom;
                pbPDP.ImageLocation = @"PDP/anonyme.png";
                // pbPDP.Location = new Point(680, 359);
            }
            
            // Nom prenom
            lblTitrePN.Text = controleur.Vmodele.Dv_inspecteur.ToTable().Rows[0][0].ToString();

            // Age
            if(controleur.Vmodele.Dv_pdp.ToTable().Rows[0][9].ToString() != "")
            {
                lblResAge.Text = GetAge(controleur.Vmodele.Dv_pdp.ToTable().Rows[0][9].ToString()).ToString();
            }
            else
            {
                lblResAge.Text = "Indisponible";
            }


            // Département
            if (controleur.Vmodele.Dv_departement.ToTable().Rows[0][0].ToString() != "")
            {
                lblResDep.Text = controleur.Vmodele.Dv_departement.ToTable().Rows[0][0].ToString();
            }
            else
            {
                lblResDep.Text = "Indisponible";
            }

            // Nationalite
            if (controleur.Vmodele.Dv_pdp.ToTable().Rows[0][10].ToString() != "")
            {
                lblResNationalite.Text = controleur.Vmodele.Dv_pdp.ToTable().Rows[0][10].ToString();
            }
            else
            {
                lblResNationalite.Text = "Indisponible";
            }

           // MessageBox.Show(controleur.Vmodele.Dv_pdp.ToTable().Rows[0][7].ToString());

            // Temps de connexion
            if (controleur.Vmodele.Dv_pdp.ToTable().Rows[0][7].ToString() != "0")
            {
                // lblResTpsConnexion.Text = controleur.Vmodele.Dv_pdp.ToTable().Rows[0][7].ToString();

                Int64 fss = Convert.ToInt64(controleur.Vmodele.Dv_pdp.ToTable().Rows[0][7].ToString());

                DateTime dt = new DateTime(fss);
                // lblResTpsConnexion.Text = dt.ToString();

                int jouur = 0;
                int mois = 0;
                int annee = 0;

                 //MessageBox.Show(dt.Day.ToString());
                 //MessageBox.Show(dt.Month.ToString());
                 //MessageBox.Show(dt.Year.ToString());
                 //MessageBox.Show(dt.Hour.ToString());

                if(dt.Day != 1)
                {
                    jouur = dt.Day;
                }

                if (dt.Month != 1)
                {
                    mois = dt.Month;
                }

                if (dt.Year != 1)
                {
                    annee = dt.Year;
                }

                int hour = 0;

                hour = jouur * 24 + mois * 720 + annee * 8760;
                hour = hour + dt.Hour;

                lblResTpsConnexion.Text = "";

                if (hour.ToString() != "0")
                {
                    lblResTpsConnexion.Text += hour.ToString() + " h ";
                }

                if (dt.Minute.ToString() != "0")
                {
                    lblResTpsConnexion.Text += dt.Minute.ToString() + " min ";
                }

                if (dt.Second.ToString() != "0")
                {
                    lblResTpsConnexion.Text += dt.Second.ToString() + " sec";
                }

            }
            else
            {
                lblResTpsConnexion.Text = "Ø (1ère connexion)";
            }

            pbPDP.Visible = true;
        }

        public static int GetAge(string birthDate)
        {
            DateTime dt = Convert.ToDateTime(birthDate);
            TimeSpan span = DateTime.Now.Subtract(dt);
            return span.Days / 365;
        }
    }
}
