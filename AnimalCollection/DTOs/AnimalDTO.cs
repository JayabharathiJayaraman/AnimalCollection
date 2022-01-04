using System;
using System.Collections.Generic;
using System.Linq;
using AnimalCollection.Entities;

namespace AnimalCollection.DTOs
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
       
        public string AnimalName { get; set; }
       
        public BasicAnimalTypeDTO AnimalType { get; set; }
    }

   
    public static class AnimalDtoExtensions
    {

        public static AnimalDTO MapToAnimalDTO(this Animal animal)
        {
            return new AnimalDTO
            {
                AnimalId = animal.AnimalId,
                AnimalName = animal.AnimalName,
                AnimalType = animal.AnimalType.MapToBasicAnimalTypeDTO(),
                
            };
        }

        public static List<AnimalDTO> MapToAnimalDTOs(this List<Animal> animals)
        {
            return animals.Select(v => v.MapToAnimalDTO()).ToList();
        }
    }
}
