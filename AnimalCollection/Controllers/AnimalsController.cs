using System;
using System.Linq;
using AnimalCollection.DTOs;
using AnimalCollection.Entities;
using AnimalCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AnimalCollection.Controllers
{
    [ApiController]
    [Route("api/animals")]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalRepo _animalRepo;

        public AnimalsController(IAnimalRepo animalRepo)
        {
            _animalRepo = animalRepo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllAnimals()
        {
            IOrderedEnumerable<AnimalDTO> animals = _animalRepo
                .GetAllAnimals()
                .Select(a => new AnimalDTO
                {
                    AnimalId = a.AnimalId,
                    AnimalName = a.AnimalName,
                    AnimalType = a.AnimalType
                }).OrderBy(x => x.AnimalName);
            return Ok(animals);
        }

        [HttpGet]
        [Route("{animalId}")]
        public IActionResult GetAnimalById(int animalId)
        {
            Animal animal = _animalRepo.GetAnimalById(animalId);
            

            if (animal is null)
            {
                return NotFound($"Animal with id {animalId} is not Found");
            }

            AnimalDTO animalDTO = MapAnimalToAnimalDTO(animal);
            return Ok(animalDTO);
        }

        private AnimalDTO MapAnimalToAnimalDTO(Animal animal)
        {
            return new AnimalDTO
            {
                AnimalId = animal.AnimalId,
                AnimalName = animal.AnimalName,
                AnimalType = animal.AnimalType
            };
        }

    }
}
