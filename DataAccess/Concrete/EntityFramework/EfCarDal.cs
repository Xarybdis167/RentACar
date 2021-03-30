
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 BrandName = b.Name,
                                 CarName = car.Name,
                                 ColorName = c.Name,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
