using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;

namespace Logic
{
    class AnimalLogic
    {
        private AnimalRepository repository = new AnimalRepository(LogicSettings.DalContextType);

        Animal a;
        List<Animal> animalList;

        public List<Animal> GetAllAnimals(int speciesID)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAllAnimalsBySpecies(int speciesID)
        {
            throw new NotImplementedException();
        }

        public Animal SelectAnimal(int id)
        {
            throw new NotImplementedException();
        }
    }
}
