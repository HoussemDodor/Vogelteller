using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DataLayer
{
    internal class ProjectSQLContext : IProjectContext
    {
        DatabaseConnection dbconn = new DatabaseConnection();
        Project p;
        public void NewProject(string name, string map, DateTime dateStarted, int speciesID)
        {
            string query = "INSERT INTO Project(Naam, Map, DateStarted, DiersoortID) VALUES(@name, @map, @dateStarted, @speciesID)";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@map", map);
                    cmd.Parameters.AddWithValue("@dateStarted", dateStarted);
                    cmd.Parameters.AddWithValue("@speciesID", speciesID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EndProject(int ID)
        {
            //string query = "SELECT * From Project WHERE ID = @id";
            //using (SqlConnection conn = dbconn.Connect)
            //{
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        using 
            //    }
            //}
        }

        public List<Project> GetAllProjects()
        {
            List<Project> projectList = new List<Project>();
            string query = "SELECT * From Project";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            projectList.Add(CreateProjectFromReader(reader));
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return projectList;
        }

        public Project GetProjectByID(int ID)
        {
            string query = "SELECT * From Project WHERE ID = @id";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            p = CreateProjectFromReader(reader);
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return p;
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            if (reader["DateEnded"] == null)
            {
                return new Project
                (
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Naam"]),
                    Convert.ToString(reader["Map"]),
                    Convert.ToDateTime(reader["DateStarted"]),
                    Convert.ToDateTime(reader["DateEnded"]),
                    Convert.ToInt32(reader["DiersoortID"])
                );
            }
            else
            {
                return new Project
                (
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Naam"]),
                    Convert.ToString(reader["Map"]),
                    Convert.ToDateTime(reader["DateStarted"]),
                    Convert.ToInt32(reader["DiersoortID"])
                );
            }     
        }
    }
}
