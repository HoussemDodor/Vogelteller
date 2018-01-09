using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SightingKind
    {
        public int ID { get; set; }
        public string sighting { get; set; }
        public int points { get; set; }
        public Species species { get; set; }

        SightingKind(string sighting, int points, Species species)
        {
            this.sighting = sighting;
            this.points = points;
            this.species = species;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
