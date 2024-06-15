using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

namespace VizibicikliKolcsonzes
{
    class Program
    {
   

        static void Main(string[] args)
        {        
            List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();

            File.ReadAllLines("kolcsonzesek.txt").Skip(1).ToList().ForEach(item => kolcsonzesek.Add(new Kolcsonzes(item)));

            Console.WriteLine($"5. feladat: Napi kolcsonzesek szama: {kolcsonzesek.Count}");

            Console.Write("6. feladat: Kerek egy nevet: ");
            string megadottNev = Console.ReadLine();
            bool kolcsonzott = false;
            foreach (Kolcsonzes item in kolcsonzesek)
            {
                if (item.nev == megadottNev)
                {
                    if (!kolcsonzott)
                    {
                        Console.WriteLine("\t" + megadottNev + " kolcsonzesei:");
                        Console.WriteLine("\t" + item.eOra + ":" + item.ePerc + " - " + item.vOra + ":" + item.vPerc);
                        kolcsonzott = true;
                    }
                    else
                    {
                        Console.WriteLine("\t" + item.eOra + ":" + item.ePerc + " - " + item.vOra + ":" + item.vPerc);
                    }
                }
            }
            if (!kolcsonzott) { Console.WriteLine("Nem volt ilyen nevu kolcsonzo. "); }

            Console.ReadKey();
        }
    }
}
