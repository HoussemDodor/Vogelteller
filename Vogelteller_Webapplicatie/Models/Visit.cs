using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Visit
    {
        //field
        public int ID { get; set; }
        public DateTime dateStarted { get; set; }
        public DateTime dateEnded { get; set; }
        public string fullName { get; set; }
        public int projectID { get; set; }
        public List<Sighting> WaarnemingenTijdensDitBezoek { get; set; }

        //constructor
        public Visit(int ID, string fullName, int projectID, DateTime dateStarted, DateTime dateEnded)
        {
            this.ID = ID;
            this.dateEnded = dateEnded;
            this.dateStarted = dateStarted;
            this.fullName = fullName;
            this.projectID = projectID;
        }
        public Visit(string fullName, int projectID, DateTime dateStarted)
        {
            this.dateStarted = dateStarted;
            this.fullName = fullName;
            this.projectID = projectID;
        }

        // methods
        public override string ToString()
        {
            return dateStarted.ToString() + fullName;
        }
    }
}
