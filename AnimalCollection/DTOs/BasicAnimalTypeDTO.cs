using System;
using System.Collections.Generic;
using System.Linq;
using AnimalCollection.Entities;

namespace AnimalCollection.DTOs
{
    public class BasicAnimalTypeDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public static class BasicAnimalTypeDTOs
    {
        public static BasicAnimalTypeDTO MapToBasicAnimalTypeDTO(this AnimalType animalType)
        {
            return new BasicAnimalTypeDTO
            {
                ID = animalType.AnimalTypeId,
                Name = animalType.AnimalTypeName
            };
        }

        public static List<BasicAnimalTypeDTO> MapToBasicAnimalTypeDTOs(this List<AnimalType> animalTypes)
        {
            return animalTypes.Select(a => a.MapToBasicAnimalTypeDTO()).ToList();

        }
    }
}
