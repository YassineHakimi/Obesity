using RegimeCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeCore.Services
{
    public class ManagePersonne
    {
        public float RetourRapport(int age, Gendre sexe)
        {
            if(sexe == Gendre.Homme)
            {
                if (age < 25) return 2700f;
                return 2300f;
            }
            else
            {
                if (age < 25) return 2000f;
                return 1900f;
            }
        }

        public void CalculerIMC(Personne personne)
        {
            double imc = (personne.Poids) / Math.Pow(personne.Taille/100, 2);

            if (imc > 16.5 && imc <= 18.5) Console.WriteLine("Etat de maigreur");
            if (imc > 18.5 && imc <= 25) Console.WriteLine("Corpulence normale");
            if (imc > 25 && imc <= 30) Console.WriteLine("Surpoids");
            if (imc > 30 && imc <= 35) Console.WriteLine("Obesite");
        }

        public List<Personne> GetPersonnesByIMC(List<Personne> personnes)
        {
            return personnes.OrderBy(c => c.Imc).Reverse().ToList();
        }
    }
}
