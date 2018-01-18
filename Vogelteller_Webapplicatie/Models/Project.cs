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
        public int speciesID { get; set; }
        public List<Visit> VisitsAtThisProject { get; set; }


        public Project(int id, string name, string map, DateTime dateStarted, DateTime dateEnded, int speciesID)
        {
            ID = id;
            this.name = name;
            this.map = map;
            this.speciesID = speciesID;
            this.dateStarted = dateStarted;
            this.dateEnded = dateEnded;
        }

        public Project(string name, string map, DateTime dateStarted, int speciesID)
        {
            this.name = name;
            this.map = map;
            this.speciesID = speciesID;
            this.dateStarted = dateStarted;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
