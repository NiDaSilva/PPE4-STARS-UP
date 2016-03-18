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
            dataGridViewHistorique.DataSource = bindingSource1;

            for (int i = 0; i < dataGridViewHistorique.Rows.Count; i++) // parcours le datagridview
            {
                DateTime DateEntiere = Convert.ToDateTime(dataGridViewHistorique.Rows[i].Cells[0].Value.ToString()); // recupere date + heure
                string DateSeulement = string.Format("{0}", DateEntiere.ToString("dd-MM-yyyy")).Trim(); // recupere date
                TimeSpan HeureSeulement = new TimeSpan(DateEntiere.Hour, DateEntiere.Minute, DateEntiere.Second); // recupere heure, minute, seconde

                string HeureDebut = string.Format("{0} {1}", DateSeulement, HeureSeulement).Trim(); // Bon format
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
            
        }
    }
}
