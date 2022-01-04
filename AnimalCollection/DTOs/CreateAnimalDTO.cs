using System;
using AnimalCollection.Entities;

namespace AnimalCollection.DTOs
{
    public class CreateAnimalDTO
    {
        public string AnimalName { get; set; }
        //public string AnimalType { get; set; }
       // public AnimalType AnimalName { get; set; }
        public int AnimalTypeId { get; set; }
    }
}
