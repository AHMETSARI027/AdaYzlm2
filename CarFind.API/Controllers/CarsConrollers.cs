using CarFind.Business;
using CarFind.Business.Concrate;
using CarFind.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarFind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsConrollers : ControllerBase
    {
        private ICarServices carService;
        public CarsConrollers()
        {
            carService = new CarManager();
        }
        [HttpGet]
        public List<Car> Get()
        {
            return carService.GetAllCars();
        }
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return carService.GetCarById(id);
        }
        [HttpPost]
        public Car Post([FromBody] Car car)
        {
            return carService.CreateCar(car);
        }
        [HttpPut]
        public Car Put([FromBody]Car car)
        {
            return carService.UpdateCar(car);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            carService.DeleteCar(id);
        }
    }
}
