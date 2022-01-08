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

    }
}