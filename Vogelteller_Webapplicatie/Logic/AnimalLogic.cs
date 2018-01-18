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

        public List<Animal> GetAllAnimals()
        {
            return repository.GetAllAnimals();
        }

        public List<Animal> GetAllAnimalsBySpecies(int speciesID)
        {
            return repository.GetAllAnimalsBySpecies(speciesID);
        }

        public Animal SelectAnimal(int id)
        {
            return repository.GetAnimal(id);
        }
    }
}
