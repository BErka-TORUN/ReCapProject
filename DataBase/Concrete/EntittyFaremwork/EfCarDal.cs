using Core.DateBase.EfEntityFaremworkBase;
using DataBase.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Concrete.EntittyFaremwork
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarDataBaseContext>,ICarDal
    {

    }
}
