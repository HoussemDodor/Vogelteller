using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sighting
    {
        public int ID { get; set; }
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
        public int sightingKindID { get; set; }
        public int animalID { get; set; }
        private DateTime timeSighted { get; set; }


        public Sighting(int id, int Xpoint, int Ypoint, int sightingKindID, int animalID, DateTime timeSighted)
        {
            ID = id;
            this.Xpoint = Xpoint;
            this.Ypoint = Ypoint;
            this.sightingKindID = sightingKindID;
            this.animalID = animalID;
            this.timeSighted = timeSighted;
        }

        public Sighting(int Xpoint, int Ypoint, int sightingKindID, int animalID, DateTime timeSighted)
        {
            this.Xpoint = Xpoint;
            this.Ypoint = Ypoint;
            this.sightingKindID = sightingKindID;
            this.animalID = animalID;
            this.timeSighted = timeSighted;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
