using DarbuotojaiUzduotis2.Models;
using DarbuotojaiUzduotis2.Services;
using System;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(string[] args)
        {
            DarbuotojuService darbuotojuService = new DarbuotojuService();

            Darbuotojas programuotojas1 = new Programuotojas("C#", "Mantas", "Mantelis", 1500);
            Darbuotojas programuotojas2 = new Programuotojas("C++", "Robertas", "Bertas", 1200);
            Darbuotojas testuotojas1 = new Testuotojas(false, "Julius", "Julenas", 1300);
            Darbuotojas testuotojas2 = new Testuotojas(false, "Andrius", "Andrenas", 1700);

            darbuotojuService.PridetiDarbuotoja(programuotojas1);
            darbuotojuService.PridetiDarbuotoja(programuotojas2);
            darbuotojuService.PridetiDarbuotoja(testuotojas1);
            darbuotojuService.PridetiDarbuotoja(testuotojas2);

            darbuotojuService.GautiVisusDarbuotojus();

            Programuotojas.Persikvalifikuoti("Java", programuotojas1);


        }

    }
}
