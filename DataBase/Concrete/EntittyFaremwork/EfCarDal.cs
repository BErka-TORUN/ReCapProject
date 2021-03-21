using Core.DateBase.EfEntityFaremworkBase;
using DataBase.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Concrete.EntittyFaremwork
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarDataBaseContext>,ICarDal
    {
        public List<CarDetailsDTO> GetCarDetails()
        {
            using (CarDataBaseContext context=new CarDataBaseContext())
            {
                var result = from c in context.Cars
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDataBase
                             {
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 ColorId = r.ColorId,
                                 ColorName = r.ColorName
                             };
                return result.ToList();

            }
        }
    }
}
