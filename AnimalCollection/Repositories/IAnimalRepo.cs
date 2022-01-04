using System;
using System.Collections.Generic;
using AnimalCollection.DTOs;
using AnimalCollection.Entities;

namespace AnimalCollection.Repositories
{
    public interface IAnimalRepo
    {
        List<Animal> GetAllAnimals();
        Animal GetAnimalById(int animalId);
        /*Animal CreateAnimal(CreateAnimalDTO animalDTO);
        Animal UpdateAnimal(Animal animal,int id);
        void DeleteAnimal(int id);*/
    }
}
