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
        void NewProject(string name, string map, Species species);
        Project GetProjectByID(int ID);
        List<Project> GetAllProjects();
        void EndProject(int ID);
    }
}
