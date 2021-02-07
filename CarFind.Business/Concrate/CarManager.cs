using CarFind.DataAccess.Abstract;
using CarFind.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using CarFind.Business;
using CarFind.DataAccess.Concrate;

namespace CarFind.Business.Concrate
{
    public class CarManager : ICarServices
    {
        private ICarRepository carRepository;
        public CarManager()
        {
            carRepository = new CarRepository();
        }

        public Car CreateCar(Car car)
        {
            return carRepository.CreateCar(car);
        }

        public void DeleteCar(int id)
        {
            carRepository.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return carRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            return carRepository.GetCarById(id);
        }

        public List<Car> GetCarById()
        {
            throw new NotImplementedException();
        }

        public Car UpdateCar(Car car)
        {
            return carRepository.UpdateCar(car);
        }
    }
}
