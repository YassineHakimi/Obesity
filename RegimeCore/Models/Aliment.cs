using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeCore.Models
{
    public class Aliment
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public TypeAliment Type { get; set; }
        public float Quantity { get; set; }
        public float CalPerQ { get; set; }

        public ICollection<Regime> Regimes;

        public float CaloriesConsommees(float quantity)
        {
            return (quantity / 100) * CalPerQ;
        }

        public float TotalCalories(Personne personne)
        {
            float total = 0f;

            foreach (var a in personne.Regime.Aliments)
            {
                total += a.CaloriesConsommees(200f);
            }

            return total;
        }
    }

    public enum TypeAliment
    {
        Légume, Viande, Poisson, Fruits, Produits_laitiers, Pâte
    }
}
