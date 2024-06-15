using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzes
{
    class Kolcsonzes
    {

        public string nev, azonosito;
        public int eOra, ePerc, eIdo, vOra, vPerc, vIdo ;
        
        
        public Kolcsonzes(string sor) {
            var tmp = sor.Split(';');

            nev = tmp[0];
            azonosito = tmp[1];
            eOra = Convert.ToInt32(tmp[2]);
            ePerc = Convert.ToInt32(tmp[3]);
            eIdo = eOra * 60 + ePerc;
            vOra = Convert.ToInt32(tmp[4]);
            vPerc = Convert.ToInt32(tmp[5]);
            vIdo = vOra * 60 + vPerc;


        }
    }
}
