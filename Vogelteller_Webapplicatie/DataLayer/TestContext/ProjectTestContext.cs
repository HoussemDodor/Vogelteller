using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class ProjectTestContext : IProjectContext
    {
        List<Project> projects = new List<Project>();

        public void NewProject(string name, string map, Species species)
        {
            Project p = new Project(name, map, species);
            projects.Add(p);
        }

        public void EndProject(int ID)
        {
            foreach (Project p in projects)
            {
                if (p.ID == ID)
                {
                    p.DateEnded = DateTime.Now;
                }
            }
        }

        public List<Project> GetAllProjects()
        {
            return projects;
        }

        public Project GetProjectByID(int ID)
        {
            foreach (Project p in projects)
            {
                if (p.ID == ID)
                {
                    return p;
                }
            }
            return null;
        }        
    }
}
