using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataBase.Abstract;
using DataBase.Concrete.EntittyFaremwork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IColorDal _colorDal;
        IBrandDal _brandDal;
        public CarManager(ICarDal carDal, IColorDal colorDal, IBrandDal brandDal)
        {
            _carDal = carDal;
            _colorDal = colorDal;
            _brandDal = brandDal;
        }

        public IDataResult<Car> Add(Car car)
        {
            if (car.CarName.Length <2)
            {
                return new ErrorDataResult<Car>(Messages.DontAdded);
            }
            using (CarDataBaseContext context =new CarDataBaseContext() )
            {
                var addCar = context.Entry(car);
                addCar.State = EntityState.Added;
                context.SaveChanges();
            }
            return new SuccessDataResult<Car>(Messages.Added);
        }

        public IDataResult<List<Brand>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId == id), Messages.BrandId);
        }

        public IDataResult<List<Color>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(p => p.ColorId == id),Messages.ColorId);
        }

        public IDataResult< List<Car>> GetCarsDailyPrice()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice > 0));
        }

       
    }
}
