using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from crs in context.Cars
                             join clr in context.Colors
                             on crs.ColorId equals clr.Id
                             join brnd in context.Brands
                             on crs.BrandId equals brnd.Id
                             select new CarDetailDto
                             {
                                 CarName = crs.Description,
                                 ColorName = clr.Name,
                                 BrandName = brnd.Name,
                                 DailyPrice = crs.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
