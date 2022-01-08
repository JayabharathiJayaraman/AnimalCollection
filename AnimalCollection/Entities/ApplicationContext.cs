using System;
using Microsoft.EntityFrameworkCore;

//dotnet ef migrations add XXXX
//dotnet ef database update

namespace AnimalCollection.Entities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var _connectionString = "server=localhost; database=animalCollection; user=Jaya; password=Jayabh2901";

            options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AnimalType>().HasData(
                new AnimalType
                {
                    AnimalTypeId = 1,
                    AnimalTypeName = "AnimalTypeName 1",
                },
                new AnimalType
                {
                    AnimalTypeId = 2,
                    AnimalTypeName = "AnimalTypeName 2",
  
                },
                new AnimalType
                {
                    AnimalTypeId = 3,
                    AnimalTypeName = "AnimalTypeName 3",
                });

            builder.Entity<Animal>().HasData(
                new Animal
                {
                    AnimalId = 1,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 1",
                    AnimalTypeId = 1
                },
                new Animal
                {
                    AnimalId = 2,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 2",
                    AnimalTypeId = 2
                },
                new Animal
                {
                    AnimalId = 3,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 3",
                    AnimalTypeId = 2
                },
                new Animal
                {
                    AnimalId = 4,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 4",
                    AnimalTypeId = 3
                },
                new Animal
                {
                    AnimalId = 5,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 5",
                    AnimalTypeId = 3
                },
                new Animal
                {
                    AnimalId = 6,
                    CreatedDate = DateTime.Now,
                    AnimalName = "AnimalName 6",
                    AnimalTypeId = 3
                });
        }

    }

}
