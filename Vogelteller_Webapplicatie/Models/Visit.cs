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
        private DateTime dateStarted { get; set; }
        private DateTime dateEnded { get; set; }
        public string fullName { get; set; }
        public List<Sighting> WaarnemingenTijdensDitBezoek { get; set; }


        // property
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

        //constructor
        public Visit(string fullName)
        {
            dateStarted = DateTime.Now;
            this.fullName = fullName;
        }

        // methods
        public override string ToString()
        {
            return dateStarted.ToString() + fullName;
        }
    }
}
