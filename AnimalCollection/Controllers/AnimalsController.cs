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
            var animals = _animalRepo.GetAllAnimals().ToList().MapToAnimalDTOs();
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

            AnimalDTO animalDTO = animal.MapToAnimalDTO();
            return Ok(animalDTO);
        }

    }
}