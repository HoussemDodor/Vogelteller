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
        public int speciesID { get; set; }

        public SightingKind(int id, string sighting, int points, int speciesID)
        {
            ID = id;
            this.sighting = sighting;
            this.points = points;
            this.speciesID = speciesID;
        }

        public SightingKind(string sighting, int points, int speciesID)
        {
            this.sighting = sighting;
            this.points = points;
            this.speciesID = speciesID;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
