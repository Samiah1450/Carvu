using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        Car GetCar(Guid id);
        Car AddCar(Car car);
        Car UpdateCar(Car car);
        void DeleteCar(Guid id);
    }
}
