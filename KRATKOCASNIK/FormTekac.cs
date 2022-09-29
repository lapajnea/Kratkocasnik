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
    public partial class FormTekac : Form
    {

        //vir https://www.mooict.com/c-tutorial-create-a-t-rex-endless-runner-game-in-visual-studio/

        bool skok = false; // preverimo ali deček skače ali ne
        int hitrostSkoka = 20;
        int sila = 12;
        int tocke = 0;
        int hitrostOvire = 10;
        Random rnd = new Random();
        int pozicija;
        int sekunde = 0;
        public FormTekac()
        {
            InitializeComponent();
            resetirajIgro();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slikaTekac.Top += hitrostSkoka;
            lblTocke.Text = $"Točke: {tocke}";

            if (skok == true && sila < 0)
            {
                skok = false;
            }

            if (skok == true)
            {
                hitrostSkoka = -12;
                sila -= 1;
            }

            else
            {
                hitrostSkoka = 12;
            }


            // preverimio še ovire in jih "premaknemo"
            foreach (Control slika in this.Controls)
            {      
                if (slika is PictureBox && (string)slika.Tag == "ovira")
                {
                    slika.Left -= hitrostOvire; // oviro premaknemo v levo


                    // če ovire ni več na zaslovnu
                    if (slika.Left + slika.Width < -120)
                    {
                        
                        slika.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        tocke++;
                    }

                    // če se tekač zadane ovire
                    if (slikaTekac.Bounds.IntersectsWith(slika.Bounds))
                    {
                        timer1.Stop(); // konec igre
                        timerCas.Stop();
                        MessageBox.Show($"Dosegel si {tocke} točk v {sekunde} sekundah." +
                  
                            $" Pritisni R za novo igro.");
                        lblCas.Text = "Čas: 0 sekund";
                        
                    }
                }
            }

            if (slikaTekac.Top >= 380 && !skok)
            {
                sila = 12; 
                slikaTekac.Top = slikaTla.Top - slikaTekac.Height; 
                hitrostSkoka = 0; 
            }

           // povečamo hitrost
            if (tocke >= 10)
            {
                hitrostOvire = 15;
            }
        }


        private void tipkaDol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && skok == false)
            {
                skok = true;
            }
        }

        private void tipkaGor(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.R)
            {
                resetirajIgro();
            }

            //skok nastavimo na false, da bo tekač lahko ponovno skočil
            if (skok==true)
            {
                skok = false;
            }
        }

        /// <summary>
        /// resertiramo igro in začnemo znova, vse nastavimo na privzete vrednosti
        /// </summary>
        public void resetirajIgro()
        {
           
            // nastavimo na privzete vrednosti
            sila = 12;
            slikaTekac.Top = slikaTla.Top -slikaTekac.Height; // vrnemo ga kjer je bil
            hitrostSkoka = 0;
            skok = false;
            tocke = 0; 
            hitrostOvire = 10;
            lblTocke.Text = $"Točke: {tocke}"; 
            
            foreach (Control slika in this.Controls)
            {
                // preverjamo samo ovire
                if (slika is PictureBox && (string)slika.Tag == "ovira")
                {
                    // naključno postavimo ovire
                    pozicija = rnd.Next(600, 1000);
                    slika.Left = 640 + (slika.Left + pozicija+ slika.Width * 3);
                }
            }
           
            timer1.Start();
            lblCas.Text = "Čas: 0 sekund";
            sekunde = 0;
            timerCas.Start();
            

        }

        private void timerCas_Tick(object sender, EventArgs e)
        {
            sekunde++;
            lblCas.Text = $"Čas: {sekunde} sekund";
        }

    }
}
