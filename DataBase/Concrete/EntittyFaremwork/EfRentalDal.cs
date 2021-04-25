using Core.DateBase.EfEntityFaremworkBase;
using DataBase.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Concrete.EntittyFaremwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,CarDataBaseContext>,IRentalDal
    {
        public List<RentalDetailsDTO> GetRentalDetails()
        {
            using (CarDataBaseContext context =new CarDataBaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             select new RentalCar
                             {
                                 RentalId = r.RentalId,
                                 CarID = r.CarId,
                                 CustomerId = c.CustomerId,
                                 CustomerName = c.CustomerName,
                                 RentTime = r.RentTime,
                                 ReturnTime = r.ReturnTime
                             };
                return result.ToLİst();
            }
        }
    }
}
