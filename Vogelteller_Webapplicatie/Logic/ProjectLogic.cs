using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;

namespace Logic
{
    public class ProjectLogic
    {
        private ProjectRepository repository = new ProjectRepository(LogicSettings.DalContextType);
        private VisitRepository vRepository = new VisitRepository(LogicSettings.DalContextType);

        public void NewProject(string name, string map, DateTime dateStarted, int speciesID)
        {
            repository.NewProject(name, map, dateStarted, speciesID);
        }

        public Project GetProjectByID(int id)
        {
            return repository.GetProjectByID(id);
        }

        public List<Project> GetAllProjects()
        {
            return repository.GetAllProjects(); 
        }
        
        public void EndProject(int ID)
        {
            repository.EndProject(ID);
        }

        public bool CheckRequirements(Project p)
        {
            if (vRepository.GetAllVisitsByProject(p.ID).Count() >= 10) { return true; } else { return false; }
        }
    }
}
