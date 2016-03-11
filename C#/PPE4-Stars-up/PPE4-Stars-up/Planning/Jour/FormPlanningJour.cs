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
using System.Xml.Serialization;

namespace PPE4_Stars_up
{
    public partial class FormPlanningJour : Form
    {
        List<CalendarItem> _items = new List<CalendarItem>();
        CalendarItem contextItem = null;

        string nbEtoile;
        string test;

        private BindingSource bindingSource1 = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();

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

            string element0 = "";
            string element1 = "";
            string element2 = "";
            string element3 = "";
            string element4 = "";
            string element5 = "";

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
                }
            }

            // MessageBox.Show("element1 : " + element1);
            // MessageBox.Show("element2 : " + element2);
            // MessageBox.Show("element3 : " + element3);
            // MessageBox.Show("element4 : " + element4);
            // MessageBox.Show("element5 : " + element5);

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

            // Envoie vers la nouvelle form

            FormVisite FV = new FormVisite(element1, element2, element3, element4, element5, nbEtoile);
            FV.MdiParent = this.MdiParent;
            FV.Show();
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

            
            // TEST AJOUT ITEM EN DUR

            /*
            DateTime date = new DateTime(2016, 1, 02);
            TimeSpan time = new TimeSpan(9, 0, 0);
            TimeSpan time2 = new TimeSpan(10, 0, 0);
            string test = string.Format("{0}", date.ToString("dd-MM-yyyy")).Trim();
            string test2 = string.Format("{0}", time.Hours).Trim();
            string test3 = string.Format("{0}", time2.Hours).Trim();

            string test4 = string.Format("{0} {1}", test, time).Trim();
            string test5 = string.Format("{0} {1}", test, time2).Trim();

            
            MessageBox.Show("date : " + test);
            MessageBox.Show("heure debut : " + test2);
            MessageBox.Show("heure fin : " + test3);
            

            CalendarItem cal = new CalendarItem(calendar1, Convert.ToDateTime(test4), Convert.ToDateTime(test5), "test"); 

            _items.Add(cal);

            PlaceItems();
            */

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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormIndex form = (FormIndex)this.MdiParent;
            form.HistoriqueDesVisitesToolStripMenuItem.Enabled = true;
            form.PlanningToolStripMenuItem.Enabled = true;

            this.Close();
        }
    }
}
