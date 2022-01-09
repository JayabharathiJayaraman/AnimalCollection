using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalCollection.Entities
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }

        [ForeignKey("AnimalType")]
        public int AnimalTypeId { get; set; }
        //public string AnimalType { get; set; }

        [Required]
        public string AnimalName { get; set; }
       
        public AnimalType AnimalType { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
