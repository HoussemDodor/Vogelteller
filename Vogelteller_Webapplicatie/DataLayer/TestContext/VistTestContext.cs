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

        public void NewVisit(string fullName, int projectID, DateTime datestarted)
        {
            Visit v = new Visit(fullName, projectID, datestarted);
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
                    v.dateEnded = DateTime.Now;
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
        
        public List<Visit> GetAllVisits()
        {
            return visits;
        }  

        public List<Visit> GetAllVisitsByProject(int projectID)
        {
            List<Visit> sortedlist = new List<Visit>();
            foreach (Visit v in visits)
            {
                if (v.projectID == projectID)
                {
                    sortedlist.Add(v);
                }
            }
            return sortedlist;
        }
    }
}
