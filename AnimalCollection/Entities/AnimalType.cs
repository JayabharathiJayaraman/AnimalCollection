using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalCollection.Entities
{
    public class AnimalType
    {
        [Key]
        public int AnimalTypeId { get; set; }

        [Required]
        public string AnimalTypeName { get; set; }


        public List<Animal> Animals { get; set; }

    }
}
