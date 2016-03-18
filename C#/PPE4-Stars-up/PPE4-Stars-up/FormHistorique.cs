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
    public partial class FormHistorique : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public FormHistorique()
        {
            InitializeComponent();
            chargedgv();
        }

        public void chargedgv()
        {
            bindingSource1.DataSource = controleur.Vmodele.Dv_Historique;

            // Remplissage du Tableau
            dataGridViewHistorique.DataSource = bindingSource1;

            for (int i = 0; i < dataGridViewHistorique.Rows.Count; i++) // parcours le datagridview
            {
                // Remplissage de la liste

                /*
                listBoxHistorique.Items.Add("Date & Heure  : " + dataGridViewHistorique.Rows[i].Cells[0].Value.ToString() + "\nDépartement : " + dataGridViewHistorique.Rows[i].Cells[1].Value.ToString() +
                    "\nHébergement : " + dataGridViewHistorique.Rows[i].Cells[2].Value.ToString() + "\nNombre d'étoiles attribuées : " + dataGridViewHistorique.Rows[i].Cells[3].Value.ToString() +
                    "\nCommentaire : " + dataGridViewHistorique.Rows[i].Cells[4].Value.ToString() + "\n\n\n");
                 */


            }
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;
            form.HistoriqueDesVisitesToolStripMenuItem.Enabled = true;
            form.PlanningToolStripMenuItem.Enabled = true;
            form.Background();
            this.Close();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            // progress bar autoit
        }

        private void FormHistorique_Load(object sender, EventArgs e)
        {
            listBoxHistorique.Visible = false;
        }

        private void rbListe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbListe_Click(object sender, EventArgs e)
        {
            dataGridViewHistorique.Visible = false;
            gbTri.Enabled = true;
            listBoxHistorique.Visible = true;
            
        }

        private void rbTableau_Click(object sender, EventArgs e)
        {
            dataGridViewHistorique.Visible = true;
            gbTri.Enabled = false;
            listBoxHistorique.Visible = false;
        }
    }
}
