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
            this.Close();
            FormLogin FL = new FormLogin();
            FL.Show();
        }

        private void FormIndex_Enter(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importToolStripMenuItem.Text == "Import")
            {
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
    }
}
