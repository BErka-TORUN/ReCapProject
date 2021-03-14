using Business.Abstract;
using DataBase.Abstract;
using Entities.Concrete;
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

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(p => p.BrandId == id);
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetCarsDailyPrice()
        {
            return _carDal.GetAll(p => p.DailyPrice > 0);
        }
    }
}
