using System;
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
using System.Threading;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Security.Cryptography;

namespace PPE4_Stars_up
{
    public partial class FormLogin : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public int click = 0;
        public int click3 = 0;
        int countt = 0;

        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string langue = "Francais";
        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        string family = "Gentium Basic";

        private string nomInspecteur;
        private string prenomInspecteur;
        private int idInspecteur;

        public int idINSP;

        // creation d’une liste des logins inspecteurs
        List<KeyValuePair<int, string>> FListLogin = new List<KeyValuePair<int, string>>();

        // creation d’une liste des mot de passe inspecteurs
        List<KeyValuePair<int, string>> FListMdp = new List<KeyValuePair<int, string>>();

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void creationFichier()
        {
            string curFile = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

            if(File.Exists(curFile))
            {
                // on fait rien
            }
            else
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

                List<string> listeElement = new List<string>();

                listeElement.Add(idINSP.ToString());
                listeElement.Add(langue);
                listeElement.Add("Spécialité");
                listeElement.Add("100");
                listeElement.Add("Oui");
                listeElement.Add("Oui");
                listeElement.Add("Par défaut");
                listeElement.Add("Par défaut");


                StreamWriter writer = new StreamWriter(fileName2);

                foreach (var item in listeElement)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
            }
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

            listeElement[0] = idINSP.ToString();

            StreamWriter writer = new StreamWriter(fileName2);
            foreach (var item in listeElement)
            {
                writer.WriteLine(item);
            }
            writer.Close();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (AffichageInputBox() == "Oui")
            {
                InputBox(LangueElement[4], "");
            }
            

            if (lbLogin.Items.Contains(tbNom.Text))
            {                
                // login correct 

                foreach(var o in lbLogin.Items)
                {
                    if(lbLogin.Items[countt].ToString() == tbNom.Text)
                    {

                    }
                    else
                    {
                        countt++;
                    }
                }

                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[5], "");
                }

                string mdp = "";

                // MessageBox.Show(countt2.ToString());

                // MD5

                /*
                using (MD5 md5Hash = MD5.Create())
                {
                    mdp = GetMd5Hash(md5Hash, tbMdp.Text);   
                }

                */

                // SHA1

                mdp = SHA1HashStringForUTF8String(tbMdp.Text);

                if (mdp == lbMdp.Items[countt].ToString()) 
                {
                    // mdp correct

                    #region confidentiel
                    if (tbNom.Text == "NGrondin")
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
                    #endregion confidentiel

                    ecrireFichier();

                    FormIndex FI = new FormIndex(nomInspecteur, prenomInspecteur, idInspecteur);
                    FI.Show();
                    Visible = false;
                }
                else
                {
                    // mdp incorrect

                    MessageBox.Show(LangueElement[6], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMdp.Clear();

                    tbMdp.ForeColor = Color.Black;

                    // tbMdp.ForeColor = Color.DarkGray;
                    tbMdp.Clear();

                    // tbMdp.ForeColor = Color.DarkGray;
                    // tbMdp.Cursor = Default;
                    // tbMdp.Text = "Mot de passe";
                    // cbAfficherMdp.Checked = false;

                    if(cbAfficherMdp.Checked==true)
                    {
                        tbMdp.PasswordChar = '\0';
                    }
                    else
                    {
                        tbMdp.PasswordChar = '*';
                    }                    
                }
            }
            else
            {
                // login incorrect

                MessageBox.Show(LangueElement[8], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbNom.Text = LangueElement[0];
            }
        }

        private void FormLogin_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // System.Diagnostics.Process monProcess = System.Diagnostics.Process.Start("CefSharp.BrowserSubprocess.exe");
            // monProcess.Kill();

            Process[] processesList = Process.GetProcessesByName("IHMCefSharp.BrowserSubprocess");

            foreach (Process p in processesList)
            {
                p.Kill();
            }

            Application.Exit();
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
                tbMdp.Text = LangueElement[1];
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
                MessageBox.Show(LangueElement[9], LangueElement[7], MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbNom.Clear();
            }
        }

        private void tbNom_Leave(object sender, EventArgs e)
        {
            if (tbNom.Text == LangueElement[0] || tbNom.Text == "" || tbNom.Text == " ")
            {
                tbNom.ForeColor = Color.DarkGray;

               // tbNom.Cursor = Default;
                tbNom.Text = LangueElement[0];
            }
        }

        private void tbMdp_Click(object sender, EventArgs e)
        {
            tbMdp.Clear();

            tbMdp.Clear(); // Palatino Linotype; 12pt; style=Bold
            // tbNom.Cursor = IBeam;
            tbMdp.ForeColor = Color.Black;

            if(cbAfficherMdp.Checked==false)
            {
                tbMdp.PasswordChar = '*';
            }

            if (tbNom.Text == "")
            {
                tbNom.ForeColor = Color.DarkGray;
                tbNom.Clear();

                tbNom.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbNom.Text = LangueElement[0];
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
            if (tbMdp.Text == LangueElement[1] || tbMdp.Text == "" || tbMdp.Text == " ")
            {
                tbMdp.ForeColor = Color.DarkGray;

                // tbNom.Cursor = Default;
                tbMdp.PasswordChar = '\0';
                tbMdp.Text = LangueElement[1];
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            creationFichier();

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

            if(listeElement[1] == "Francais")
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


            // Fin Gestion langue

            // Gestion transparence
            if (listeElement[3] != "")
            {
                Opacity = Convert.ToDouble(listeElement[3]);
            }

            pbCorrect1.Visible = false;
            pbCorrect2.Visible = false;
            pbIncorrect1.Visible = false;
            pbIncorrect2.Visible = false;

            Visible = true;
            this.ActiveControl = textBox1;

            controleur.init();
            controleur.Vmodele.seconnecter();

            controleur.Vmodele.import();
            controleur.Vmodele.sedeconnecter();

            chargedgv();


            tbNom.Text = LangueElement[0];
            tbMdp.Text = LangueElement[1];
            cbAfficherMdp.Text = LangueElement[2];
            this.Text = LangueElement[3];
            btnOK.Text = LangueElement[3];

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
                    this.BackgroundImage = PPE4_Stars_up.Properties.Resources.cool_washing_basic_collor_blue_black_rain_hd_wallpaper_112685;
                }
            }
            else
            {
                this.BackgroundImage = PPE4_Stars_up.Properties.Resources.cool_washing_basic_collor_blue_black_rain_hd_wallpaper_112685;
            }

            // Gestion Police

            if (listeElement[7] != "Par défaut")
            {
                try
                {
                    tbNom.Font = new Font(listeElement[7], tbNom.Font.SizeInPoints, tbNom.Font.Style);
                    tbMdp.Font = new Font(listeElement[7], tbMdp.Font.SizeInPoints, tbMdp.Font.Style);
                    cbAfficherMdp.Font = new Font(listeElement[7], cbAfficherMdp.Font.SizeInPoints, cbAfficherMdp.Font.Style);
                    btnOK.Font = new Font(listeElement[7], btnOK.Font.SizeInPoints, btnOK.Font.Style);
                }
                catch
                {
                    tbNom.Font = new Font(family, tbNom.Font.SizeInPoints, tbNom.Font.Style);
                    tbMdp.Font = new Font(family, tbMdp.Font.SizeInPoints, tbMdp.Font.Style);
                    cbAfficherMdp.Font = new Font(family, cbAfficherMdp.Font.SizeInPoints, cbAfficherMdp.Font.Style);
                    btnOK.Font = new Font(family, btnOK.Font.SizeInPoints, btnOK.Font.Style);
                }
            }
            else
            {
                tbNom.Font = new Font(family, tbNom.Font.SizeInPoints, tbNom.Font.Style);
                tbMdp.Font = new Font(family, tbMdp.Font.SizeInPoints, tbMdp.Font.Style);
                cbAfficherMdp.Font = new Font(family, cbAfficherMdp.Font.SizeInPoints, cbAfficherMdp.Font.Style);
                btnOK.Font = new Font(family, btnOK.Font.SizeInPoints, btnOK.Font.Style);
            }

        }

        public void chargedgv()
        {
            try
            {
                bindingSource1.DataSource = controleur.Vmodele.Dv_login;
                
                // on parcourt le dataView des inspecteurs Dv_login de la classe bdd pour compléter la FList
                for (int i = 0; i < controleur.Vmodele.Dv_login.ToTable().Rows.Count; i++)
                {
                    FListLogin.Add(new KeyValuePair<int, string>((int)controleur.Vmodele.Dv_login.ToTable().Rows[i][0], controleur.Vmodele.Dv_login.ToTable().Rows[i][4].ToString()));
                    // rtbLogin.Text += controleur.Vmodele.Dv_login.ToTable().Rows[i][4].ToString() + "\n";

                    lbLogin.Items.Add(controleur.Vmodele.Dv_login.ToTable().Rows[i][4].ToString());                    
                }

                for (int i = 0; i < controleur.Vmodele.Dv_login.ToTable().Rows.Count; i++)
                {
                    FListMdp.Add(new KeyValuePair<int, string>((int)controleur.Vmodele.Dv_login.ToTable().Rows[i][0], controleur.Vmodele.Dv_login.ToTable().Rows[i][5].ToString()));
                    // rtbMdp.Text += controleur.Vmodele.Dv_login.ToTable().Rows[i][5].ToString() + "\n";
                    lbMdp.Items.Add(controleur.Vmodele.Dv_login.ToTable().Rows[i][5].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Impossible de se connecter au serveur", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string SHA1HashStringForUTF8String(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            using (var sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(bytes);

                return HexStringFromBytes(hashBytes);
            }
        }

        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }

        private void cbAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAfficherMdp_Click(object sender, EventArgs e)
        {
            if (tbMdp.Text != LangueElement[1])
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
                Thread.Sleep(7); // --> Timer au tick

                Progress.Value += 1;
                form.Show();
            }

            int Res = Progress.Value;
            if (Res == 100)
                form.Close();

            return Res;
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            if (tbNom.Text != "")
            {
                if (lbLogin.Items.Contains(tbNom.Text))
                {
                    pbCorrect1.Visible = true;
                    pbIncorrect1.Visible = false;
                }
                else
                {
                    pbCorrect1.Visible = false;
                    pbIncorrect1.Visible = true;
                }
            }
        }

        private void tbMdp_TextChanged(object sender, EventArgs e)
        {
            int countt2 = 0;

            foreach (var o in lbLogin.Items)
            {
                if (lbLogin.Items[countt2].ToString() == tbNom.Text)
                {
                    // recupérer la valeur count
                    // MessageBox.Show(countt.ToString());   
                }
                else
                {
                    if(countt2 == 5)
                    {
                        countt2 = 0;
                    }

                    countt2++;
                }
            }

            if (tbMdp.Text != "")
            {

                string mdp = "";

                // MessageBox.Show(countt2.ToString());

                // MD5

                /*
                using (MD5 md5Hash = MD5.Create())
                {
                    mdp = GetMd5Hash(md5Hash, tbMdp.Text);   
                }

                */

                // SHA1

                mdp = SHA1HashStringForUTF8String(tbMdp.Text);
                
                if (mdp == lbMdp.Items[countt2].ToString())
                {
                    pbCorrect2.Visible = true;
                    pbIncorrect2.Visible = false;
                }
                else
                {
                    pbCorrect2.Visible = false;
                    pbIncorrect2.Visible = true;
                }
                
            }
        }
    }
}
