using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    class ProjectRepository
    {
        private IProjectContext context;

        public ProjectRepository(IProjectContext context)
        {
            this.context = context;
        }

        public Project GetProjectByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Project EndProject(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjects()
        {
            throw new NotImplementedException();
        }
    }
}
