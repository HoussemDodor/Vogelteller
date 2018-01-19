using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class ProjectRepository
    {
        private IProjectContext context;

        public ProjectRepository(ContextType contextType)
        {
            switch (contextType)
            {
                case ContextType.Database: this.context = new ProjectSQLContext(); break;
                case ContextType.Test: this.context = new ProjectTestContext(); break;
            }
        }

        public void NewProject(string name, string map, DateTime dateStarted, int speciesID)
        {
            context.NewProject(name, map, dateStarted, speciesID);
        }
        
        public Project GetProjectByID(int ID)
        {
            return context.GetProjectByID(ID);
        }

        public void EndProject(int ID)
        {
            context.EndProject(ID);
        }

        public List<Project> GetAllProjects()
        {
            return context.GetAllProjects();
        }
    }
}
