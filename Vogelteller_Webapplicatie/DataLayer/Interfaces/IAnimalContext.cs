﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataLayer
{
    public interface IAnimalContext
    {
        List<Animal> GetAllAnimals();
        List<Animal> GetAllAnimalsBySpecies(int speciesID);
        Animal GetAnimal(int ID);
    }
}
