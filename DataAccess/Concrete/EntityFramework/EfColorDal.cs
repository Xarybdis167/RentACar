
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext> , IColorDal
    {
    }
}
