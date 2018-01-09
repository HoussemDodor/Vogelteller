using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        private DateTime pairingPeriodStart { get; set; }
        private DateTime pairingPeriodEnd { get; set; }
        public Species species { get; set; }

        public Animal(int id, string name, string abbreviation, DateTime pairingPeriodStart, Species species)
        {
            ID = id;
            this.name = name;
            this.abbreviation = abbreviation;
            this.pairingPeriodStart = pairingPeriodStart;
            this.pairingPeriodEnd = pairingPeriodEnd;
            this.species = species;
        }
    }
}
