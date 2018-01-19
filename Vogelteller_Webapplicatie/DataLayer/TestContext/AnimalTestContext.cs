using System;
using System.Collections.Generic;
using Models;

namespace DataLayer
{
    internal class AnimalTestContext : IAnimalContext
    {
        private List<Animal> animals = new List<Animal>();
        Species Vogel = new Species (1, "Vogel");
        Species Zoogdier = new Species(2, "Zoogdier");

        
        public AnimalTestContext()
        {
            animals.Add(new Animal(1,"Zwaan", "ZWA", DateTime.Now, DateTime.Now.AddDays(150), 1));
            animals.Add(new Animal(2, "Raaf", "RAA", DateTime.Now, DateTime.Now.AddDays(150), 1));
            animals.Add(new Animal(3, "Mus", "MUS", DateTime.Now, DateTime.Now.AddDays(150), 1));
            animals.Add(new Animal(4, "Bruine Beer", "BBR", DateTime.Now, DateTime.Now.AddDays(150), 2));
            animals.Add(new Animal(5, "Leeuw", "LEE", DateTime.Now, DateTime.Now.AddDays(150), 2));
            animals.Add(new Animal(6, "Tijger", "TIJ", DateTime.Now, DateTime.Now.AddDays(150), 2));
        }

        public List<Animal> GetAllAnimals()
        { 
            return animals;
        }

        public List<Animal> GetAllAnimalsBySpecies(int speciesID)
        {
            List<Animal> Sorted = new List<Animal>();
            foreach (Animal a in animals)
            {
                if (a.speciesID == speciesID)
                {
                    Sorted.Add(a);
                }
            }
            return Sorted;
        }

        public Animal GetAnimal(int ID)
        {
            foreach (Animal a in animals)
            {
                if (a.ID == ID)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
