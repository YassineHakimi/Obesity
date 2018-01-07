using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeCore.Models
{
    public static class ExtendPersonne
    {
        public static string JeuneOrAdulte(this Personne personne)
        {
            if (personne.Age >= 19 && personne.Age <= 25) return "Jeune";
            if (personne.Age > 25 && personne.Age <= 60) return "Adulte";

            return "Autre";
        }
    }
}
