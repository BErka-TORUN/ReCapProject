using DataBase.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataBase.Concrete.InMemory
{
    public class InMemory : ICarDal
    {
        List<Car> _car;
        public InMemory()
        {
            _car = new List<Car>
            {
                new Car{Id= 1, BrandId=1,ClorId=1,ModelYear="2001",DailyPrice="500.000",Description="SIFIR AYARINDA"},
                new Car{Id= 2, BrandId=2,ClorId=2,ModelYear="2021",DailyPrice="50.000",Description="Yeni"}
            };
                
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car deleteCar = _car.SingleOrDefault(p => p.CarId == entity.CarId);
            _car.Remove(deleteCar);
        }

       

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(p => p.CarId == id).ToList();
        }

        public void Update(Car entity)
        {
            Car updateCar = _car.SingleOrDefault(p => p.CarId == entity.CarId);
            updateCar.CarId = entity.CarId;
            updateCar.ColorId = entity.ColorId;
            updateCar.BrandId = entity.BrandId;
            updateCar.DailyPrice = entity.DailyPrice;
            updateCar.Description = entity.Description;
            updateCar.ModelYear = entity.ModelYear;
        }
    }
}
