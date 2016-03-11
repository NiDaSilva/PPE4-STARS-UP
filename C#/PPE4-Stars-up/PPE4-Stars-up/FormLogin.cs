﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace PPE4_Stars_up
{
    public partial class FormLogin : Form
    {
       // public static Cursor IBeam { get; }
        // public static Cursor Default { get; }
        // public bool IsBalloon { get; set; }
        // public Brush BorderBrush { get; set; } // fonctionne pas 

        private BindingSource bindingSource1 = new BindingSource();
        public int click = 0;
        public int click3 = 0;

        private string nomInspecteur;
        private string prenomInspecteur;
        private int idInspecteur;

        public int idINSP;

        // creation d’une liste des logins inspecteurs
        List<KeyValuePair<int, string>> FListLogin = new List<KeyValuePair<int, string>>();

        // creation d’une liste des mot de passe inspecteurs
        List<KeyValuePair<int, string>> FListMdp = new List<KeyValuePair<int, string>>();



        public FormLogin()
        {
            InitializeComponent();
        }

        private void creationFichier()
        {
            string folderName = @"c:\";
            string pathString = System.IO.Path.Combine(folderName, "PPE4_DR");
            System.IO.Directory.CreateDirectory(pathString);
            string fileName = "Preferences_PPE4_DR.txt";
            pathString = System.IO.Path.Combine(pathString, fileName);


            Console.WriteLine("Path to my file: {0}\n", pathString);


            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Append))
            {

                for (byte i = 0; i < 100; i++)
                {
                    fs.WriteByte(i);
                }

            }

            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }

            string[] lines = { idINSP.ToString()};
            System.IO.File.WriteAllLines(@"C:\PPE4_DR\Preferences_PPE4_DR.txt", lines);
        }

        private void ecrireFichier()
        {
            idInspecteur = idINSP; 

            string[] lines = { idINSP.ToString() };
            System.IO.File.WriteAllLines(@"C:\PPE4_DR\Preferences_PPE4_DR.txt", lines);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (rtbLogin.Text.Contains(tbNom.Text))
            {
                if (rtbMdp.Text.Contains(tbMdp.Text))
                {
                    if(tbNom.Text == "NGrondin")
                    {
                        nomInspecteur = "Grondin";
                        prenomInspecteur = "Nicolas";
                        idInspecteur = 1;
                        idINSP = 1;
                    }

                    if (tbNom.Text == "NBouhours")
                    {
                        nomInspecteur = "Bouhours";
                        prenomInspecteur = "Natacha";
                        idInspecteur = 2;
                        idINSP = 2;
                    }

                    if (tbNom.Text == "NDSilva")
                    {
                        nomInspecteur = "Da Silva";
                        prenomInspecteur = "Nicolas";
                        idInspecteur = 3;
                        idINSP = 3;
                    }

                    if (tbNom.Text == "Drobin")
                    {
                        nomInspecteur = "Robin";
                        prenomInspecteur = "Dimitry";
                        idInspecteur = 4;
                        idINSP = 4;
                    }

                    if (tbNom.Text == "PHermange")
                    {
                        nomInspecteur = "Hermange";
                        prenomInspecteur = "Pierre";
                        idInspecteur = 5;
                        idINSP = 5;
                    }

                    if (tbNom.Text == "KMenant")
                    {
                        nomInspecteur = "Menant";
                        prenomInspecteur = "Kévin";
                        idInspecteur = 6;
                        idINSP = 6;
                    }
                    
                    ecrireFichier();

                    FormIndex FI = new FormIndex(nomInspecteur, prenomInspecteur, idInspecteur);
                    FI.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMdp.Clear();

                    tbMdp.ForeColor = Color.DarkGray;
                    tbMdp.Clear();

                    tbMdp.ForeColor = Color.DarkGray;
                    // tbMdp.Cursor = Default;
                    tbMdp.Text = "Mot de passe";
                    cbAfficherMdp.Checked = false;
                    tbMdp.PasswordChar = '\0';
                }
            }
            else
            {
                MessageBox.Show("Login incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbNom.Text = "Nom";
            }
        }

        private void FormLogin_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Application.Exit();

           // System.Diagnostics.Process monProcess = System.Diagnostics.Process.Start("CefSharp.BrowserSubprocess.exe");
            //monProcess.Kill();
        }

        private void tbNom_Click(object sender, EventArgs e)
        {
            tbNom.Clear();

            tbNom.Clear(); // Palatino Linotype; 12pt; style=Bold
            // tbNom.Cursor = IBeam;
            tbNom.ForeColor = Color.Black;

            if (tbMdp.Text == "")
            {
                tbMdp.ForeColor = Color.DarkGray;
                tbMdp.Clear();

                tbMdp.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbMdp.Text = "Mot de passe";
            }
        }

        private void tbNom_Enter(object sender, EventArgs e)
        {
            tbNom_Click(sender, e);
        }

        private void tbNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                MessageBox.Show("Vous devez entrer une chaîne de caractère !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNom.Clear();
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text == "Nom" || tbNom.Text == "" || tbNom.Text == " ")
            {
                tbNom.ForeColor = Color.DarkGray;

               // tbNom.Cursor = Default;
                tbNom.Text = "Nom";
            }
        }

        private void tbMdp_Click(object sender, EventArgs e)
        {
            tbMdp.Clear();

            tbMdp.Clear(); // Palatino Linotype; 12pt; style=Bold
            // tbNom.Cursor = IBeam;
            tbMdp.ForeColor = Color.Black;

            tbMdp.PasswordChar = '*';

            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbNom.Text = "Nom";
            }
        }

        private void tbMdp_Enter(object sender, EventArgs e)
        {
            tbMdp_Click(sender, e);
        }

        private void tbMdp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbMdp_Leave(object sender, EventArgs e)
        {
            if (tbMdp.Text == "Mot de passe" || tbMdp.Text == "" || tbMdp.Text == " ")
            {
                tbMdp.ForeColor = Color.DarkGray;

                // tbNom.Cursor = Default;
                tbMdp.PasswordChar = '\0';
                tbMdp.Text = "Mot de passe";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

            creationFichier();
            Visible = true;
            this.ActiveControl = textBox1;

            controleur.init();
            controleur.Vmodele.seconnecter();

            controleur.Vmodele.import();
            controleur.Vmodele.sedeconnecter();
            
            chargedgv();
        }

        public void chargedgv()
        {
            bindingSource1.DataSource = controleur.Vmodele.Dv_login;

            // on parcourt le dataView des inspecteurs Dv_login de la classe bdd pour compléter la FList
            for (int i = 0; i < controleur.Vmodele.Dv_login.ToTable().Rows.Count; i++)
            {
                FListLogin.Add(new KeyValuePair<int, string>((int)controleur.Vmodele.Dv_login.ToTable().Rows[i][0], controleur.Vmodele.Dv_login.ToTable().Rows[i][4].ToString()));
                rtbLogin.Text += controleur.Vmodele.Dv_login.ToTable().Rows[i][4].ToString() + "\n";
            }

            for (int i = 0; i < controleur.Vmodele.Dv_login.ToTable().Rows.Count; i++)
            {
                FListMdp.Add(new KeyValuePair<int, string>((int)controleur.Vmodele.Dv_login.ToTable().Rows[i][0], controleur.Vmodele.Dv_login.ToTable().Rows[i][5].ToString()));
                rtbMdp.Text += controleur.Vmodele.Dv_login.ToTable().Rows[i][5].ToString() + "\n";
            }
        }

        private void cbAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAfficherMdp_Click(object sender, EventArgs e)
        {
            if (tbMdp.Text != "Mot de passe")
            {
                if (cbAfficherMdp.Checked == true)
                {
                    tbMdp.PasswordChar = '\0';
                }
                else
                {
                    tbMdp.PasswordChar = '*';
                }
            }
        }

        private void tbMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}