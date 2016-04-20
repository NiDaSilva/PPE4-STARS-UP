using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4_Stars_up
{
    class controleur
    {
        private static bdd vmodele;
        static int idI;
        static string test;

        static string FichierLangue = "";
        static List<string> LangueElement = new List<string>();

        static string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        public static bdd Vmodele
        {
            get { return controleur.vmodele; }
            set { controleur.vmodele = value; }
        }

        public static void init()
        {
            vmodele = new bdd();
        }

        public static void modif_bdd(Char c, string commentaire, int nb_Etoile, int index2) // String cle, 
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

            // Le Char c correspond à l'action : c:create, u update, d delete,
            // la cle est celle de l'enregistrement sélectionné, vide si action d’ajout (c = ‘c’)
            int index = 0;
            
            if (c == 'u') // modif
            {
                /*
                string sortExpression = "ID_INSPECTEUR";
                vmodele.Dv_maj_etoile_commentaire.Sort = sortExpression; // on trie le DataView sur les ID_HEBERGEMENT
                                                                    // on recherche l’indice où se trouve l'inspecteur sélectionné
                                                                    // grâce à la valeur passée en paramètre donc grâce à son Id
*/
                // MessageBox.Show(recup().ToString());

                index = recup() - 1;
                // index = vmodele.Dv_login.Find(recup());
                // on remplit les zones par les valeurs du dataView correspondantes

                /*
                MessageBox.Show("Nom : " + vmodele.Dv_login[index][2].ToString());
                MessageBox.Show("Prénom : " + vmodele.Dv_login[index][3].ToString());
                MessageBox.Show("Login : " + vmodele.Dv_login[index][4].ToString());
                MessageBox.Show("Mdp : " + vmodele.Dv_login[index][5].ToString());
                */

                // MessageBox.Show("Etoile avant : " + vmodele.Dv_maj_etoile_commentaire[index2]["NOMBRE_ETOILE_VISITE"].ToString());
                // MessageBox.Show("Commentaire avant : " + vmodele.Dv_maj_etoile_commentaire[index2]["COMMENTAIRE_VISITE"].ToString());

                // MessageBox.Show("Etoile apres : " + nb_Etoile.ToString());
                // MessageBox.Show("Commentaire apres : " + commentaire);


                // on met à jour le dataView avec les nouvelles valeurs
                vmodele.Dv_maj_etoile_commentaire[index2]["NOMBRE_ETOILE_VISITE"] = nb_Etoile;
                vmodele.Dv_maj_etoile_commentaire[index2]["COMMENTAIRE_VISITE"] = commentaire;
            }

            if (AffichageInputBox() == "Oui")
            {
                InputBox(LangueElement[88], "");
            }
            

            // MessageBox.Show("OK : données enregistrées");
        }

        public static string AffichageInputBox()
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

        private static void lireFichier()
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

        public static int recup()
        {
            // Id de l'inspecteur connecté

            lireFichier();
            idI = Convert.ToInt32(test);
            return idI;
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
                Thread.Sleep(15); // --> Timer au tick

                Progress.Value += 1;
                form.Show();
            }

            int Res = Progress.Value;
            if (Res == 100)
                form.Close();

            return Res;
        }
    }
}
