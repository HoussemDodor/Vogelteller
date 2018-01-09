using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public class AnimalRepository
    {
        private IAnimalContext context;

        public AnimalRepository(ContextType contextType)
        {
            switch (contextType)
            {
                case ContextType.Database: this.context = new AnimalSQLContext(); break;
                case ContextType.Test: this.context = new AnimalTestContext(); break;
            }
        }
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
