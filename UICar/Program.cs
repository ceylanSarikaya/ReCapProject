using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemory;
using Entitys.Concrete;
using System;

namespace UICar
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());




            //Car car1= new Car {BrandId = 1, ColorId = 1, ModelYear = "2008", DailyPrice = 123000};
            //Car car2 = new Car {BrandId = 2, ColorId = 2, ModelYear = "2020", DailyPrice = 260000};

            //Brand-Add-Update-Delete

            //brandManager.Add(new Brand { BrandName = "Bmw" });
            //brandManager.Add(new Brand { BrandName = "FIAT" });
            //brandManager.Add(new Brand { BrandName = "Mercedes" });

            //brandManager.Delete(new Brand {BrandId = 4});
            //brandManager.Update(new Brand {BrandId=2, BrandName = "Fiat" });

            //Color-Add-Update-Delete

            //colorManager.Add(new Color { ColorName = "Black" });
            //colorManager.Add(new Color { ColorName = "Blue" });
            //colorManager.Add(new Color { ColorName = "White" });

            //colorManager.Delete(new Color {ColorId = 2,ColorName = "Blue" });

            //colorManager.Update(new Color { ColorId = 3, ColorName = "WHITE" });

            //Color-Add-Update-Delete

            //carManager.Add(car1);
            //carManager.Delete(car2);
            //carManager.Update(car1);





            //foreach (var product in carManager.GetAll())
            //{

            //    Console.WriteLine(product.Id+ "-"+product.BrandId+"-"+product.ColorId+"-"+"-"+product.ModelYear+"-"+product.DailyPrice);
            //}
        }
    }
}
