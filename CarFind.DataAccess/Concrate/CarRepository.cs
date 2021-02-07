using CarFind.DataAccess.Abstract;
using CarFind.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarFind.DataAccess.Concrate
{
    public class CarRepository : ICarRepository
    {
        public Car CreateCar(Car car)
        {
            using(var carDbContext = new CarDbContext())
            {
                carDbContext.Cars.Add(car);
                carDbContext.SaveChanges();
                return car;
            }
        }

        public void DeleteCar(int id)
        {
            using (var carDbContext = new CarDbContext())
            {
                Car car = new Car();
                car = carDbContext.Cars.Find(id);
                carDbContext.Cars.Remove(car);
                carDbContext.SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            using(var carDbContext = new CarDbContext())
            {
                return carDbContext.Cars.ToList();
            }
        }

        public Car GetCarById(int id)
        {
            using (var carDbContext = new CarDbContext())
            {
                return carDbContext.Cars.Find(id);
            }
        }

        public Car UpdateCar(Car car)
        {
            using (var carDbContext = new CarDbContext())
            {
                carDbContext.Cars.Update(car);
                return car;
            }
        }
    }
}
