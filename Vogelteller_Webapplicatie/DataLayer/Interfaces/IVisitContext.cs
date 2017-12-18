using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public interface IVisitContext
    {
        Visit GetVisitByID(int ID);
        Visit NewVisit(DateTime dateStarted, string fullName);
        Visit EndVisit(DateTime dateEnded);
        List<Visit> GetAllVisitsForCurrentProject(Project p);        
    }
}
