using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    class AnimalRepository
    {
        private IAnimalContext context;

        public AnimalRepository(IAnimalContext context)
        {
            this.context = context;
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
