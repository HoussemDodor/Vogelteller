using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Project
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string map { get; set; }
        private DateTime dateStarted { get; set; }
        private DateTime dateEnded { get; set; }
        public Species species { get; set; }
        public List<Visit> VisitsAtThisProject { get; set; }

        public DateTime DateStarted
        {
            get { return dateStarted; }
            set
            {
                if (dateStarted == null)
                {
                    dateStarted = value;
                }
            }
        }

        public DateTime DateEnded
        {
            get { return dateEnded; }
            set
            {
                if (value >= dateStarted)
                {
                    dateStarted = value;
                }
            }
        }

        public Project(string name, string map, Species species)
        {
            dateStarted = DateTime.Now;
            this.name = name;
            this.map = map;
            this.species = species;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
