using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalsService
    {
        public IDataResult<List<Rental>> Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorDataResult<List<Rental>>(Messages.RentalNull);
            }
            return new SuccessDataResult<List<Rental>>(Messages.RentalAdd);
        }
    }
}
