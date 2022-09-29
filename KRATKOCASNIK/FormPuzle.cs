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
    public partial class FormPuzle : Form
    {

        // kar večkrat potrebujem

        int steviloPremikov = 0;
        int indeks = 0;
        Random rnd = new Random();
        int sekunde = 0;
        public FormPuzle()
        {
            InitializeComponent();
            timer1.Start();
        }


        /// <summary>
        /// metoda zgenerira mrežo števil na gumbih
        /// </summary>
        private void ZgenerirajStevila()
        {
            List<int> tabelaGumbov = new List<int>();

            foreach (Button gumb in this.panel.Controls)
            {
                while (tabelaGumbov.Contains(indeks))
                {
                    indeks = rnd.Next(16); // imamo mrežo 4*4, toliko števil
                }

                // nastavimo prazno polje in polja s številkami
                if (indeks == 0)
                {
                    gumb.Text = ""; // gumb - prazno polje
                }
                else
                {
                    gumb.Text = indeks.ToString(); // določimo število
                }

                // nastavimo barve polj
                if (gumb.Text == "")
                {
                    gumb.BackColor = Color.White;
                }
                else
                {
                    gumb.BackColor = Color.ForestGreen;
                }

                tabelaGumbov.Add(indeks); //hranimo indekse
            }
            if(preveriResljivost() == false)
            {
                MessageBox.Show("Igra ni rešljiva, poskusi ponovno!");
                ZgenerirajStevila();
                    }
            steviloPremikov = 0;
            lblStPremikov.Text = $"Število premikov: {steviloPremikov}";
        }

        /// <summary>
        /// metoda zamenja označen - kliknjen gumb z praznim gumbom, če je mogoče
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZamenjajGumba(Object sender, EventArgs e)
        {
            Button gumb = (Button)sender;

            //če kliknemo na prazno polje se ne zgodi nič
            if (gumb.Text == "")
            {
                return;
            }

            Button prazenGumb = null;
            // poiščemo prazen gumb in ga nastavimo
            foreach (Button gmb in this.panel.Controls)
            {
                if (gmb.Text == "")
                {
                    prazenGumb = gmb;
                    break;
                }
            }

            // preverimo ali je pritisnjen gumb sosed praznega gumba
            if (gumb.TabIndex == (prazenGumb.TabIndex - 1) ||
               gumb.TabIndex == (prazenGumb.TabIndex - 4) ||
               gumb.TabIndex == (prazenGumb.TabIndex + 1) ||
               gumb.TabIndex == (prazenGumb.TabIndex + 4))
            {
                // zamenjamo mesto praznega gumba in kliknjenega gumba,
                // tako, da jima zamenjamo vlogi

                // zamenjamo barve
                prazenGumb.BackColor = Color.ForestGreen;
                gumb.BackColor = Color.White;

                // zamenjamo besedilo
                prazenGumb.Text = gumb.Text;
                gumb.Text = "";

                // št premikov se poveča
                steviloPremikov++;
                lblStPremikov.Text = $"Število premikov: {steviloPremikov}";

            }

           if(PreveriResitev())
            {
                MessageBox.Show($"Bravo, rešil/a si puzzle v {steviloPremikov} premikov!");
            }
        }


        /// <summary>
        /// metoda preveri ali so puzle pravilno rešene,
        /// pravilno so rešene takrat ko je v zgornjem levem kotu 1, 
        /// in nato desno sledijo številke naprej
        /// </summary>
        private bool PreveriResitev()
        {
            foreach(Button gumb in panel.Controls)
            {
                for(int i = 0; i < 15; i++)
                {
                    if(gumb.TabIndex != i && gumb.Text != (i + 1).ToString())
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZgenerirajStevila();     
        }

        private void gmbNavodila_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Igralna plošča ima 15 števil in eno prazno polje, ki ga uporabiš za premikanje polj. " +
                "Cilj igre je, da s pomočjo praznega polja urediš števila od najmanjšega do največjega. " +
                "Prazno polje lahko nadomesti sosedno polje s številko. " +
                "To storiš s klikom na polje s številko.");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ZgenerirajStevila();
            lblCas.Text = "Čas: 0 sekund";
            sekunde = 0;
            timer1.Start();

        }

        private void FormPuzle_Load(object sender, EventArgs e)
        {
            ZgenerirajStevila();
            lblCas.Text = "Čas: 0 sekund";
            timer1.Start();
        }
        private void timerCas_Tick(object sender, EventArgs e)
        {
            sekunde++;
            lblCas.Text = sekunde.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunde++;
            lblCas.Text = $"Čas: {sekunde} sekund";

        }

       /// <summary>
       /// metoda preveri ali obstaja rešitev zgenerirane mreže
       /// </summary>
       /// <returns></returns>
       private bool preveriResljivost()
        {
            List<int> mreza = new List<int>();
            foreach (Button gumb in this.panel.Controls)
            {
                if (gumb.Text == "")
                {
                    mreza.Add(0);
                }
                else
                {
                    mreza.Add(int.Parse(gumb.Text));
                }
            }

            int st_inverzij = inverzije(mreza);
            int pozicija = mreza.IndexOf(0); // kje se nahaja prazen prostor

            int st = 1;

            if ((pozicija & st) == 1)
            {
                if ((st_inverzij & 1) == 1)
                    return false;
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// metoda prešteje število inverzij
        /// </summary>
        /// <param name="mreza"></param>
        /// <returns></returns>
        private int inverzije(List<int> mreza)
        {
            int stej = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = i + 1; j <16; j++)
                {
                    if (mreza[i] > mreza[j])
                    {
                        stej++;
                    }
                }
            }
            return stej;
        }

       


    }
}
