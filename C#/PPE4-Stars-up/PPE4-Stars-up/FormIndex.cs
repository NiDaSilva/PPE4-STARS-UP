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
using AutoItX3Lib;

namespace PPE4_Stars_up
{
    public partial class FormIndex : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();

        private MySqlDataAdapter mySqlDataAdapterTP7 = new MySqlDataAdapter();
        private DataSet dataSetTP7 = new DataSet();
        private DataView dv_specialite = new DataView();

        ScreenCapture capScreen = new ScreenCapture();

        AutoItX3 au3 = new AutoItX3();

        int XX, YY;


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

            InputBox("Connexion à la base de données..", "");

            controleur.Vmodele.seconnecter();

            if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
            {
                MessageBox.Show("La connexion n'a pas eu lieu", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
            }
            else  // sinon
            {
                InputBox("Connecté. Exportation des données..", "");

                // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur

                InputBox("Données exportées. Déconnexion..", "");

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

            if (importToolStripMenuItem.Text == "Export")
            {
                InputBox("Connexion à la base de données..", "");

                controleur.Vmodele.seconnecter();

                if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
                {
                    MessageBox.Show("La connexion n'a pas eu lieu", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
                }
                else  // sinon
                {
                    InputBox("Connecté. Exportation des données..", "");

                    // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur
                    
                    InputBox("Données exportées. Déconnexion..", "");

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

            if (importToolStripMenuItem.Text == "Import")
            {
                InputBox("Connexion à la base de données..", "");

                controleur.init();
                controleur.Vmodele.seconnecter();

                if (controleur.Vmodele.Connopen == false)
                {
                    MessageBox.Show("La connexion n'a pas eu lieu.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InputBox("Connecté. Importation des données..", "");

                    // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controleur.Vmodele.import();

                    InputBox("Données importées. Déconnexion..", "");

                    controleur.Vmodele.sedeconnecter();

                    importToolStripMenuItem.Text = "Export";
                    planningToolStripMenuItem.Enabled = true;
                    historiqueDesVisitesToolStripMenuItem.Enabled = true;
                    imprimerPDFToolStripMenuItem.Enabled = true;
                    quitterToolStripMenuItem.Enabled = true;

                    lblSpecialite.Text = controleur.Vmodele.Dv_specialite.ToTable().Rows[0][0].ToString() + "\n"; // Récupère la spécialité 
                    lblInspecteur.Text = controleur.Vmodele.Dv_inspecteur.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nom et prénom de l'inspecteur 
                    lblNbVisiteTotal.Text = controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nombre total de visite de l'inspecteur 
                    lblNbVisitePassees.Text = controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nombre de visite passées de l'inspecteur 
                    lblNbVisiteToday.Text = controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nombre de visite prévue aujourd'hui de l'inspecteur 
                    lblNbVisitePasseeNonRemplie.Text = controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nombre de visite passées non évaluées de l'inspecteur
                    lblNbVisitePrevue.Text = controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString() + "\n"; // Récupère le nombre de visite prévue de l'inspecteur 

                    MAJHeure();

                    ecrireFichier();
                }
            }
        }

        private void FormIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exportation des données

            InputBox("Connexion à la base de données..", "");

            controleur.Vmodele.seconnecter();

            if (controleur.Vmodele.Connopen == false)  // si la connexion échoue : propriété connopen de vmmodele à faux
            {
                MessageBox.Show("La connexion n'a pas eu lieu", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);  // messageBox d’erreur
            }
            else  // sinon
            {
                InputBox("Connecté. Exportation des données..", "");

                // MessageBox.Show("Connexion à la base de donnée effectuée avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controleur.Vmodele.export();  // appel de la méthode export() via Vmodele du controleur

                InputBox("Données exportées. Déconnexion..", "");

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

            if (importToolStripMenuItem.Text == "Export")
            {
                lblInfoNbVisiteTotal.Visible = true;
                lblNbVisiteTotal.Visible = true;

                if(controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_total.ToTable().Rows[0][0].ToString() == "1")
                {
                    lbldont.Text = "visite dont :";
                }
                else
                {
                    lbldont.Text = "visites dont :";
                }

                lbldont.Visible = true;

                lblTiret.Visible = true;
                lblNbVisitePassees.Visible = true;
                lblPassees.Visible = true;

                lblTiret2.Visible = true;
                lblNbVisiteToday.Visible = true;

                if (controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_today.ToTable().Rows[0][0].ToString() == "1")
                {
                    lblToday.Text = "est prévue aujourd'hui.";
                }
                else
                {
                    lblToday.Text = "sont prévues aujourd'hui.";
                }

                lblToday.Visible = true;
                
                if(controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "0")
                {
                    lblNbVisitePasseeNonRemplie.Visible = false;
                    lblPasseeNonEvaluee.Visible = false;

                    if (controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPassees.Text = "est passée.";
                    }
                    else
                    {
                        lblPassees.Text = "sont passées.";
                    }
                }
                else
                {
                    lblNbVisitePasseeNonRemplie.Visible = true;

                    if (controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee_non_evaluee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPasseeNonEvaluee.Text = "reste non évaluée.";
                    }
                    else
                    {
                        lblPasseeNonEvaluee.Text = "reste non évaluées.";
                    }

                    lblPasseeNonEvaluee.Visible = true;

                    if (controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_passee.ToTable().Rows[0][0].ToString() == "1")
                    {
                        lblPassees.Text = "est passée mais";
                    }
                    else
                    {
                        lblPassees.Text = "sont passées mais";
                    }
                }


                lblTiret4.Visible = true;
                lblNbVisitePrevue.Visible = true;

                if (controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString() == "0" || controleur.Vmodele.Dv_nb_visite_prevue.ToTable().Rows[0][0].ToString() == "1")
                {
                    lblPrevue.Text = "est prévue dans les jours à venir.";
                }
                else
                {
                    lblPrevue.Text = "sont prévues dans les jours à venir.";
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
            timerHHmm.Start();

            chargedgv();
            Background();
            MAJHeure();
            
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
            FormHistorique FH = new FormHistorique();
            FH.MdiParent = this;

            FH.Show();
        }

        private void imprimerPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pictureBox1.Visible = false;

            // On affiche le planning sur tout l'écran

            InputBox("Affichage maximisé du planning..", "");

            FormPlanningJour FPJPDF = new FormPlanningJour();
            FPJPDF.WindowState = FormWindowState.Maximized;
            FPJPDF.Show();
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
            string lines = lblSpecialite.Text;
            System.IO.File.AppendAllText(@"C:\PPE4_DR\Preferences_PPE4_DR.txt", lines);
        }

        private void FormIndex_MouseHover(object sender, EventArgs e)
        {

        }

        private void FormIndex_Activated(object sender, EventArgs e)
        {

        }

        private void pbAllemagne_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Langage en cours de traduction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbFrance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Langage en cours de traduction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbAngleterre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Langage en cours de traduction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerHHmm_Tick(object sender, EventArgs e)
        {
            MAJHeure();
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
    }
}
