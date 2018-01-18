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
            return context.GetAllAnimals();
        }

        public List<Animal> GetAllAnimalsBySpecies(int speciesID)
        {
            return context.GetAllAnimalsBySpecies(speciesID);
        }

        public Animal GetAnimal(int ID)
        {
            return context.GetAnimal(ID);
        }
    }
}
