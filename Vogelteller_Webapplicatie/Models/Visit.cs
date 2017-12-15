using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Visit
    {
        int ID;
        DateTime dateStarted;
        DateTime dateEnded;
        string fullName;
        List<Sighting> WaarnemingenTijdensDitBezoek;

        Visit(string fullName)
        {
            dateStarted = DateTime.Now;
            this.fullName = fullName;
        }

        public override string ToString()
        {
            return dateStarted.ToString() + fullName;
        }
    }
}
