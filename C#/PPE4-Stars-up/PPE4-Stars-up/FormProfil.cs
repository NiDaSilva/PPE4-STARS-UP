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
