using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace DataLayer
{
    internal class VistSQLContext : IVisitContext
    {
        DatabaseConnection dbconn = new DatabaseConnection();
        Visit v;
        public void NewVisit(string fullName, int projectID, DateTime dateStarted)
        {
            string query = "INSERT INTO Bezoek(ProjectID, DateStarted, FullName) VALUES(@projectID, @dateStarted, @fullName)";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@projectID", projectID);
                    cmd.Parameters.AddWithValue("@dateStarted", dateStarted);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.ExecuteNonQuery();
                }
                dbconn.Connect.Close();
            }
        }

        public void AddSighting(Visit v, Sighting sighting)
        {
            throw new NotImplementedException();
        }

        public void EndVisit(int ID)
        {
            throw new NotImplementedException();
        }

        public Visit GetVisitByID(int ID)
        {
            string query = "SELECT * FROM Bezoek WHERE";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            v = CreateVisitFromReader(reader);
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return v;
        }

        public List<Visit> GetAllVisits()
        {
            string query = "SELECT * FROM Bezoek";
            List<Visit> AllVisits = new List<Visit>();
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllVisits.Add(CreateVisitFromReader(reader));
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return AllVisits;
        }

        public List<Visit> GetAllVisitsByProject(int projectID)
        {
            string query = "SELECT * FROM Bezoek WHERE ProjectID = @projectID";
            List<Visit> visitslist = new List<Visit>();

            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@projectID", projectID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visitslist.Add(CreateVisitFromReader(reader));
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return visitslist;
        }


        private Visit CreateVisitFromReader(SqlDataReader reader)
        {
            return new Visit
                (
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["FullName"]),
                    Convert.ToInt32(reader["ProjectID"]),
                    Convert.ToDateTime(reader["DateStarted"]),
                    Convert.ToDateTime(reader["DateEnded"])                   
                );
        }
    }
}
