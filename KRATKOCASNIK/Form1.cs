using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRATKOCASNIK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gmbPuzle_Click(object sender, EventArgs e)
        {
            FormPuzle igrajPuzle = new FormPuzle();
            igrajPuzle.Show();
        }

        private void gmbTekac_Click(object sender, EventArgs e)
        {
            FormTekac igrajTekac = new FormTekac();
            MessageBox.Show("Igro igraš tako, da s tipko space, tekač preskoči oviro." +
             "Cilj igre je, da preskočiš čim več ovir in nabereš čim več točk." +
             "Za novo igro pritisni tipko R.");
            igrajTekac.Show();
        }

        private void gmbBesede_Click(object sender, EventArgs e)
        {
            FormBesede lingo = new FormBesede();
            lingo.Show();
        }
    }
}
