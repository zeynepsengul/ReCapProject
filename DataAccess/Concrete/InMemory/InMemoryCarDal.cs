using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, ColorId=1, BrandId=1, DailyPrice = 15000, ModelYear = 2001, Description = "Super Araba" },
                new Car{Id = 2, ColorId=2, BrandId=2, DailyPrice = 30000, ModelYear = 2005, Description = "Harika Araba" },
                new Car{Id = 3, ColorId=1, BrandId=1, DailyPrice = 40000, ModelYear = 2006, Description = "Mukemmel Araba" },
                new Car{Id = 4, ColorId=3, BrandId=5, DailyPrice = 20000, ModelYear = 2003, Description = "Almayan Pişman Araba" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
