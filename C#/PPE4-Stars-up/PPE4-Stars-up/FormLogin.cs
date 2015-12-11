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

namespace PPE4_Stars_up
{
    public partial class FormLogin : Form
    {
       // public static Cursor IBeam { get; }
        // public static Cursor Default { get; }
        // public bool IsBalloon { get; set; }
        // public Brush BorderBrush { get; set; } // fonctionne pas 

        public int click = 0;
        public int click3 = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FormIndex FI = new FormIndex();
            FI.Show();
            Visible = false;            
        }

        private void FormLogin_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbNom_Click(object sender, EventArgs e)
        {
            tbNom.Clear();

            tbNom.Clear(); // Palatino Linotype; 12pt; style=Bold
            // tbNom.Cursor = IBeam;
            tbNom.ForeColor = Color.Black;
            click = 1;

            if (tbMdp.Text == "")
            {
                tbMdp.ForeColor = Color.DarkGray;
                tbMdp.Clear();

                tbMdp.ForeColor = Color.DarkGray;
                // tbMdp.Cursor = Default;
                tbMdp.Text = "Nom";
                click3 = 0;
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
    }
}