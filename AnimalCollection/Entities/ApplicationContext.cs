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
        var _connectionString = "server=localhost;database=AnimalCollection;user Id=Ghana;password=ghana1985";
       
        options.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
    }

    }
}
