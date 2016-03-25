using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using AutoItX3Lib;
using System.Threading;

namespace PPE4_Stars_up
{
    public partial class FormHistorique : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        string nbEtoile, comment;
        AutoItX3 au3 = new AutoItX3();
        
        public FormHistorique()
        {
            InitializeComponent();
            chargedgv();
        }

        /// <summary>
        /// Méthode qui permet d'ouvrir un fichier xml (s'il existe) et de charger son contenu dans la collection
        /// </summary>
        private void recup_xml()
        {
            try
            {
               // InputBox("Chargement", "Ouverture du fichier");

                if (InputBox("Chargement", "Ouverture du fichier") == 100)
                {
                    Close();
                }

                // Pour recréer la liste à partir du fichier :
                // XmlSerializer serialXml = new XmlSerializer(typeof(List<ClassActivite>));
                if (File.Exists("C:\\PPE4_DR\\HistoriqueVisites.xml"))
                {
                    using (Stream flux = new FileStream("C:\\PPE4_DR\\HistoriqueVisites.xml", FileMode.Open, FileAccess.Read))
                    {
                        // lesActivites = (List<ClassActivite>)serialXml.Deserialize(flux);
                    }
                }
                else
                {
                    MessageBox.Show("Fichier xml inexistant");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur dans la récupation du fichier xml : " + err.ToString());
            }
        }

        /// <summary>
        /// méthode qui permet d'enregistrer la collection dans un fichier xml
        /// </summary>
        private void ecrire_xml()
        {
            try
            {
                XmlSerializer serialXml = new XmlSerializer(typeof(String));
                using (Stream flux = new FileStream("C:\\PPE4_DR\\HistoriqueVisites.xml", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    // serialXml.Serialize(flux, lesActivites);

                    for (int i = 0; i < dataGridViewHistorique.Rows.Count; i++) // parcours le datagridview
                    {
                        serialXml.Serialize(flux, dataGridViewHistorique.Rows[i].Cells[0].Value.ToString());
                        serialXml.Serialize(flux, dataGridViewHistorique.Rows[i].Cells[1].Value.ToString());
                        serialXml.Serialize(flux, dataGridViewHistorique.Rows[i].Cells[2].Value.ToString());
                        serialXml.Serialize(flux, dataGridViewHistorique.Rows[i].Cells[3].Value.ToString());
                        serialXml.Serialize(flux, dataGridViewHistorique.Rows[i].Cells[4].Value.ToString());
                    }

                    MessageBox.Show("Données enregistrées dans le répertoire : \"C:\\PPE4_DR\\\" au format .xml.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur dans l'écriture du fichier : " + err.ToString());
            }
        }


        public void chargedgv()
        {            
            if (rbTriDate.Checked)
            {
                bindingSource1.DataSource = controleur.Vmodele.Dv_Historique;
            }
            else if (rbTriDepartement.Checked)
            {
                bindingSource1.DataSource = controleur.Vmodele.Dv_Historique_Dep;
            }
            else if (rbTriEtoile.Checked)
            {
                bindingSource1.DataSource = controleur.Vmodele.Dv_Historique_Etoile;
            }

            // Remplissage du Tableau
            dataGridViewHistorique.DataSource = bindingSource1;
            
            for (int i = 0; i < dataGridViewHistorique.Rows.Count; i++) // parcours le datagridview
            {
                // Gestion si aucune étoile entrée dans la bdd
                if (dataGridViewHistorique.Rows[i].Cells[3].Value.ToString() == "")
                {
                    nbEtoile = "0";
                    dataGridViewHistorique.Rows[i].Cells[3].Value = "0";
                }
                else
                {
                    nbEtoile = dataGridViewHistorique.Rows[i].Cells[3].Value.ToString();
                }

                // Gestion si aucun commentaire entré dans la bdd
                if (dataGridViewHistorique.Rows[i].Cells[4].Value.ToString() == "")
                {
                    comment = "-";
                    dataGridViewHistorique.Rows[i].Cells[4].Value = "-";
                }
                else
                {
                    comment = dataGridViewHistorique.Rows[i].Cells[4].Value.ToString();
                }

                // Remplissage de la liste
                listBoxHistorique.Items.Add("Date & Heure : " + dataGridViewHistorique.Rows[i].Cells[0].Value.ToString());
                listBoxHistorique.Items.Add("Département : " + dataGridViewHistorique.Rows[i].Cells[1].Value.ToString());
                listBoxHistorique.Items.Add("Hébergement : " + dataGridViewHistorique.Rows[i].Cells[2].Value.ToString());
                listBoxHistorique.Items.Add("Nombre d'étoiles attribuées : " + nbEtoile);
                listBoxHistorique.Items.Add("Commentaire : " + comment);

                if (i < (dataGridViewHistorique.Rows.Count - 1))
                {
                    listBoxHistorique.Items.Add("");
                    listBoxHistorique.Items.Add("--------------------------------------------------------------------------------------------------------------------------");
                    //listBoxHistorique.Items.Add("________________________________________________________________________");
                    listBoxHistorique.Items.Add("");
                }

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
            recup_xml();
            ecrire_xml();
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
            listBoxHistorique.Items.Clear();
            chargedgv();
            listBoxHistorique.Visible = true;
            
        }

        private void rbTableau_Click(object sender, EventArgs e)
        {
            dataGridViewHistorique.Visible = true;
            gbTri.Enabled = false;
            listBoxHistorique.Visible = false;
            listBoxHistorique.Items.Clear();
        }

        private void rbTriDate_Click(object sender, EventArgs e)
        {
            listBoxHistorique.Items.Clear();
            chargedgv();
        }

        private void rbTriDepartement_Click(object sender, EventArgs e)
        {
            listBoxHistorique.Items.Clear();
            chargedgv();
        }

        private void rbTriEtoile_Click(object sender, EventArgs e)
        {
            listBoxHistorique.Items.Clear();
            chargedgv();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static int InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            ProgressBar Progress = new ProgressBar();

            Progress.Minimum = 0;
            Progress.Maximum = 100;

            form.Text = title;
            label.Text = promptText;
            label.SetBounds(9, 20, 372, 13);
            Progress.SetBounds(22, 36, 372, 20);

            label.AutoSize = true;
            Progress.Anchor = Progress.Anchor | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, Progress });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            for (int i = 0; i < 100; i++)
            {
                // Thread.Sleep(100); --> Timer au tick
                Progress.Value += 1;
            }

            form.Show();
            int Res = Progress.Value;
            if (Res==100)
                form.Close();

            return Res;
        }
    }
}
