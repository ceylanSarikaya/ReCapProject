using Business.Abstract;
using DataAccess.Abstract;
using Entitys.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            if (car.BrandId>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Ürüm Markanız 2 Karekterden Uzun Olmalı!");
             
            }
            else if (car.BrandId==0)
            {
                Console.WriteLine("Ürün Maka 0 olmamalı !");
            }
            else
            {
                Console.WriteLine(" Ürün Ekleme İslemi Tamamlandı! {0}", car.Description);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(" Ürün Silme  İslemi Tamamlandı! {0}", car.Description);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllBrandId(int id)
        {
            return _carDal.GetAll(c=> c.BrandId == id);
        }

        public List<Car> GetAllColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=> c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(" Ürün Günceleme İslemi Tamalandı! {0}", car.Description);
        }
    }
}
