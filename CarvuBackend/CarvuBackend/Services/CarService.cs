using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public class CarService : ICarService
    {
        private readonly CarvuDbContext _carvuDbContext;

        public CarService(CarvuDbContext carvuDbContext)
        {
            _carvuDbContext = carvuDbContext;
        }

        public IEnumerable<Car> GetCars()
        {
            return _carvuDbContext.Cars.ToList();
        }
        
        public Car GetCar(Guid id)
        {
            return _carvuDbContext.Cars.Where(x => x.Id == id).FirstOrDefault();
        }

        public Car AddCar(Car car)
        {
            if (car == null)
            {
                throw new Exception("Car information cannot be empty.");
            }

            var newCar = _carvuDbContext.Cars.Add(car).Entity;
            _carvuDbContext.SaveChanges();
            return newCar;
        }

        public Car UpdateCar(Car car)
        {
            if (car == null)
            {
                throw new Exception("Car information cannot be empty.");
            }
            
            var carToUpdate = _carvuDbContext.Cars.Where(x => x.Id == car.Id).FirstOrDefault();
            if (carToUpdate == null)
            {
                throw new Exception("Car to update was not found in the database.");
            }

            carToUpdate.VIN = car.VIN;
            carToUpdate.Make = car.Make;
            carToUpdate.Model = car.Model;
            carToUpdate.Type = car.Type;
            carToUpdate.Mileage = car.Mileage;
            carToUpdate.Year = car.Year;
            carToUpdate.Rate = car.Rate;

            _carvuDbContext.SaveChanges();
            return carToUpdate;
        }

        public void DeleteCar(Guid id)
        {
            var carToDelete = _carvuDbContext.Cars.Where(x => x.Id == id).FirstOrDefault();
            if (carToDelete == null)
            {
                throw new Exception("The car to delete was not found in the database.");
            }

            _carvuDbContext.Cars.Remove(carToDelete);
            _carvuDbContext.SaveChanges();
        }
    }
}
