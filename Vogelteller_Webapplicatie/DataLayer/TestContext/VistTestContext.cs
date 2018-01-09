using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class VistTestContext : IVisitContext
    {
        List<Visit> visits = new List<Visit>();

        public void NewVisit(string fullName)
        {
            Visit v = new Visit(fullName);
            v.DateStarted = DateTime.Now;
            visits.Add(v);
        }

        public void AddSighting(Visit v, Sighting sighting)
        {
            v.WaarnemingenTijdensDitBezoek.Add(sighting);
        }

        public void EndVisit(int ID)
        {
            foreach (Visit v in visits)
            {
                if (v.ID == ID)
                {
                    v.DateEnded = DateTime.Now;
                }
            }
        }

        public List<Visit> GetAllVisitsForCurrentProject(Project p)
        {
            return p.VisitsAtThisProject;
        }

        public Visit GetVisitByID(int ID)
        {
            foreach (Visit v in visits)
            {
                if (v.ID == ID)
                {
                    return v;
                }
            }
            return null;
        }        
    }
}
