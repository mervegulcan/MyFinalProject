using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //veritabanı işlemleri yapacak
    public interface IOrderDal:IEntityRepository<Order>
    {
    }
}
