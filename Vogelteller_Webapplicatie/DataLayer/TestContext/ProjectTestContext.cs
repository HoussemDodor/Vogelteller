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

        public ProjectTestContext()
        {
            projects.Add(new Project(1, "Roermond", "IMGUR", DateTime.Now, 1));
            projects.Add(new Project(2, "weert", "IMGUR", DateTime.Now, 1));
            projects.Add(new Project(3, "eindhoven", "IMGUR", DateTime.Now, 2));
            projects.Add(new Project(4, "hrost", "IMGUR", DateTime.Now, 2));
        }

        public void NewProject(string name, string map, DateTime dateStarted, int speciesID)
        {
            Project p = new Project(name, map, dateStarted, speciesID);
            projects.Add(p);
        }

        public void EndProject(int ID)
        {
            foreach (Project p in projects)
            {
                if (p.ID == ID)
                {
                    p.dateEnded = DateTime.Now;
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
