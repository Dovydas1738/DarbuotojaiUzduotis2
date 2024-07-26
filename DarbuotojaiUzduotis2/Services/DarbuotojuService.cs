using DarbuotojaiUzduotis2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbuotojaiUzduotis2.Services
{
    internal class DarbuotojuService : Darbuotojas
    {
        public List<Darbuotojas> Darbuotojai {  get; set; }

        public DarbuotojuService()
        {
            Darbuotojai = new List<Darbuotojas>();
        }

        public void PridetiDarbuotoja(Darbuotojas darbuotojas)
        {
            Darbuotojai.Add(darbuotojas);
        }

        public string GautiVisusDarbuotojus()
        {
            foreach (var d in Darbuotojai)
            {
                Console.WriteLine(d);
            }

            return null;
        }

    }
}
