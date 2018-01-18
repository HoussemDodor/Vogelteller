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

        public VisitRepository(ContextType contextType)
        {
            switch (contextType)
            {
                case ContextType.Database: this.context = new VistSQLContext(); break;
                case ContextType.Test: this.context = new VistTestContext(); break;
            }
        }

        Visit GetVisitByID(int ID)
        {
            return context.GetVisitByID(ID);
        }
        void NewVisit(string fullName, int projectID, DateTime dateStarted)
        {
            context.NewVisit(fullName, projectID, dateStarted);
        }
        void AddSighting(Visit v, Sighting sighting)
        {
            context.AddSighting(v, sighting);
        }
        void EndVisit(int ID)
        {
            context.EndVisit(ID);
        }
    }
}
