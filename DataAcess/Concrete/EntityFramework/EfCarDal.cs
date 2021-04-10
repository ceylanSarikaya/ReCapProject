using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDatabaseContext context= new CarDatabaseContext())
            {
                IQueryable<CarDetailDto> result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
              
                             join b in context.Brands 
                             on c.BrandId equals b.BrandId
                             join r in context.Colors 
                             on c.ColorId equals r.ColorId

                             select new CarDetailDto {CarId=c.CarId, BrandName=b.BrandName, ColorName=r.ColorName ,DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear,
                                 Description=c.Description,
                              ImagePath=(from carImage in context.CarImages where carImage.CarId == c.CarId select carImage.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }
       
    }
}
