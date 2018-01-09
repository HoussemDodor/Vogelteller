using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class VistSQLContext : IVisitContext
    {
        public void AddSighting(Visit v, Sighting sighting)
        {
            throw new NotImplementedException();
        }

        public void EndVisit(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Visit> GetAllVisitsForCurrentProject(Project p)
        {
            throw new NotImplementedException();
        }

        public Visit GetVisitByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void NewVisit(string fullName)
        {
            throw new NotImplementedException();
        }
    }
}
