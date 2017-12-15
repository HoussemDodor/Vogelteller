using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sighting
    {
        int ID;
        int Xpoint;
        int Ypoint;
        SightingKind sightingKind;
        Animal animal;
        DateTime timeSighted;
            
        Sighting(int Xpoint, int Ypoint, SightingKind sightingKind, Animal animal)
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
