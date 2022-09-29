using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace KRATKOCASNIK
{
    public partial class FormBesede : Form
    {
        List<string> crke = new List<string> { "a", "b", "c", "č", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "š", "t", "u", "v", "z", "ž" };
        Random rnd = new Random();
        string vrstica;
        int sekunde = 0;

        public FormBesede()
        {
            InitializeComponent();
            igrajIgro();
            timerCas.Start();
        }

        /// <summary>
        /// metoda prirpavi panelo na novo igro
        /// </summary>
        public void igrajIgro()
        {
            sprazniKonzolo();
            int i = rnd.Next(crke.Count);
            string prvaCrka = crke[i];
            gmb1.Text = prvaCrka;
            gmb1.BackColor = Color.Violet;
            lblVrednostTock.Text = 0.ToString();
            lblČas.Text = "Čas: 0 sekund";
            timerCas.Start();
            sekunde = 0;

            
        }

       /// <summary>
       /// metoda sprazne konzolo in jo prirpavi za novo igro
       /// </summary>
       public void sprazniKonzolo()
        {
            foreach(Panel panela in glavnaPanela.Controls)
            {
                foreach(Button gumb in panela.Controls)
                {
                    gumb.Text = "";
                    gumb.BackColor = Color.LightGray;
                }
            }
        }

       /// <summary>
       /// metoda preveri ali je beseda v slovarju besed
       /// </summary>
       /// <param name="beseda"></param>
       /// <returns></returns>
       private bool preveriBesedo(string beseda, int indeks)
        { 
            
            StreamReader beri = File.OpenText("uporabneBesede.txt");
            List<string> besedeVse = new List<string>();

            
            string prejsnja = preberiPrejsnoBesedo(indeks);
            string trenutna = beseda;

            //preveriti je potrebno da vnešena beseda že ni v konzoli
            List<string> vneseneBesede = preberiVneseneBesede(indeks);
            if (vneseneBesede.Contains(beseda))
            {
                MessageBox.Show("Vnešena beseda se ne sme ponavljati!");
                return false;
            }

            //// preveriti je treba če imamo še rešitve
            //if (!obstajaResitev(vneseneBesede, indeks, beseda))
            //{
            //    MessageBox.Show("Žal igra nima več rešitve. Igra je končana!");
            //}


            if (indeks == 1)
            {
                return true;
            }
            else
            {
                int doKje = indeks + 1;
                if(beseda.Length != 5)
                {
                    if(beseda.Length < 5)
                    {
                        MessageBox.Show("Vnešena beseda je prekratka. Beseda mora imeti 5 znakov.");
                    }
                    else
                    {
                        MessageBox.Show("Vnešena beseda je predolga. Beseda mora imeti 5 znakov.");
                    }
                }
                

                if (preveriUjemanje(prejsnja, trenutna, indeks))
                {
                    while ((vrstica = beri.ReadLine()) != null)
                    {
                        besedeVse.Add(vrstica);
                    }
                    beri.Close();
                    return besedeVse.Contains(beseda);
                }
            }
            return false;
        }

       /// <summary>
       /// metoda naj bi preverila če imamo še rešitev
       /// </summary>
       /// <param name="besede"></param>
       /// <param name="korak"></param>
       /// <param name="beseda"></param>
       /// <returns></returns>
       public bool obstajaResitev(List<string> besede, int korak, string beseda)
        {
            using(StreamReader beri = new StreamReader("../../../../uporabneBesede" + ".txt"))
            {
                if(korak == 0 && besede.Count == 0)
                {
                    return true;
                }
                else
                {
                   // string zadnja = besede.Last();
                    string preveri = beseda.Substring(0, korak);
                    vrstica = beri.ReadLine();
                    while (vrstica != null)
                    {
                        if (!besede.Contains(vrstica) && vrstica.Contains(preveri))
                        {
                            return true;
                        }
                    }
                }
               
                return false;
            }
        }

        private List<string> preberiVneseneBesede(int indeks)
        {
            string beseda = "";
            List<string> besede = new List<string>();
            for (int i = 0; i < indeks; i++)
            {
                foreach(Panel panela in glavnaPanela.Controls)
                {
                    if(panela.TabIndex == i)
                    {
                        for(int j = 0; j < 5; j++)
                        {
                            foreach(Button gumb in panela.Controls)
                            {
                                if(gumb.TabIndex == j)
                                {
                                    beseda = beseda + gumb.Text;
                                }
                            }
                            besede.Add(beseda);
                        }
                    }
                }
            }
            return besede;
        }

        /// <summary>
        /// metoda preveri če se nova vnešena beseda vjema z prejšnjo besedo
        /// v določenem delu int del
        /// </summary>
        /// <param name="prejsnja"></param>
        /// <param name="trenutna"></param>
        /// <param name="del"></param>
        /// <returns></returns>
        public bool preveriUjemanje(string prejsnja,string trenutna, int del)
        {
            for(int i = 0; i < del; i++)
            {
                if (prejsnja[i] != trenutna[i])
                {
                    return false;
                }
            }
            
            return true;
        }
  
        /// <summary>
        /// metoda prebere prejšno vneseno besedo, ki je pravilno vnešena
        /// </summary>
        /// <param name="indeks"></param>
        /// <returns></returns>
        public string preberiPrejsnoBesedo(int indeks)
        {
            string prejsnja = "";
            if(indeks == 0)
            {
                return "";
            }
            else
            {
                foreach(Panel panela in glavnaPanela.Controls)
                {
                    if(panela.TabIndex == indeks - 1)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            foreach (Button gumb in panela.Controls)
                            {
                                if (gumb.TabIndex == i)
                                {
                                    prejsnja = prejsnja + gumb.Text;
                                }

                            }
                        } 
                    }
                }
            }
            return prejsnja;
        }
        /// <summary>
        /// metoda zapiše besedo v dano vrstico/panelo, kjer se nahajamo
        /// </summary>
        /// <param name="beseda"></param>
        /// <param name="vrstica"></param>
        private void zapisBesede(string beseda, int tabIndeks)
        {
            foreach (Control con in glavnaPanela.Controls)
            {
                if (con is Panel)
                {
                    if (con.TabIndex == tabIndeks)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            foreach (Button gumb in con.Controls)
                            {
                                if (gumb.TabIndex == i)
                                {
                                    gumb.Text = beseda[i].ToString();
                                }
                            }
                        }
                    }
                }
            }
        }


       /// <summary>
       /// metoda pobarva gumbe in zapiše črke na mestu
       /// </summary>
       /// <param name="stevilo"></param>
       private void pobarvaj(int stevilo, string beseda)
        {
            foreach(Panel panela in glavnaPanela.Controls)
            {
                if(panela.TabIndex == stevilo + 1)
                {
                    for(int i = 0; i < stevilo + 1; i++)
                    {
                        foreach(Button gumb in panela.Controls)
                        {
                            if(gumb.TabIndex == i)
                            {
                                gumb.BackColor = Color.Violet;
                                gumb.Text = beseda[i].ToString();
                            }
                        }
                    }
                }
            }
        }

       /// <summary>
       /// metoda preveri ali je beseda najdena glede na tabIndex
       /// </summary>
       /// <param name="panela"></param>
       /// <returns></returns>
       private bool najdenaBeseda(int tabIndeks)
        {
            foreach (Panel panela in glavnaPanela.Controls)
            {
                if(panela.TabIndex == tabIndeks)
                {
                    foreach(Button gumb in panela.Controls)
                    {
                        if (gumb.Text == "")
                        {
                            return false; // če pridemo do prazne beseda še ni vnešena
                        }
                    }
                }
            }
            return true;
        }

        private bool konecIgre()
        {
            foreach(Panel panela in glavnaPanela.Controls)
            {
                foreach(Button gumb in panela.Controls)
                {
                    if(gumb.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            boxVnos.Text = "";
            igrajIgro();
        }

        private void btnPreveri_Click(object sender, EventArgs e)
        {
            //timer


            timerCas.Start(); 
            string besedilo = boxVnos.Text;
            if(besedilo == "")
            {
                MessageBox.Show("Vnesli niste še nobene besede!");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!najdenaBeseda(i)) //če to ni true besedo vnesemo
                    {
                        if (preveriBesedo(besedilo, i))
                        {
                            zapisBesede(besedilo, i);
                            boxVnos.Text = "";
                            pobarvaj(i, besedilo);
                            // zapis točk, za vsako pravilno vnešeno besedo +5 točk
                            int tocke = int.Parse(lblVrednostTock.Text);
                            lblVrednostTock.Text = (tocke + 5).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Napačna beseda!");
                            boxVnos.Text = "";
                        }

                        break;
                    }
                }
                if (konecIgre())
                {
                    MessageBox.Show("Odlično, igra je končana!");
                }
            }
           
        }

        

        private void timerCas_Tick(object sender, EventArgs e)
        {
            sekunde++;
            lblČas.Text = $"Čas: {sekunde} sekund";
            if (sekunde == 150)
            {
                timerCas.Stop();
                MessageBox.Show("Čas je potekel!");
            }
        }

        private void btnNavodila_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V prvem polju se pojavi začetka črka besede, ki jo iščete. Beseda mora biti sestavljena iz petih črk. " +
                "v vsakem naslenjem koraku, se mora iskana beseda vjemati v eni črki več z prejšnjo besedo. Igra je končana, ko najdete " +
                "vseh 5 besed. Če besed ne najdete v 150 sekundah se igra konča in lahko igrate znova.");
        }

       
        
    }
}
