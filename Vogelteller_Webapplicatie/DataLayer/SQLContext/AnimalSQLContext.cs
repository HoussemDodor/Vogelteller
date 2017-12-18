using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class AnimalSQLContext : IAnimalContext
    {
        public List<Animal> GetAllAnimals()
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAllAnimalsBySpecies(Species species)
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimal(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
