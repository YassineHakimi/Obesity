using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeCore.Models
{
    public sealed class Personne
    {
        public int Id { get; set; }
        public float Poids { get; set; }
        public float Taille { get; set; }
        public int Age { get; set; }
        public Gendre Sexe { get; set; }
        public float Imc { get; set; }

        public Regime Regime { get; set; }


        public override string ToString()
        {
            return "Id : " + Id + " Poids : " + Poids + " Taille : " + Age + " Sexe : " + Sexe + " IMC : " + Imc;
        }

    }

    public enum Gendre { Homme, Femme }
    
}
