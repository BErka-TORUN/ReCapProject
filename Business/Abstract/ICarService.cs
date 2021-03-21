using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Brand>> GetCarsByBrandId(int id);
        IDataResult<List<Color>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarsDailyPrice();
        IDataResult<Car> Add(Car car);
    }
}
