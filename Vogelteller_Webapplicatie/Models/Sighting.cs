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
        public SightingKind sightingKind { get; set; }
        public Animal animal { get; set; }
        private DateTime timeSighted { get; set; }

        public DateTime TimeSighted
        {
            get { return timeSighted; }
            set
            {
                if (timeSighted == null)
                {
                    timeSighted = value;
                }
            }
        }

        public Sighting(int Xpoint, int Ypoint, SightingKind sightingKind, Animal animal)
        {
            timeSighted = DateTime.Now;
            this.Xpoint = Xpoint;
            this.Ypoint = Ypoint;
            this.sightingKind = sightingKind;
            this.animal = animal;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
