using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductCarDal  //ICarDal
    {

        List<Car> _car;
        public InMemoryProductCarDal()
        {
            _car = new List<Car> { new Car {CarId=1,BrandId=2,ColorId=1,ModelYear="2007",DailyPrice=107 }
             //new ProductCar {Id=2,BrandId=2,ClorId=3,Model="Comfortline",ModelYear=2010,DailyPrice="210.000 ₺" },
             //new ProductCar {Id=3,BrandId=2,ClorId=3,Model="Maserati ",ModelYear=2005,DailyPrice="160.000 ₺" },
             //new ProductCar {Id=4,BrandId=3,ClorId=4,Model="wosvagen",ModelYear=2020,DailyPrice="280.000 ₺" },
             //new ProductCar {Id=5,BrandId=5,ClorId=5,Model=" Citroën",ModelYear=2009,DailyPrice="130.000 ₺" },
             //new ProductCar {Id=6,BrandId=5,ClorId=9,Model=" Doblo",ModelYear=1999,DailyPrice="70.000 ₺" },
            };
        }
   


        public void Add(Car product)
        {
            _car.Add(product);
        }

     

     

        public void Delete(Car product)
        {
           Car productDelete = _car.SingleOrDefault(p => p.CarId == product.CarId);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllBrand(int brandId)
        {
            return _car.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllClor(int clorId)
        {
            return _car.Where(p => p.ColorId == clorId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Update(Car product)
        {
            Car productUpdate = _car.SingleOrDefault(p => p.CarId == product.CarId);
            productUpdate.BrandId = product.BrandId;
            productUpdate.ColorId=product.ColorId;
            productUpdate.ModelYear = product.ModelYear;
            productUpdate.DailyPrice = product.DailyPrice;
        }

    
    }
}
