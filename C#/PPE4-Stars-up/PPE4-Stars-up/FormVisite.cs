using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    public partial class FormVisite : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        string RecupDateHeureVisite;
        string nom;
        string adresse;
        string ville;
        string horaires;
        string Etoile;
        string commentaireV;
        string ide;

        int compte = 0;
        int compte2 = 0;

        int idI;
        string test;

        string CR_commentaire;
        string CR_note;

        public FormVisite(string nomV, string adresseV, string villeV, string DateHeureVisite, string horairesV, string commentaireVisite, string NbE, string idd)
        {
            InitializeComponent();

            RecupDateHeureVisite = DateHeureVisite;
            nom = nomV;
            adresse = adresseV;
            ville = villeV;
            horaires = horairesV;
            Etoile = NbE;
            commentaireV = commentaireVisite;
            ide = idd;
        }

        private void FormVisite_Load(object sender, EventArgs e)
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

            lbladresse.Text = adresse;
            lblville.Text = ville;
            lblhoraire.Text = horaires;
            lblnom.Text = nom;
            lblDateTitre.Text = RecupDateHeureVisite;
            rtbCommentaire.Text = commentaireV;

            // Cache Etoile jaune après visite
            pbV1bis.Visible = false;
            pbV2bis.Visible = false;
            pbV3bis.Visible = false;
            pbV4bis.Visible = false;
            pbV5bis.Visible = false;


            // Cache tous avant visite
            pbF1.Visible = false;
            pbF2.Visible = false;
            pbF3.Visible = false;
            pbF4.Visible = false;
            pbF5.Visible = false;

            pbV1.Visible = false;
            pbV2.Visible = false;
            pbV3.Visible = false;
            pbV4.Visible = false;
            pbV5.Visible = false;

            // Si visite a déjà 1 commentaire alors Lecture Seule
            if (rtbCommentaire.Text != "")
            {
                // rtbCommentaire.Enabled = false;
                rtbCommentaire.ReadOnly = true;
                lblNote.Visible = false;

                pbV1bis.Visible = false;
                pbV2bis.Visible = false;
                pbV3bis.Visible = false;
                pbV4bis.Visible = false;
                pbV5bis.Visible = false;

                pbF1bis.Visible = false;
                pbF2bis.Visible = false;
                pbF3bis.Visible = false;
                pbF4bis.Visible = false;
                pbF5bis.Visible = false;

                btnAnnule.Visible = false;
                btnSauvegarderVisite.Visible = false;
                btnRetour.Visible = true;
            }
            else
            {
                rtbCommentaire.ReadOnly = false;
                lblNote.Visible = true;

                pbF1bis.Visible = true;
                pbF2bis.Visible = true;
                pbF3bis.Visible = true;
                pbF4bis.Visible = true;
                pbF5bis.Visible = true;

                btnAnnule.Visible = true;
                btnSauvegarderVisite.Visible = true;
                btnRetour.Visible = false;
            }

            /* GESTION ETOILES AVANT VISITE */

            // MessageBox.Show("Nb d'étoiles : " + Etoile);
            
            if (Etoile == "1")
            {
                pbV1.Visible = true;
                pbF1.Visible = false;

                pbV2.Visible = false;
                pbF2.Visible = true;

                pbV3.Visible = false;
                pbF3.Visible = true;

                pbV4.Visible = false;
                pbF4.Visible = true;

                pbV5.Visible = false;
                pbF5.Visible = true;
            }
            else if (Etoile == "2")
            {
                pbV1.Visible = true;
                pbF1.Visible = false;

                pbV2.Visible = true;
                pbF2.Visible = false;

                pbV3.Visible = false;
                pbF3.Visible = true;

                pbV4.Visible = false;
                pbF4.Visible = true;

                pbV5.Visible = false;
                pbF5.Visible = true;
            }
            else if (Etoile == "3")
            {
                pbV1.Visible = true;
                pbF1.Visible = false;

                pbV2.Visible = true;
                pbF2.Visible = false;

                pbV3.Visible = true;
                pbF3.Visible = false;

                pbV4.Visible = false;
                pbF4.Visible = true;

                pbV5.Visible = false;
                pbF5.Visible = true;
            }
            else if (Etoile == "4")
            {
                pbV1.Visible = true;
                pbF1.Visible = false;

                pbV2.Visible = true;
                pbF2.Visible = false;

                pbV3.Visible = true;
                pbF3.Visible = false;

                pbV4.Visible = true;
                pbF4.Visible = false;

                pbV5.Visible = false;
                pbF5.Visible = true;
            }
            else if (Etoile == "5")
            {
                pbV1.Visible = true;
                pbF1.Visible = false;

                pbV2.Visible = true;
                pbF2.Visible = false;

                pbV3.Visible = true;
                pbF3.Visible = false;

                pbV4.Visible = true;
                pbF4.Visible = false;

                pbV5.Visible = true;
                pbF5.Visible = false;
            }
            else
            {
                pbV1.Visible = false;
                pbF1.Visible = true;

                pbV2.Visible = false;
                pbF2.Visible = true;

                pbV3.Visible = false;
                pbF3.Visible = true;

                pbV4.Visible = false;
                pbF4.Visible = true;

                pbV5.Visible = false;
                pbF5.Visible = true;
            }

            // Récupérer l'index

            bindingSource1.DataSource = controleur.Vmodele.Dv_maj_etoile_commentaire;
            dataGridViewPersonnes.DataSource = bindingSource1;
                        
            for (int i = 0; i < dataGridViewPersonnes.Rows.Count; i++) // parcours le datagridview
            {
                if (dataGridViewPersonnes.Rows[i].Cells[0].Value.ToString() == recup().ToString() && dataGridViewPersonnes.Rows[i].Cells[1].Value.ToString() == ide)
                {
                    // recupere valeur de compte ce qui nous donne l'index
                    compte2 = compte;
                }
                else
                {
                    compte++;
                }
            }

            // MessageBox.Show("id heber recu : " + ide.ToString());
            // MessageBox.Show("index : " + compte2.ToString());

            this.Text = LangueElement[70];
            lblVisite.Text = LangueElement[71];
            lblNomHebergemenr.Text = LangueElement[72];
            lblAdresseHebergement.Text = LangueElement[73];
            lblNbEtoiles.Text = LangueElement[74];
            lblVilleHebergement.Text = LangueElement[75];
            lblHoraires.Text = LangueElement[76];
            lblCommentaire.Text = LangueElement[77];
            lblNote.Text = LangueElement[78];
            btnRetour.Text = LangueElement[79];
            btnSauvegarderVisite.Text = LangueElement[80];
            btnAnnule.Text = LangueElement[81];

        }

        private void btnSauvegarderVisite_Click(object sender, EventArgs e)
        {
            // Gestion des étoiles

            if (pbV1bis.Visible == false && pbV2bis.Visible == false && pbV3bis.Visible == false && pbV4bis.Visible == false && pbV5bis.Visible == false)
            {
                CR_note = "0";
            }

            if (pbV1bis.Visible == true && pbV2bis.Visible == false && pbV3bis.Visible == false && pbV4bis.Visible == false && pbV5bis.Visible == false)
            {
                CR_note = "1";
            }

            if (pbV1bis.Visible == true && pbV2bis.Visible == true && pbV3bis.Visible == false && pbV4bis.Visible == false && pbV5bis.Visible == false)
            {
                CR_note = "2";
            }

            if (pbV1bis.Visible == true && pbV2bis.Visible == true && pbV3bis.Visible == true && pbV4bis.Visible == false && pbV5bis.Visible == false)
            {
                CR_note = "3";
            }

            if (pbV1bis.Visible == true && pbV2bis.Visible == true && pbV3bis.Visible == true && pbV4bis.Visible == true && pbV5bis.Visible == false)
            {
                CR_note = "4";
            }

            if (pbV1bis.Visible == true && pbV2bis.Visible == true && pbV3bis.Visible == true && pbV4bis.Visible == true && pbV5bis.Visible == true)
            {
                CR_note = "5";
            }

            CR_commentaire = rtbCommentaire.Text;

            DialogResult DR = MessageBox.Show(LangueElement[82] + "\n\n" + LangueElement[83] + CR_commentaire + "\n" + LangueElement[84] + CR_note + "\n\n" + LangueElement[85], LangueElement[86], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(DR == DialogResult.Yes)
            {
                controleur.modif_bdd('u', CR_commentaire, Convert.ToInt32(CR_note), compte2);

                // Gérer l'export des données
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbV1bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "1";
        }

        private void pbV2bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "2";
        }

        private void pbV3bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "3";
        }

        private void pbV4bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "4";
        }

        private void pbV5bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = true;
            pbF5bis.Visible = false;

            // CR_note = "5";
        }

        private void pbF1bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "1";
        }

        private void pbF2bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "2";
        }

        private void pbF3bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "3";
        }

        private void pbF4bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "4";
        }

        private void pbF5bis_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = true;
            pbF5bis.Visible = false;

            // CR_note = "5";
        }

        private void pbEtoile0_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = false;
            pbF1bis.Visible = true;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "0";
        }

        private void lblNote_Click(object sender, EventArgs e)
        {
            pbV1bis.Visible = false;
            pbF1bis.Visible = true;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;

            // CR_note = "0";
        }

        private void pbF1bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbF2bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbF3bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbF4bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbF5bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = true;
            pbF5bis.Visible = false;
        }

        private void pbV1bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbV2bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbV3bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbV4bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbV5bis_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = true;
            pbF1bis.Visible = false;

            pbV2bis.Visible = true;
            pbF2bis.Visible = false;

            pbV3bis.Visible = true;
            pbF3bis.Visible = false;

            pbV4bis.Visible = true;
            pbF4bis.Visible = false;

            pbV5bis.Visible = true;
            pbF5bis.Visible = false;
        }

        private void lblNote_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = false;
            pbF1bis.Visible = true;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void pbEtoile0_MouseHover(object sender, EventArgs e)
        {
            pbV1bis.Visible = false;
            pbF1bis.Visible = true;

            pbV2bis.Visible = false;
            pbF2bis.Visible = true;

            pbV3bis.Visible = false;
            pbF3bis.Visible = true;

            pbV4bis.Visible = false;
            pbF4bis.Visible = true;

            pbV5bis.Visible = false;
            pbF5bis.Visible = true;
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lireFichier()
        {

            // string[] lines = System.IO.File.ReadAllLines(@"C:\PPE4_DR\Preferences_PPE4_DR.txt");

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\PPE4_DR\Preferences_PPE4_DR.txt");

            while ((line = file.ReadLine()) != null)
            {
                counter++;
                if (counter == 1)
                {

                    test = line.ToString();
                }
            }

            file.Close();

            // test = lines[0].ToString();
        }

        public int recup()
        {
            // Id de l'inspecteur connecté

            lireFichier();
            idI = Convert.ToInt32(test);
            return idI;
        }
    }
}
