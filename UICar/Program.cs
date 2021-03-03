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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());




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

            //Veritabanına Renk Güncelleme İşlemleri
            //colorManager.Update(new Color { ColorId = 3, ColorName = "White" });


            //Veritabanına Araba Ekleme İşlemleri
            // carManager.Add(new Car {BrandId=1,ColorId=5,ModelYear="2008",DailyPrice=0 ,Description="" }); #Girilemez
            //carManager.Add(new Car { BrandId = 1, ColorId = 5, ModelYear = "2008", DailyPrice = 380, Description = "" }); //#Ürün eklendi
            //carManager.Add(new Car { BrandId = 1, ColorId = 5, ModelYear = "2018", DailyPrice = 500, Description = "" });

            //Veritabanına Araba Silme İşlemleri
            //carManager.Delete(new Car { CarId = 24});

            //Veritabanına Araba Güncelleme İşlemleri
            //carManager.Update(new Car { CarId = 25, BrandId = 1, ColorId = 8, ModelYear = "2009", DailyPrice = 280, Description = "" });

            //Kullanıcı Ekleme İşlemleri
            //userManager.Add(new User { UserId=7,FirstName = "Eren", LastName = "Sarıkaya", Email = "eren@gmail.com", Password = "1234567891 " });

            //Kullanıcı Silme İşlemleri
            //userManager.Delete(new User { UserId = 7 });

            //Kullanıcı Güncelleme İşlemleri
            //userManager.Update(new User { UserId=6,FirstName = "EREN", LastName = "Sarıkaya", Email = "eren@gmail.com", Password = "1234567891 " }); 

            // Kiralama Ekleme İşlemi
            //rentalManager.Add(new Rental { CarId = 2, CustomerId = 4, RentalId = 02.10.2020 12:00:00, ReturnDate = 03.10.2020 18:00:00 });

            // Kiralama Silme İşlemi
            // rentalManager.Delete(new Rental { RentalId = 2 });

            //Kiralama Güncelleme İşlemi
            // rentalManager.Update(new Rental { RentalId = 2, CarId = 2, CustomerId = 4, RentalId = 02.10.2020 12:00:02, ReturnDate = 03.10.2020 20:00:07 });

            //Müşteri Ekleme İşlemleri
            //customerManager.Add(new Customer { UserId = 2, CompanyName = "%30" });

            //Müşteri Silme İşlemleri
            //customerManager.Delete(new Customer { CustomerId = 3 });

            //Müşteri Güncellme İşlemleri
            //customerManager.Update(new Customer { CustomerId = 2, UserId = 3, CompanyName = "%10" });











            //    Console.WriteLine("-------------------------Araba Kiralama------------------------------------");
            //    DetailDtosDeneme(carManager);
            //    Console.WriteLine("-----------------Araba Bilgileri-----------------------------");
            //    cardeneme(carManager);
            //    Console.WriteLine("-----------------Kullanıcı------------------------------------");
            //    KullanıcıBilgileri(userManager);
            //    Console.WriteLine("-----------------Araba Kiralama Bilgisi------------------------");
            //    ArabaKiralamaBilgisi(rentalManager);
            //    Console.WriteLine("-----------------Müşteri Bilgisi------------------------");
            //    Musteri(customerManager);

            //}

            //private static void Musteri(CustomerManager customerManager)
            //{
            //    var result = customerManager.GetAll();
            //    if (result.Success == true)
            //    {
            //        foreach (var customerdto in result.Data)

            //        {
            //            Console.WriteLine(customerdto.CustomerId + " ==> " + customerdto.UserId + " ==> " + customerdto.CompanyName);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}

            //private static void ArabaKiralamaBilgisi(RentalManager rentalManager)
            //{
            //    var result = rentalManager.GetAll();
            //    if (result.Success == true)
            //    {
            //        foreach (var rentaldto in result.Data)

            //        {
            //            Console.WriteLine(rentaldto.RentalId + " ==> " + rentaldto.CarId + " ==> " + rentaldto.CustomerId + " ==> " + rentaldto.RentDate + " ==> " + rentaldto.ReturnDate);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}

            //private static void KullanıcıBilgileri(UserManager userManager)
            //{
            //    var result = userManager.GetAll();
            //    if (result.Success == true)
            //    {
            //        foreach (var userdto in result.Data)

            //        {
            //            Console.WriteLine(userdto.UserId + " ==>  " + userdto.FirstName + " ==> " + userdto.LastName + " ==> " + userdto.Email + " ==> " + userdto.Password);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //}

            //private static void cardeneme(CarManager carManager)
            //{
            //    foreach (var car in carManager.GetAll().Data)
            //    {
            //        Console.WriteLine(car.CarId + " ==> " + car.BrandId + " ==> " + car.ColorId + " ==> " + car.DailyPrice + " ==> " + car.Description);
            //    }
            //}

            //private static void DetailDtosDeneme(CarManager carManager)
            //{
            //    var result = carManager.GetCarDetailDtos();
            //    if (result.Success==true)
            //    {
            //        foreach (var cardto in result.Data)

            //        {
            //            Console.WriteLine(cardto.CarId + "  Numaralı  " + cardto.BrandName + "  Renkteki Aracın   " + cardto.ColorName + "  Günlük Fiyatı  " + cardto.DailyPrice);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);  
            //    }
            //}
        }
    }
}
