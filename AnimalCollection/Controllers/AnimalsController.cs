using System;
using System.Linq;
using AnimalCollection.DTOs;
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

    }
}
