using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbuotojaiUzduotis2.Models
{
    internal class Testuotojas : Darbuotojas
    {
        public bool TuriAutomatizavimoPatirties { get; set; }

        public Testuotojas(bool turiAutomatizavimoPatirties, string vardas, string pavarde, double atlyginimas)
        {
            TuriAutomatizavimoPatirties = turiAutomatizavimoPatirties;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }

        public void IgautiPatirties()
        {
            if(TuriAutomatizavimoPatirties == false)
            {
                TuriAutomatizavimoPatirties = true;
            }
            else
            {
                Console.WriteLine("Testuotojas jau turi sia patirti");
            }
        }

        public override string ToString()
        {
            return $"Darbuotojo vardas: {Vardas} {Pavarde}. Ar turi automatizavimo patirties? - {TuriAutomatizavimoPatirties}. Atlyginimas - {Atlyginimas}";
        }
    }
}
