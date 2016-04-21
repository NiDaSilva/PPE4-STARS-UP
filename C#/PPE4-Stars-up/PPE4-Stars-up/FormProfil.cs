using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    public partial class FormProfil : Form
    {
        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";
        string family = "Gentium Basic";

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

            this.Text = LangueElement[129];
            lblTpsConnexion.Text = LangueElement[130];
            lblDep.Text = LangueElement[131];
            lblNationalite.Text = LangueElement[132];
            lblAge.Text = LangueElement[133];

            // Gestion transparence
            if (listeElement[3] != "")
            {
                Opacity = Convert.ToDouble(listeElement[3]);
            }

            // Gestion couleur background

            if (listeElement[6] != "Par défaut")
            {
                this.BackgroundImage = null;

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

                try
                {
                    this.BackColor = c;
                }
                catch
                {
                    this.BackgroundImage = PPE4_Stars_up.Properties.Resources.background_profil;
                }
            }
            else
            {
                this.BackgroundImage = PPE4_Stars_up.Properties.Resources.background_profil;
            }


            // Gestion Police

            if (listeElement[7] != "Par défaut")
            {
                try
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x is Label)
                        {
                            x.Font = new Font(listeElement[7], x.Font.SizeInPoints, x.Font.Style);
                        }
                    }
                }
                catch
                {
                    foreach (Control x in this.Controls)
                    {
                        if (x is Label)
                        {
                            x.Font = new Font(family, x.Font.SizeInPoints, x.Font.Style);
                        }
                    }
                }
            }
            else
            {
                foreach (Control x in this.Controls)
                {
                    if (x is Label)
                    {
                        x.Font = new Font(family, x.Font.SizeInPoints, x.Font.Style);
                    }
                }
            }



            
            
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
                lblResAge.Text = LangueElement[134];
            }


            // Département
            if (controleur.Vmodele.Dv_departement.ToTable().Rows[0][0].ToString() != "")
            {
                lblResDep.Text = controleur.Vmodele.Dv_departement.ToTable().Rows[0][0].ToString();
            }
            else
            {
                lblResDep.Text = LangueElement[134];
            }

            // Nationalite
            if (controleur.Vmodele.Dv_pdp.ToTable().Rows[0][10].ToString() != "")
            {
                lblResNationalite.Text = controleur.Vmodele.Dv_pdp.ToTable().Rows[0][10].ToString();
            }
            else
            {
                lblResNationalite.Text = LangueElement[134];
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
                lblResTpsConnexion.Text = LangueElement[135];
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
