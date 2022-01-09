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

        [HttpPost]
        [Route("")]
        public IActionResult CreateAnimal([FromBody] CreateAnimalDTO createAnimalDTO)
        {

            Animal createdAnimal = _animalRepo.CreateAnimal(createAnimalDTO);

            //AnimalDTO animalDTO = createdAnimal.MapToAnimalDTO();
            AnimalDTO animalSavedDTO = _animalRepo.GetAnimalById(createdAnimal.AnimalId).MapToAnimalDTO();
            return CreatedAtAction(
                nameof(GetAnimalById),
                new { animalId = animalSavedDTO.AnimalId },
                animalSavedDTO);
            
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateAnimal([FromBody] Animal animal, int id)
        {
            Animal updatedAnimal = _animalRepo.UpdateAnimal(animal, id);

            //AnimalDTO animalDTO = updatedAnimal.MapToAnimalDTO();
            AnimalDTO animalDTO = _animalRepo.GetAnimalById(id).MapToAnimalDTO();
            return Ok(animalDTO);
            
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            _animalRepo.DeleteAnimal(id);
            return NoContent();
        }

    }
}