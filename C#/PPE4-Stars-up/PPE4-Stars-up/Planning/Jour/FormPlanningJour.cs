using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PPE4_Stars_up
{
    public partial class FormPlanningJour : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;
        
        string FichierLangue = "";
        List<string> LangueElement = new List<string>();

        string fileName2 = @"C:\PPE4_DR\Preferences_PPE4_DR.txt";

        ScreenCapture capScreen = new ScreenCapture();

        string nbEtoile;
        string test;

        static string com;

        int compte = 0;
        int compte2 = 0;
        int iii = 0;
        
        int idI2;
        string test2;

        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private BindingSource bindingSource3 = new BindingSource();

        public FormPlanningJour()
        {
            InitializeComponent();
            chargedgv();

            //Monthview colors
            monthView1.MonthTitleColor = monthView1.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
            monthView1.ArrowsColor = CalendarColorTable.FromHex("#77A1D3");
            monthView1.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
            monthView1.DaySelectedTextColor = monthView1.ForeColor;
        }

        private void FormPlanningJour_Load(object sender, EventArgs e)
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

            this.Text = LangueElement[49];
            btnRetour.Text = LangueElement[50];

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
                this.BackColor = c;
                monthView1.BackColor = c;
            }
            else
            {
                this.BackgroundImage = null;
                monthView1.BackColor = SystemColors.Control;
            }


            if (WindowState == FormWindowState.Maximized)
            {
                btnRetour.Text = LangueElement[51];
                DialogResult DR = MessageBox.Show(LangueElement[52] + "\n" + LangueElement[66], LangueElement[53], MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                
                if(DR == DialogResult.OK)
                {
                    // il selectionne
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                btnRetour.Text = LangueElement[50];
            }

            if (ItemsFile.Exists)
            {
                List<ItemInfo> lst = new List<ItemInfo>();

                XmlSerializer xml = new XmlSerializer(lst.GetType());

                using (Stream s = ItemsFile.OpenRead())
                {
                    lst = xml.Deserialize(s) as List<ItemInfo>;
                }

                foreach (ItemInfo item in lst)
                {
                    CalendarItem cal = new CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text);

                    if (!(item.R == 0 && item.G == 0 && item.B == 0))
                    {
                        cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
                    }

                    _items.Add(cal);
                }

                PlaceItems();
            }
        }

        public FileInfo ItemsFile
        {
            get
            {
                return new FileInfo(Path.Combine(Application.StartupPath, "items.xml"));
            }
        }

        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            // _items.Add(e.Item);
        }

        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show(e.Item.Text);
        }

        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.SixMinutes;
        }

        private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            calendar1.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calendar1.ActivateEditMode();
        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<ItemInfo> lst = new List<ItemInfo>();

            foreach (CalendarItem item in _items)
            {
                lst.Add(new ItemInfo(item.StartDate, item.EndDate, item.Text, item.BackgroundColor));
            }

            XmlSerializer xmls = new XmlSerializer(lst.GetType());

            if (ItemsFile.Exists)
            {
                ItemsFile.Delete();
            }

            using (Stream s = ItemsFile.OpenWrite())
            {
                xmls.Serialize(s, lst);
                s.Close();
            }
        }

        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            

            // MessageBox.Show("Texte : " + e.Item.Text)
            // MessageBox.Show("Date avant : " + e.Item.Date);

            // 11/03/2016 10:00:00

            bindingSource3.DataSource = controleur.Vmodele.Dv_maj_etoile_commentaire;
            dGMaj.DataSource = bindingSource3;

            string element0 = "";
            string element1 = "";
            string element2 = "";
            string element3 = "";
            string element4 = "";
            string element5 = "";
            string element6 = "";

            string DateComplete = string.Format("{0}", e.Item.Date.ToString("dd/MM/yyyy HH:mm:ss")).Trim(); // recupere date
            // MessageBox.Show("Date apres : " + DateComplete);

            for (int i = 0; i < dataGridViewPersonnes.Rows.Count; i++) // parcours le datagridview
            {
                if (dataGridViewPersonnes.Rows[i].Cells[4].Value.ToString() == DateComplete)
                {
                    element0 = dataGridViewPersonnes.Rows[i].Cells[0].Value.ToString(); // recupere ID
                    element1 = dataGridViewPersonnes.Rows[i].Cells[1].Value.ToString(); // recupere NOM
                    element2 = dataGridViewPersonnes.Rows[i].Cells[2].Value.ToString(); // recupere Adresse
                    element3 = dataGridViewPersonnes.Rows[i].Cells[3].Value.ToString(); // recupere Ville
                    element4 = dataGridViewPersonnes.Rows[i].Cells[4].Value.ToString(); // recupere Date --> DateComplete
                    element5 = dataGridViewPersonnes.Rows[i].Cells[5].Value.ToString(); // recupere Horaires
                    element6 = dataGridViewPersonnes.Rows[i].Cells[6].Value.ToString(); // recupere Horaires
                }
            }

            // MessageBox.Show("element1 : " + element1);
            // MessageBox.Show("element2 : " + element2);
            // MessageBox.Show("element3 : " + element3);
            // MessageBox.Show("element4 : " + element4);
            // MessageBox.Show("element5 : " + element5);
            // MessageBox.Show("Commentaire : " + element6);

            bindingSource2.DataSource = controleur.Vmodele.Dv_NbEtoiles;
            dataGridViewNbEtoiles.DataSource = bindingSource2;

            for (int i = 0; i < dataGridViewNbEtoiles.Rows.Count; i++) // parcours le datagridview
            {
                if (dataGridViewNbEtoiles.Rows[i].Cells[0].Value.ToString() == element0 && dataGridViewNbEtoiles.Rows[i].Cells[2].Value.ToString() != "")
                {
                    nbEtoile = dataGridViewNbEtoiles.Rows[i].Cells[2].Value.ToString();
                    break;
                }
            }

            // MessageBox.Show(nbEtoile);

            compte = 0;
            compte2 = 0;

            for (int i = 0; i < dGMaj.Rows.Count; i++) // parcours le datagridview
            {
                if (dGMaj.Rows[i].Cells[0].Value.ToString() == recup().ToString() && dGMaj.Rows[i].Cells[1].Value.ToString() == element0)
                {
                    // recupere valeur de compte ce qui nous donne l'index
                    compte2 = compte;
                }
                else
                {
                    compte++;
                }
            }

            if(iii == 0)
            {
                com = controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["COMMENTAIRE_VISITE"].ToString();
            }

            iii++;

            // MessageBox.Show(controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["COMMENTAIRE_VISITE"].ToString());


            if (controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["COMMENTAIRE_VISITE"].ToString() != "")
            {
                if (com != controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["COMMENTAIRE_VISITE"].ToString())
                {
                    DialogResult DR = MessageBox.Show(LangueElement[54] + "\n\n" + LangueElement[67] + controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["COMMENTAIRE_VISITE"].ToString() + "\n" + LangueElement[55] + controleur.Vmodele.Dv_maj_etoile_commentaire[compte2]["NOMBRE_ETOILE_VISITE"].ToString() + "\n\n" + LangueElement[56] + "\n\n" + LangueElement[68], LangueElement[57], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DR == DialogResult.Yes)
                    {
                        // Envoie vers la nouvelle form

                        compte = 0;
                        compte2 = 0;

                        FormVisite FV = new FormVisite(element1, element2, element3, element4, element5, element6, nbEtoile, element0);
                        FV.MdiParent = this.MdiParent;
                        FV.Show();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    compte = 0;
                    compte2 = 0;

                    FormVisite FV = new FormVisite(element1, element2, element3, element4, element5, element6, nbEtoile, element0);
                    FV.MdiParent = this.MdiParent;
                    FV.Show();
                }
            }
            else
            {
                compte = 0;
                compte2 = 0;

                FormVisite FV = new FormVisite(element1, element2, element3, element4, element5, element6, nbEtoile, element0);
                FV.MdiParent = this.MdiParent;
                FV.Show();
            }
        }

        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            // _items.Remove(e.Item);
        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }

        private void diagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Vertical;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.Horizontal;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Red;
                calendar1.Invalidate(item);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.Pattern = System.Drawing.Drawing2D.HatchStyle.DiagonalCross;
                item.PatternColor = Color.Empty;
                calendar1.Invalidate(item);
            }
        }

        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(monthView1.SelectionStart, monthView1.SelectionEnd);
        }

        private void northToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.North;
                calendar1.Invalidate(item);
            }
        }

        private void eastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.East;
                calendar1.Invalidate(item);
            }
        }

        private void southToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.South;
                calendar1.Invalidate(item);
            }
        }

        private void westToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ImageAlign = CalendarItemImageAlign.West;
                calendar1.Invalidate(item);
            }
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "*.gif|*.gif|*.png|*.png|*.jpg|*.jpg";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    Image img = Image.FromFile(dlg.FileName);

                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.Image = img;
                        calendar1.Invalidate(item);
                    }
                }
            }
        }

        private void btnRetourSuggestion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void chargedgv()
        {
            lireFichier();

            bindingSource1.DataSource = controleur.Vmodele.Dv_visite;
            dataGridViewPersonnes.DataSource = bindingSource1;

            for (int i = 0; i < dataGridViewPersonnes.Rows.Count; i++) // parcours le datagridview
            {
                DateTime DateEntiere = Convert.ToDateTime(dataGridViewPersonnes.Rows[i].Cells[4].Value.ToString()); // recupere date + heure
                string DateSeulement = string.Format("{0}", DateEntiere.ToString("dd-MM-yyyy")).Trim(); // recupere date
                TimeSpan HeureDebutEntiere = new TimeSpan(DateEntiere.Hour, DateEntiere.Minute, DateEntiere.Second); // recupere heure, minute, seconde
                TimeSpan HeureFinEntiere = new TimeSpan(Convert.ToInt32(HeureDebutEntiere.Hours) + 2, 0, 0);

                string HeureDebut = string.Format("{0} {1}", DateSeulement, HeureDebutEntiere).Trim(); // Bon format
                string HeureFin = string.Format("{0} {1}", DateSeulement, HeureFinEntiere).Trim(); // Bon format

                string commentaire = dataGridViewPersonnes.Rows[i].Cells[1].Value.ToString() + "\n"; // recupere NOM
                commentaire += dataGridViewPersonnes.Rows[i].Cells[2].Value.ToString() + "\n"; // recupere Adresse
                commentaire += dataGridViewPersonnes.Rows[i].Cells[3].Value.ToString(); // recupere Ville

                // MessageBox.Show("debut : " + HeureDebutSeulement + "/nFin : " + HeureFin);
                CalendarItem cal = new CalendarItem(calendar1, Convert.ToDateTime(HeureDebut), Convert.ToDateTime(HeureFin), commentaire);

                _items.Add(cal);

                PlaceItems();
            }

        }

        private void lireFichier()
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\PPE4_DR\Preferences_PPE4_DR.txt");

            test = lines[0].ToString();
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

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (btnRetour.Text == LangueElement[51])
            {
                // On appelle la fonction qui va prendre la capture du planning
                captureScreen();

                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[58], "");
                }


                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[59], "");
                }

                // On crée un nouveau document et une nouvelle page PDF
                PdfDocument doc = new PdfDocument();
                PdfPage oPage = new PdfPage();


                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[60], "");
                }

                // oPage.Size = PdfSharp.PageSize.A1;
                oPage.Size = PdfSharp.PageSize.Crown;

                // On ajoute la page au pdf et l'image au document
                doc.Pages.Add(oPage);
                XGraphics xgr = XGraphics.FromPdfPage(oPage);
                XImage img = XImage.FromFile(@"C:\Temp\test.png");

                xgr.DrawImage(img, 0, 0);

                // 210*297mm PDF


                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[61], "");
                }

                saveFileDialog.Filter = ("PDF File|*.pdf");
                DialogResult btnSave = saveFileDialog.ShowDialog();
                if (btnSave.Equals(DialogResult.OK))
                {

                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[62], "");
                    }

                    doc.Save(saveFileDialog.FileName);


                    if (AffichageInputBox() == "Oui")
                    {
                        InputBox(LangueElement[63], "");
                    }

                    doc.Close();

                }


                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[64], "");
                }

                // Pour parré aux erreurs éventuelles
                img.Dispose();


                if (AffichageInputBox() == "Oui")
                {
                    InputBox(LangueElement[65], "");
                }
                /*
                //FormIndex form = (FormIndex)this.MdiParent;
                FormIndex form = new FormIndex();

                form.Background();
                form.MAJHeure();
                */
                this.Close();
            }
            else
            {
                FormIndex form = (FormIndex)this.MdiParent;
                form.HistoriqueDesVisitesToolStripMenuItem.Enabled = true;
                form.PlanningToolStripMenuItem.Enabled = true;
                form.Background();
                form.MAJHeure();
                this.Close();
            }            
        }

        private void lireFichier2()
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

                    test2 = line.ToString();
                }
            }

            file.Close();

            // test = lines[0].ToString();
        }

        public int recup()
        {
            // Id de l'inspecteur connecté

            lireFichier2();
            idI2 = Convert.ToInt32(test2);
            return idI2;
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
