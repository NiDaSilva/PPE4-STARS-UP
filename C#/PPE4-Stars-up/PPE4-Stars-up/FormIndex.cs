using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace PPE4_Stars_up
{
    public partial class FormIndex : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();

        private MySqlDataAdapter mySqlDataAdapterTP7 = new MySqlDataAdapter();
        private DataSet dataSetTP7 = new DataSet();
        private DataView dv_specialite = new DataView();

        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        ScreenCapture capScreen = new ScreenCapture();

        // int XX, YY;


        // creation d’une liste des logins inspecteurs
        List<KeyValuePair<int, string>> FListSpe = new List<KeyValuePair<int, string>>();

        string NI, PI;
        int II;

        public int II1
        {
            get
            {
                return II;
            }

            set
            {
                II = value;
            }
        }
        
        public FormIndex(string nomInspecteur, string prenomInspecteur, int idInspecteur)
        {
            InitializeComponent();
            
            NI = nomInspecteur;
            PI = prenomInspecteur;
            II = idInspecteur;

        }

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
            // Exportation des données

            if (AffichageInputBox() == "Oui")
            {
                InputBox(LangueElement[35], "");
            }

            controleur.Vmodele.seconnecter();

            if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
            {
                MessageBox.Show(LangueElement[36], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
            }
            else  // sinon
            {
                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[37], "");
                }

                // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur

                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[39], "");
                }

                controleur.Vmodele.sedeconnecter();  // se déconnecter de la BD.

                planningToolStripMenuItem.Enabled = false;
                historiqueDesVisitesToolStripMenuItem.Enabled = false;
                imprimerPDFToolStripMenuItem.Enabled = false;
                quitterToolStripMenuItem.Enabled = false;

                timerHHmm.Stop();
                Visible = false;

                FormLogin FL = new FormLogin();
                FL.Show();
            }
        }

        private void FormIndex_Enter(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Il faut gérer l'export avant l'import car dans le cas contraire, l'import s'effectue et change de nom en "export" ce qui declenche la condition

            // Gestion de l'export

            if (importToolStripMenuItem.Text == LangueElement[13])
            {
                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[35], "");
                }

                controleur.Vmodele.seconnecter();

                if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
                {
                    MessageBox.Show(LangueElement[36], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
                }
                else  // sinon
                {
                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[37], "");
                    }

                    // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur

                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[39], "");
                    }

                    controleur.Vmodele.sedeconnecter();  // se déconnecter de la BD.
                    
                    planningToolStripMenuItem.Enabled = false;
                    historiqueDesVisitesToolStripMenuItem.Enabled = false;
                    imprimerPDFToolStripMenuItem.Enabled = false;
                    quitterToolStripMenuItem.Enabled = false;

                    timerHHmm.Stop();
                    Visible = false;

                    FormLogin FL = new FormLogin();
                    FL.Show();
                }
            }


            // Gestion de l'import

            if (importToolStripMenuItem.Text == LangueElement[12])
            {
                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[35], "");
                }

                controleur.init();
                controleur.Vmodele.seconnecter();

                if (controleur.Vmodele.Connopen == false)
                {
                    MessageBox.Show(LangueElement[36], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[38], "");
                    }

                    // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controleur.Vmodele.import();

                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[40], "");
                    }

                    controleur.Vmodele.sedeconnecter();

                    importToolStripMenuItem.Text = LangueElement[13];
                    planningToolStripMenuItem.Enabled = true;
                    historiqueDesVisitesToolStripMenuItem.Enabled = true;
                    imprimerPDFToolStripMenuItem.Enabled = true;
                    quitterToolStripMenuItem.Enabled = true;

                    lblSpecialite.Text = controleur.Vmodele.Dv_specialite.ToTable().Rows[0][0].ToString(); // Récupère la spécialité 
                    lblInspecteur.Text = controleur.Vmodele.Dv_inspecteur.ToTable().Rows[0][0].ToString(); // Récupère le nom et prénom de l'inspecteur 
                    lblNbVisiteTotal.Text = controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString(); // Récupère le nombre total de visite de l'inspecteur 
                    lblNbVisitePassees.Text = controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString(); // Récupère le nombre de visite passées de l'inspecteur 
                    lblNbVisiteToday.Text = controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString(); // Récupère le nombre de visite prévue aujourd'hui de l'inspecteur 
                    lblNbVisitePasseeNonRemplie.Text = controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString(); // Récupère le nombre de visite passées non évaluées de l'inspecteur
                    lblNbVisitePrevue.Text = controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString(); // Récupère le nombre de visite prévue de l'inspecteur 

                    MAJHeure();

                    ecrireFichier();
                }
            }
        }

        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exportation des données

            if (AffichageInputBox() == "Oui")
            {
                InputBox(LangueElement[35], "");
            }

            controleur.Vmodele.seconnecter();

            if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
            {
                MessageBox.Show(LangueElement[36], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
            }
            else  // sinon
            {
                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[37], "");
                }

                // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur

                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[39], "");
                }

                controleur.Vmodele.sedeconnecter();  // se déconnecter de la BD.

                planningToolStripMenuItem.Enabled = false;
                historiqueDesVisitesToolStripMenuItem.Enabled = false;
                imprimerPDFToolStripMenuItem.Enabled = false;
                quitterToolStripMenuItem.Enabled = false;

                timerHHmm.Stop();
                Visible = false;

                FormLogin FL = new FormLogin();
                FL.Show();

                // Application.Exit();
            }

        }

        private void semaineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historiqueDesVisitesToolStripMenuItem.Enabled = false;
            planningToolStripMenuItem.Enabled = false;
            pictureBox1.Visible = false;
            pbAllemagne.Visible = false;
            pbAngleterre.Visible = false;
            pbFrance.Visible = false;
            pbEspagne.Visible = false;
            FormPlanningJour FPJ = new FormPlanningJour();
            FPJ.MdiParent = this;

            FPJ.Show();
        }

        public void Background()
        {
            pictureBox1.Visible = true;
            var pos = this.PointToScreen(lblinfo.Location);
            pos = pictureBox1.PointToClient(pos);
            lblinfo.Parent = pictureBox1;
            lblinfo.Location = pos;
            lblinfo.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(lblInspecteur.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            lblInspecteur.Parent = pictureBox1;
            lblInspecteur.Location = pos2;
            lblInspecteur.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(lblinfo2.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            lblinfo2.Parent = pictureBox1;
            lblinfo2.Location = pos3;
            lblinfo2.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(lblSpecialite.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            lblSpecialite.Parent = pictureBox1;
            lblSpecialite.Location = pos4;
            lblSpecialite.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(lblheure.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            lblheure.Parent = pictureBox1;
            lblheure.Location = pos6;
            lblheure.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(lblDate.Location);
            pos7 = pictureBox1.PointToClient(pos7);
            lblDate.Parent = pictureBox1;
            lblDate.Location = pos7;
            lblDate.BackColor = Color.Transparent;

            pbAllemagne.Visible = true;
            pbAngleterre.Visible = true;
            pbFrance.Visible = true;
            pbEspagne.Visible = true;

            var pos8 = this.PointToScreen(lblInfoNbVisiteTotal.Location);
            pos8 = pictureBox1.PointToClient(pos8);
            lblInfoNbVisiteTotal.Parent = pictureBox1;
            lblInfoNbVisiteTotal.Location = pos8;
            lblInfoNbVisiteTotal.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(lblNbVisiteTotal.Location);
            pos9 = pictureBox1.PointToClient(pos9);
            lblNbVisiteTotal.Parent = pictureBox1;
            lblNbVisiteTotal.Location = pos9;
            lblNbVisiteTotal.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(lbldont.Location);
            pos10 = pictureBox1.PointToClient(pos10);
            lbldont.Parent = pictureBox1;
            lbldont.Location = pos10;
            lbldont.BackColor = Color.Transparent;

            var pos11 = this.PointToScreen(lblTiret.Location);
            pos11 = pictureBox1.PointToClient(pos11);
            lblTiret.Parent = pictureBox1;
            lblTiret.Location = pos11;
            lblTiret.BackColor = Color.Transparent;

            var pos12 = this.PointToScreen(lblNbVisitePassees.Location);
            pos12 = pictureBox1.PointToClient(pos12);
            lblNbVisitePassees.Parent = pictureBox1;
            lblNbVisitePassees.Location = pos12;
            lblNbVisitePassees.BackColor = Color.Transparent;

            var pos13 = this.PointToScreen(lblPassees.Location);
            pos13 = pictureBox1.PointToClient(pos13);
            lblPassees.Parent = pictureBox1;
            lblPassees.Location = pos13;
            lblPassees.BackColor = Color.Transparent;

            var pos14 = this.PointToScreen(lblTiret2.Location);
            pos14 = pictureBox1.PointToClient(pos14);
            lblTiret2.Parent = pictureBox1;
            lblTiret2.Location = pos14;
            lblTiret2.BackColor = Color.Transparent;

            var pos15 = this.PointToScreen(lblNbVisiteToday.Location);
            pos15 = pictureBox1.PointToClient(pos15);
            lblNbVisiteToday.Parent = pictureBox1;
            lblNbVisiteToday.Location = pos15;
            lblNbVisiteToday.BackColor = Color.Transparent;

            var pos16 = this.PointToScreen(lblToday.Location);
            pos16 = pictureBox1.PointToClient(pos16);
            lblToday.Parent = pictureBox1;
            lblToday.Location = pos16;
            lblToday.BackColor = Color.Transparent;

            var pos18 = this.PointToScreen(lblNbVisitePasseeNonRemplie.Location);
            pos18 = pictureBox1.PointToClient(pos18);
            lblNbVisitePasseeNonRemplie.Parent = pictureBox1;
            lblNbVisitePasseeNonRemplie.Location = pos18;
            lblNbVisitePasseeNonRemplie.BackColor = Color.Transparent;

            var pos19 = this.PointToScreen(lblPasseeNonEvaluee.Location);
            pos19 = pictureBox1.PointToClient(pos19);
            lblPasseeNonEvaluee.Parent = pictureBox1;
            lblPasseeNonEvaluee.Location = pos19;
            lblPasseeNonEvaluee.BackColor = Color.Transparent;

            var pos20 = this.PointToScreen(lblTiret4.Location);
            pos20 = pictureBox1.PointToClient(pos20);
            lblTiret4.Parent = pictureBox1;
            lblTiret4.Location = pos20;
            lblTiret4.BackColor = Color.Transparent;

            var pos21 = this.PointToScreen(lblNbVisitePrevue.Location);
            pos21 = pictureBox1.PointToClient(pos21);
            lblNbVisitePrevue.Parent = pictureBox1;
            lblNbVisitePrevue.Location = pos21;
            lblNbVisitePrevue.BackColor = Color.Transparent;

            var pos22 = this.PointToScreen(lblPrevue.Location);
            pos22 = pictureBox1.PointToClient(pos22);
            lblPrevue.Parent = pictureBox1;
            lblPrevue.Location = pos22;
            lblPrevue.BackColor = Color.Transparent;
        }

        public void MAJHeure()
        {
            // lblInspecteur.Text = NI + " " + PI;
            lblheure.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("ddd dd MMMM yyyy");

            if (importToolStripMenuItem.Text == LangueElement[13])
            {
                lblInfoNbVisiteTotal.Visible = true;
                lblNbVisiteTotal.Visible = true;

                if(controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString() == "1")
                {
                    lbldont.Text = LangueElement[24];
                }
                else
                {
                    lbldont.Text = LangueElement[23];
                }

                lbldont.Visible = true;

                lblTiret.Visible = true;
                lblNbVisitePassees.Visible = true;
                lblPassees.Visible = true;

                lblTiret2.Visible = true;
                lblNbVisiteToday.Visible = true;

                if (controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString() == "1")
                {
                    lblToday.Text = LangueElement[26];
                }
                else
                {
                    lblToday.Text = LangueElement[25];
                }

                lblToday.Visible = true;
                
                if(controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "0")
                {
                    lblNbVisitePasseeNonRemplie.Visible = false;
                    lblPasseeNonEvaluee.Visible = false;

                    if (controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPassees.Text = LangueElement[30];
                    }
                    else
                    {
                        lblPassees.Text = LangueElement[29];
                    }
                }
                else
                {
                    lblNbVisitePasseeNonRemplie.Visible = true;

                    if (controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPasseeNonEvaluee.Text = LangueElement[32];
                    }
                    else
                    {
                        lblPasseeNonEvaluee.Text = LangueElement[31];
                    }

                    lblPasseeNonEvaluee.Visible = true;

                    if (controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPassees.Text = LangueElement[28];
                    }
                    else
                    {
                        lblPassees.Text = LangueElement[27];
                    }
                }


                lblTiret4.Visible = true;
                lblNbVisitePrevue.Visible = true;

                if (controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString() == "1")
                {
                    lblPrevue.Text = LangueElement[34];
                }
                else
                {
                    lblPrevue.Text = LangueElement[33];
                }

                lblPrevue.Visible = true;
            }
            else
            {
                lblInfoNbVisiteTotal.Visible = false;
                lblNbVisiteTotal.Visible = false;
                lbldont.Visible = false;

                lblTiret.Visible = false;
                lblNbVisitePassees.Visible = false;
                lblPassees.Visible = false;

                lblTiret2.Visible = false;
                lblNbVisiteToday.Visible = false;
                lblToday.Visible = false;
                
                lblNbVisitePasseeNonRemplie.Visible = false;
                lblPasseeNonEvaluee.Visible = false;

                lblTiret4.Visible = false;
                lblNbVisitePrevue.Visible = false;
                lblPrevue.Visible = false;
            }
        }

        private void FormIndex_Load(object sender, EventArgs e)
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

            timerHHmm.Start();

            chargedgv();
            Background();
            MAJHeure();

            this.Text = LangueElement[11];
            importToolStripMenuItem.Text = LangueElement[12];
            planningToolStripMenuItem.Text = LangueElement[14];
            historiqueDesVisitesToolStripMenuItem.Text = LangueElement[15];
            imprimerPDFToolStripMenuItem.Text = LangueElement[16];
            paramètreToolStripMenuItem.Text = LangueElement[17];
            quitterToolStripMenuItem.Text = LangueElement[18];
            lblinfo.Text = LangueElement[19];
            lblInspecteur.Text = LangueElement[20];
            lblSpecialite.Text = LangueElement[20];
            lblinfo2.Text = LangueElement[21];
            lblInfoNbVisiteTotal.Text = LangueElement[22];
            lbldont.Text = LangueElement[23];
            lblToday.Text = LangueElement[25];
            lblPassees.Text = LangueElement[27];
            lblPasseeNonEvaluee.Text = LangueElement[31];
            lblPrevue.Text = LangueElement[33];

            // Gestion couleur background

            if (listeElement[6] != "Par défaut")
            {
                pictureBox1.BackgroundImage = null;

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
                    pictureBox1.BackgroundImage = PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
                }
            }
            else
            {
                pictureBox1.BackgroundImage = PPE4_Stars_up.Properties.Resources.Wallpaper_Gray_Bars_Opera;
            }

            FormLogin FL = new FormLogin();
        }

        private void historiqueDesVisitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historiqueDesVisitesToolStripMenuItem.Enabled = false;
            planningToolStripMenuItem.Enabled = false;
            pictureBox1.Visible = false;
            pbAllemagne.Visible = false;
            pbAngleterre.Visible = false;
            pbFrance.Visible = false;
            pbEspagne.Visible = false;
            FormHistorique FH = new FormHistorique();
            FH.MdiParent = this;

            FH.Show();
        }

        private void imprimerPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pictureBox1.Visible = false;

            // On affiche le planning sur tout l'écran

            if (AffichageInputBox() == "Oui")
            {
                InputBox(LangueElement[41], "");
            }

            FormPlanningJour FPJPDF = new FormPlanningJour();
            FPJPDF.WindowState = FormWindowState.Maximized;
            FPJPDF.ShowDialog();
            // FPJPDF.Show();
        }

        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave
                (@"C:\Temp\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void chargedgv()
        {

        }

        private void ecrireFichier()
        {
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            listeElement[2] = lblSpecialite.Text;

            /*
            if(listeElement.Count() < 3)
            {
                listeElement.Add(lblSpecialite.Text);
            }
            else
            {
                listeElement[2] = lblSpecialite.Text;
            }
            */

            StreamWriter writer = new StreamWriter(fileName2);
            foreach (var item in listeElement)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }

        private void FormIndex_MouseHover(object sender, EventArgs e)
        {

        }

        private void FormIndex_Activated(object sender, EventArgs e)
        {

        }

        private void pbAllemagne_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if (listeElement[1] == "Allemand")
            {
                MessageBox.Show(LangueElement[43], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listeElement[1] = "Allemand";

                StreamWriter writer = new StreamWriter(fileName2);

                foreach (var item in listeElement)
                {
                    writer.WriteLine(item);
                }
                writer.Close();

                MessageBox.Show(LangueElement[47], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbFrance_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if(listeElement[1] == "Francais")
            {
                MessageBox.Show(LangueElement[44], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listeElement[1] = "Francais";

                StreamWriter writer = new StreamWriter(fileName2);

                foreach (var item in listeElement)
                {
                    writer.WriteLine(item);
                }
                writer.Close();

                MessageBox.Show(LangueElement[47], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbAngleterre_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if (listeElement[1] == "Anglais")
            {
                MessageBox.Show(LangueElement[45], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listeElement[1] = "Anglais";

                StreamWriter writer = new StreamWriter(fileName2);

                foreach (var item in listeElement)
                {
                    writer.WriteLine(item);
                }
                writer.Close();

                MessageBox.Show(LangueElement[47], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerHHmm_Tick(object sender, EventArgs e)
        {
            MAJHeure();
        }

        private void pbEspagne_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(fileName2);
            string ligne;

            List<string> listeElement = new List<string>();
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                listeElement.Add(ligne);
            }
            reader.Close();

            if (listeElement[1] == "Espagnol")
            {
                MessageBox.Show(LangueElement[46], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listeElement[1] = "Espagnol";

                StreamWriter writer = new StreamWriter(fileName2);

                foreach (var item in listeElement)
                {
                    writer.WriteLine(item);
                }
                writer.Close();

                MessageBox.Show(LangueElement[47], LangueElement[42], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void paramètreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre FP = new FormParametre();
            // FP.Show();
            FP.ShowDialog();
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
                Thread.Sleep(10); // --> Timer au tick

                Progress.Value += 1;
                form.Show();
            }

            int Res = Progress.Value;
            if (Res == 100)
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
