using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    internal class ProjectSQLContext : IProjectContext
    {
        public void EndProject(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Project GetProjectByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void NewProject(string name, string map, Species species)
        {
            throw new NotImplementedException();
        }
    }
}
