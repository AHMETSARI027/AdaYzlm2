using CarFind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarFind.Business
{
    public interface ICarServices
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        void DeleteCar(int id);
        List<Car> GetCarById();
    }
}
