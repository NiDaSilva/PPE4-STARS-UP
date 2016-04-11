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

        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        public FormHistorique()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Méthode qui permet d'ouvrir un fichier xml (s'il existe) sinon de le créer
        /// </summary>
        private void recup_xml()
        {
            try
            {
                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[98], "");
                }

                if (File.Exists("C:\\PPE4_DR\\HistoriqueVisites.xml"))
                {
                    using (Stream flux = new FileStream("C:\\PPE4_DR\\HistoriqueVisites.xml", FileMode.Open, FileAccess.Read))
                    {

                        if (AffichageInputBox() == "Oui")
                        {
                            InputBox(LangueElement[99], "");
                        }
                    }
                }
                else
                {
                    // MessageBox.Show("Fichier xml inexistant!\nCliquez sur OK pour finaliser le processus.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[100], "");
                        InputBox(LangueElement[101], "");
                    }
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(LangueElement[102] + err.ToString());
            }
        }

        /// <summary>
        /// méthode qui permet d'écrire dans le fichier
        /// </summary>
        private void ecrire_xml()
        {
            try
            {

                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[103], "");
                }

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

                    MessageBox.Show(LangueElement[104], LangueElement[105], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(LangueElement[106] + err.ToString());
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
                listBoxHistorique.Items.Add(LangueElement[107] + dataGridViewHistorique.Rows[i].Cells[0].Value.ToString());
                listBoxHistorique.Items.Add(LangueElement[108] + dataGridViewHistorique.Rows[i].Cells[1].Value.ToString());
                listBoxHistorique.Items.Add(LangueElement[109] + dataGridViewHistorique.Rows[i].Cells[2].Value.ToString());
                listBoxHistorique.Items.Add(LangueElement[110] + nbEtoile);
                listBoxHistorique.Items.Add(LangueElement[111] + comment);

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
            form.MAJHeure();
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
            // Gestion de la langue
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if (listeElement[1] == "Francais")
            {
                FichierLangue = "Francais.txt";
            }

            if (listeElement[1] == "Anglais")
            {
                FichierLangue = "Anglais.txt";
            }

            if (listeElement[1] == "Allemand")
            {
                FichierLangue = "Allemand.txt";
            }

            if (listeElement[1] == "Espagnol")
            {
                FichierLangue = "Espagne.txt";
            }

            StreamReader reader2 = File.OpenText(FichierLangue);
            string ligne2;

            while (!reader2.EndOfStream)
            {
                ligne2 = reader2.ReadLine();
                LangueElement.Add(ligne2);
            }
            reader.Close();

            // Gestion transparence
            if (listeElement[3] != "")
            {
                Opacity = Convert.ToDouble(listeElement[3]);
            }

            chargedgv();

            listBoxHistorique.Visible = false;

            this.Text = LangueElement[90];
            lblTitre.Text = LangueElement[90];
            gbAffichage.Text = LangueElement[91];
            rbTableau.Text = LangueElement[92];
            rbListe.Text = LangueElement[93];
            gbTri.Text = LangueElement[94];
            rbTriDate.Text = LangueElement[95];
            rbTriDepartement.Text = LangueElement[96];
            rbTriEtoile.Text = LangueElement[97];

            // Gestion couleur background

            if (listeElement[6] != "Par défaut")
            {
                this.BackgroundImage = null;
                panel1.BackgroundImage = null;

                int AA = 0;
                int RR = 0;
                int GG = 0;
                int BB = 0;

                // Get first match.
                Match match = Regex.Match(listeElement[6], @"\d+");
                if (match.Success)
                {
                    AA = Convert.ToInt32(match.Value);
                }

                // Get second match.
                match = match.NextMatch();
                if (match.Success)
                {
                    RR = Convert.ToInt32(match.Value);
                }

                // Get 3 match.
                match = match.NextMatch();
                if (match.Success)
                {
                    GG = Convert.ToInt32(match.Value);
                }

                // Get 4 match.
                match = match.NextMatch();
                if (match.Success)
                {
                    BB = Convert.ToInt32(match.Value); ;
                }

                Color c = Color.FromArgb(AA, RR, GG, BB);
                this.BackColor = c;
                panel1.BackColor = c;
            }
            else
            {
                this.BackgroundImage = PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
                panel1.BackgroundImage = PPE4_Stars_up.Properties.Resources._2395551_5_x11_wide_spread_professional_high_res_background_template_layout_that_can_be_used_for_any_kind_of_marketing_material_magazines_articles_scrapbook_and_even_advertisements;
            }
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
            LinkLabel texte = new LinkLabel();
            ProgressBar Progress = new ProgressBar();

            Progress.Minimum = 0;
            Progress.Maximum = 100;

            form.Text = title;
            texte.Text = promptText;
            texte.SetBounds(9, 20, 372, 13);
            Progress.SetBounds(9, 30, 372, 20);

            texte.AutoSize = true;
            Progress.Anchor = Progress.Anchor | AnchorStyles.Right;

            form.ClientSize = new Size(396, 91);
            form.Controls.AddRange(new Control[] { texte, Progress });
            form.ClientSize = new Size(Math.Max(300, texte.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;

            form.Show();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(12); // --> Timer au tick

                Progress.Value += 1;
                form.Show();
            }

            int Res = Progress.Value;
            if (Res==100)
              form.Close();

            return Res;
        }

        public string AffichageInputBox()
        {
            string resultat = "";

            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            // Gestion Affichage InputBox
            if (listeElement[4] == "Oui")
            {
                resultat = "Oui";
            }
            else if (listeElement[4] == "Non")
            {
                resultat = "Non";
            }

            return resultat;
        }
    }
}
