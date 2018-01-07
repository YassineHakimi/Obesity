using RegimeCore.Models;
using RegimeCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Aliment a1 = new Aliment
            {
                Id = 1,
                Type = TypeAliment.Viande,
                Nom = "Filet de boeuf",
                Quantity = 150,
                CalPerQ = 218
            };

            Aliment a2 = new Aliment
            {
                Id = 2,
                Nom = "Raviolis",
                Type = TypeAliment.Pâte,
                Quantity = 125,
                CalPerQ = 77
            };

            List<Aliment> list = new List<Aliment> { a1, a2 };
            Regime r = new Regime { Aliments = list };
            Personne p = new Personne
            {
                Id = 1,
                Age = 18,
                Poids = 60,
                Sexe = Gendre.Homme,
                Taille = 174f,
                Regime = r
            };

            Console.WriteLine(a1.TotalCalories(p));
            ManagePersonne managePersonne = new ManagePersonne();

            managePersonne.CalculerIMC(p);

            Console.WriteLine(managePersonne.RetourRapport(20, Gendre.Femme));
            Console.ReadKey();
        }
    }
}
