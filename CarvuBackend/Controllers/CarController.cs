using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvuBackend.Models;
using CarvuBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarvuBackend.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            IEnumerable<Car> result = _carService.GetCars();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCar(Guid id)
        {
            var result = _carService.GetCar(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddCar([FromBody] Car car)
        {
            var result = _carService.AddCar(car);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateCar([FromBody] Car car)
        {
            var result = _carService.UpdateCar(car);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(Guid id)
        {
            _carService.DeleteCar(id);
            return Ok();
        }
    }
}