﻿using Core.DataAccess.EntityFramework;
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
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (CarDatabaseContext context= new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands 
                             on c.BrandId equals b.BrandId
                             join r in context.Colors 
                             on c.ColorId equals r.ColorId

                             select new CarDetailDto {CarId=c.CarId, BrandName=b.BrandName, ColorName=r.ColorName ,DailyPrice=c.DailyPrice,
                                 ModelYear=c.ModelYear,
                                 Description=c.Description,
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarsBrandIdDtos(int brandId)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             where c.BrandId==brandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarsColorIdDtos(int colorId)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                             };
                return result.ToList();
            }
        }
        public CarDetailDto GetCarIdDto(int carId)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             where c.CarId == carId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
