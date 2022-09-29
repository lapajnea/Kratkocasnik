using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace prepis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prepisi("besedeHtml", "uporabneBesede");
        }

        public static void Prepisi(string imePrve, string imeDruge)
        {
            using (StreamReader beri = new StreamReader($"../../../{imePrve}.txt"))
            using (StreamWriter pisi = new StreamWriter($"{imeDruge}.txt"))
            {
                string vrstica = beri.ReadLine();
                while (vrstica != null)
                {
                    
                    int dolzina = vrstica.Length;
                    if (dolzina - 4 == 5)
                    {
                        vrstica = vrstica.Substring(0, dolzina - 4);
                        pisi.WriteLine(vrstica);
                        
                    }
                    else
                    {
                        vrstica = beri.ReadLine();
                    }
                }
            }

        }
    }
}
