using System;
namespace AnimalCollection.Entities
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
