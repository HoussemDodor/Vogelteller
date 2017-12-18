using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class VisitRepository
    {
        private IVisitContext context;

        public VisitRepository(IVisitContext context)
        {
            this.context = context;
        }

        public Visit EndVisit(DateTime dateEnded)
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

        public Visit NewVisit(DateTime dateStarted, string fullName)
        {
            throw new NotImplementedException();
        }
    }
}
