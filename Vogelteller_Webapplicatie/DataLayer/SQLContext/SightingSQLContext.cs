using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DataLayer
{
    internal class SightingSQLContext : ISightingContext
    {
        Sighting s;
        DatabaseConnection dbconn = new DatabaseConnection();
        public void NewSighting(int Xpoint, int Ypoint, int sightingKindID, int animalID, DateTime timeSighted)
        {
            throw new NotImplementedException();
        }

        public void ChangeSighting(Sighting s, int Xpoint, int Ypoint, int sightingKindID, int animalID)
        {
            throw new NotImplementedException();
        }

        public void DeleteSighting(int ID)
        {
            throw new NotImplementedException();
        }

        public List<SightingKind> GetAllSightingKind()
        {
            List<SightingKind> sightingKinds = new List<SightingKind>();
            string query = "SELECT * From Waarnemings";
            using (SqlConnection conn = dbconn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sightingKinds.Add(null);
                        }
                    }
                }
                dbconn.Connect.Close();
            }
            return sightingKinds;
        }

        public List<Sighting> GetAllSightings()
        {
            throw new NotImplementedException();
        }

        public Sighting GetSightingByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
