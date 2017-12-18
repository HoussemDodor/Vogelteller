using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public interface IProjectContext
    {
        Project GetProjectByID(int ID);
        List<Project> GetAllProjects();
        Project EndProject(int ID);
    }
}
