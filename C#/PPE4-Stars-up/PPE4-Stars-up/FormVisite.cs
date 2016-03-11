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

        public FormVisite(string nomV, string adresseV, string villeV, string DateHeureVisite, string horairesV, string NbE)
        {
            InitializeComponent();

            RecupDateHeureVisite = DateHeureVisite;
            nom = nomV;
            adresse = adresseV;
            ville = villeV;
            horaires = horairesV;
            Etoile = NbE;
        }

        private void FormVisite_Load(object sender, EventArgs e)
        {
            lbladresse.Text = adresse;
            lblville.Text = ville;
            lblhoraire.Text = horaires;
            lblnom.Text = nom;
            lblDateTitre.Text = RecupDateHeureVisite;

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

            /* GESTION ETOILES AVANT VISITE */

        }

        private void btnSauvegarderVisite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
