using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DataLayer
{
    internal class AnimalSQLContext : IAnimalContext
    {
        DatabaseConnection dbConn = new DatabaseConnection();
        Animal a;
        public List<Animal> GetAllAnimals()
        {
            List<Animal> Animals = new List<Animal>();
            string query = "SELECT * FROM Animal";
            using (SqlConnection conn = dbConn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animals.Add(CreateAnimalFromReader(reader));
                        }
                    }
                }
                dbConn.Connect.Close();
            }
            return Animals;
        }

        public List<Animal> GetAllAnimalsBySpecies(int speciesID)
        {
            List<Animal> AnimalBySpecies = new List<Animal>();
            string query = "SELECT * FROM Animal WHERE DiersoortID = @speciesID";
            using (SqlConnection conn = dbConn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("speciesID", speciesID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AnimalBySpecies.Add(CreateAnimalFromReader(reader));
                        }
                    }
                }
                dbConn.Connect.Close();
            }
            return AnimalBySpecies;
        }

        public Animal GetAnimal(int ID)
        {
            string query = "SELECT * FROM Animal WHERE ID = @id";
            using (SqlConnection conn = dbConn.Connect)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            a = CreateAnimalFromReader(reader);
                        }
                    }
                }
                dbConn.Connect.Close();
            }
            return a;
        }

        private Animal CreateAnimalFromReader(SqlDataReader reader)
        {
            return new Animal
                (
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Naam"]),
                    Convert.ToString(reader["Afk"]),
                    Convert.ToDateTime(reader["BeginBroedPeriode"]),
                    Convert.ToDateTime(reader["EindBroedPeriode"]),
                    Convert.ToInt32(reader["DiersoortID"])
                );
        }
    }
}
