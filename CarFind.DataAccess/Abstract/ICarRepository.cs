using CarFind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarFind.DataAccess.Abstract
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        void DeleteCar(int id);

    }
}
