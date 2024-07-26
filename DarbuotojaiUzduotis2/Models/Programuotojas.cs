using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbuotojaiUzduotis2.Models
{
    internal class Programuotojas : Darbuotojas
    {
        public string ProgramavimoKalba { get; set; }

        public Programuotojas(string programavimoKalba, string vardas, string pavarde, double atlyginimas)
        {
            ProgramavimoKalba = programavimoKalba;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }

        public string Persikvalifikuoti(string kalba, Darbuotojas darbuotojas)
        {
            ProgramavimoKalba = kalba;
            return ProgramavimoKalba;
        }

        public override string ToString()
        {
            return $"Darbuotojo vardas: {Vardas} {Pavarde}. Programavimo kalba - {ProgramavimoKalba}. Atlyginimas - {Atlyginimas}";
        }


    }
}
