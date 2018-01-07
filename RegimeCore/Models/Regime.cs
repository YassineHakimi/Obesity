using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimeCore.Models
{
    public class Regime
    {
        public int Id { get; set; }
        public DateTime D_Debut { get; set; }
        public DateTime D_Fin { get; set; }
        public string Bilan { get; set; }

        public ICollection<Personne> Personnes;
        public ICollection<Aliment> Aliments;

    }
}
