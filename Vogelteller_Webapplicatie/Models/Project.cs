using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Project
    {
        int ID;
        string name;
        string map;
        DateTime dateStarted;
        DateTime dateEnded;
        Species species;
        List<Visit> VisitsAtThisProject;

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

        Project(string name, string map, Species species)
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
