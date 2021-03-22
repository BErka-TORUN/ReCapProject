using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
