using System;
using System.Collections.Generic;
using System.Linq;
using AnimalCollection.DTOs;
using AnimalCollection.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimalCollection.Repositories
{
    public class MockAnimalData : IAnimalRepo
    {
       
        private ApplicationContext _db;

        public MockAnimalData(ApplicationContext context)
        {
            
            _db = context;
        }

        public List<Animal> GetAllAnimals()
        {
            return _db.Animals.Include(a => a.AnimalType).ToList();
        }

        public Animal GetAnimalById(int animalId)
        {
            Animal animal = _db.Animals.Include(a => a.AnimalType).SingleOrDefault(x => x.AnimalId == animalId);
            return animal;
        }

        public Animal CreateAnimal(CreateAnimalDTO createdAnimalDTO)
        {
            Animal animal = new Animal(); 

            animal.CreatedDate = DateTime.Now;
            animal.AnimalTypeId = createdAnimalDTO.AnimalTypeId;
            animal.AnimalName = createdAnimalDTO.AnimalName;

            _db.Animals.Add(animal); 
            _db.SaveChanges(); 
            return animal;

        }

        public Animal UpdateAnimal(Animal animal, int id)
        {
            Animal existingAnimal = _db.Animals.FirstOrDefault(x => x.AnimalId == id);
            if (existingAnimal is not null)
            {
                existingAnimal.AnimalName = animal.AnimalName;
                existingAnimal.AnimalType = animal.AnimalType;
            }
            _db.SaveChanges(); //- Save change in DB after update
            return existingAnimal;
        }

        public void DeleteAnimal(int id)
        {
            _db.Animals.Remove(GetAnimalById(id));
            _db.SaveChanges();
        }

    }
}