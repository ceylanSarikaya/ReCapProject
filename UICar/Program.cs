using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace UICar
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());


            //Veritabanına Model Ekleme İşlemleri
            //brandManager.Add(new Brand { BrandName = "Bmw" });
            //brandManager.Add(new Brand { BrandName = "FIAT" });
            //brandManager.Add(new Brand { BrandName = "Mercedes" });

            //Veritabanına Model Silme  İşlemleri
            //brandManager.Delete(new Brand {BrandId = 4});

            //Veritabanına Model Guncelleme  İşlemleri
            //brandManager.Update(new Brand { BrandId = 2, BrandName = "FIAT" });


            //Veritabanına Renk Ekleme İşlemleri
            //colorManager.Add(new Color { ColorName = "Black" });
            //colorManager.Add(new Color { ColorName = "Blue" });
            //colorManager.Add(new Color { ColorName = "White" });
            //colorManager.Add(new Color { ColorName = "Orange" });

            //Veritabanına Renk Silme İşlemleri
            //colorManager.Delete(new Color {ColorId = 2,ColorName = "Blue" });

            ////Veritabanına Renk Güncelleme İşlemleri
            //colorManager.Update(new Color { ColorId = 3, ColorName = "White" });


            //Veritabanına Araba Ekleme İşlemleri
            // carManager.Add(new Car {BrandId=1,ColorId=5,ModelYear="2008",DailyPrice=0 ,Description="" }); #Girilemez
            //carManager.Add(new Car { BrandId = 1, ColorId = 5, ModelYear = "2008", DailyPrice = 380, Description = "" }); //#Ürün eklendi
            //carManager.Add(new Car { BrandId = 1, ColorId = 5, ModelYear = "2018", DailyPrice = 500, Description = "" });

            //Veritabanına Araba Silme İşlemleri
            //carManager.Delete(new Car { CarId = 24});

            //Veritabanına Araba Güncelleme İşlemleri
            //carManager.Update(new Car { CarId = 25, BrandId = 1, ColorId = 8, ModelYear = "2009", DailyPrice = 280, Description = "" });

            //foreach (var car in carManager.GetCarDetailDtos())
            //{
            //    Console.WriteLine(car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
            //}

        }
    }
}
