using System;
using System.Collections.Generic;
using System.Linq;
using AnimalCollection.Entities;

namespace AnimalCollection.DTOs
{
    public class AnimalTypeDTO
    {
        public int AnimalTypeId { get; set; }

        public string AnimalTypeName { get; set; }

        public List<AnimalDTO> Animals { get; set; }
    }

    public static class AnimalTypeDTOExtensions
    {
        public static AnimalTypeDTO MapToAnimalTypeDTO(this AnimalType animalType)
        {
            return new AnimalTypeDTO
            {
                AnimalTypeId = animalType.AnimalTypeId,
                AnimalTypeName = animalType.AnimalTypeName,
                Animals = animalType.Animals.MapToAnimalDTOs()
            };
        }

        public static List<AnimalTypeDTO> MapToAnimalTypeDTOs(this List<AnimalType> animalTypes)
        {
            return animalTypes.Select(a => a.MapToAnimalTypeDTO()).ToList();
        }
    }
}
