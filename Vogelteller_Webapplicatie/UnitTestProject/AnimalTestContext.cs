using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace UnitTestProject
{
    class AnimalTestContext : IAnimalContext
    {
        private List<Animal> animals = new List<Animal>();

        public List<Animal> GetAllAnimals()
        {
            return animals;
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
