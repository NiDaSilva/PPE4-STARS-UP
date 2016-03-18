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
    public partial class FormVisite : Form
    {
        string RecupDateHeureVisite;
        string nom;
        string adresse;
        string ville;
        string horaires;
        string Etoile;
        string commentaireV;

        string CR_commentaire;
        string CR_note;

        public FormVisite(string nomV, string adresseV, string villeV, string DateHeureVisite, string horairesV, string commentaireVisite, string NbE)
        {
            InitializeComponent();

            RecupDateHeureVisite = DateHeureVisite;
            nom = nomV;
            adresse = adresseV;
            ville = villeV;
            horaires = horairesV;
            Etoile = NbE;
            commentaireV = commentaireVisite;
        }

        private void FormVisite_Load(object sender, EventArgs e)
        {
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

        }

        private void btnSauvegarderVisite_Click(object sender, EventArgs e)
        {
            CR_commentaire = rtbCommentaire.Text;

            MessageBox.Show("Compte-rendu :\n\nCommentaire : " + CR_commentaire + "\n\nNote : " + CR_note + "\n\nPlus qu'à export.");

            // Gérer l'export des données
            this.Close();
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

            CR_note = "1";
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

            CR_note = "2";
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

            CR_note = "3";
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

            CR_note = "4";
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

            CR_note = "5";
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

            CR_note = "1";
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

            CR_note = "2";
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

            CR_note = "3";
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

            CR_note = "4";
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

            CR_note = "5";
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

            CR_note = "0";
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

            CR_note = "0";
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
    }
}
