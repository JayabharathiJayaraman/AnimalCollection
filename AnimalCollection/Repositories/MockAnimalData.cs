using System;
using System.Collections.Generic;
using AnimalCollection.DTOs;
using AnimalCollection.Entities;

namespace AnimalCollection.Repositories
{
    public class MockAnimalData : IAnimalRepo
    {
        private List<Animal> _animals;
        public MockAnimalData()
        {
            _animals = PopulateAnimalData();
        }

        private List<Animal> PopulateAnimalData()
        {
            return new List<Animal>
            {
                new Animal { AnimalId = 1, AnimalName = "Cat", AnimalType="Pet", CreatedDate=DateTime.Now },
                new Animal { AnimalId = 2, AnimalName = "Dog", AnimalType="Pet", CreatedDate=DateTime.Now },
                new Animal { AnimalId = 3, AnimalName = "Lion", AnimalType="Wild", CreatedDate=DateTime.Now },
                new Animal { AnimalId = 4, AnimalName = "Tiger", AnimalType="Wild", CreatedDate=DateTime.Now },
            };
        }

        public Animal CreateAnimal(CreateAnimalDTO animalDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnimal(int id)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }

        public Animal GetAnimalById(int animalId)
        {
            Animal animal = _animals.Find(animal => animal.AnimalId == animalId);
            return animal;
        }

        public Animal UpdateAnimal(Animal animal, int id)
        {
            throw new NotImplementedException();
        }
    }
}
