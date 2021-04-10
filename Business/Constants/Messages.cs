using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
       
        // CAR
        public static string CarAdded = "Araba Eklendi.";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarsListed = "Arabalar Listelendi.";
        public static string CarNameInvalid = "Arabanın Günlük Fiyatı 0 Girilemez";

        // BRAND
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandsListed = "Markalar Listelendi.";
        public static string BrnadDeleted = "Marka Silindi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string BrandNameInvalid = "Marka İsmi 2 Karakterden Uzun Olmalı";

        // COLOR 
        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorsListed = "Renkler Listelendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Güncellendi.";
   

        // CUSTOMER
        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerUpdate = "Müşteri Güncellendi";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomersListed = "Müşteriler Listelendi";
    

        // USER
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UsersListed = "Kullanıcılar Listelendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdate = "Kullanıcı Güncellendi";
        public static string UserPassword = "Kullanıcı Şifresi En Az 8 Krakter Olmalı";
        public static string UserFristName = "Kullanıcı Adı Girilmelidir";
        public static string UserLastName = "Kullanıcı Soyadı Girlmelidir";
        public static string UserEmail = "Kullanıcı Email Gecersizdir";
        public static string AuthorizationDenied = "Yetkiniz Yok";



        // RENTAL
        public static string RentalAdded = "Araba Kiralama Bilgisi Eklendi.";
        public static string RentalUpdate = "Araba Kiralama Bilgisi Güncellendi";
        public static string RentalDelete = "Araba Kiralama Bilgisi Silindi";
        public static string RentalsListed = "Araba kiralama Bilgiler Listelendi";
        public static string RentalsRentDate = "Araba Kiralama Tarihi Girilmelidir";

        //CarImage
        public static string CarImageAdded = "Araba Resmi Eklendi.";
        public static string CarImageUpdate = "Araba Resmi Güncellendi";
        public static string CarImageDelete = "Araba Resmi Silindi";
        public static string CarImageListed = "Araba Resmi Listelendi";
        public static string CarImageAddingLimit = "Araba sisteminde en fazla 5 resim eklenebilir";
        public static string IncorrectFileExtension = " Araba  resmi dosya uzantısı  yanlıştır";
        public static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };

        //Card
        public static string CardAdd = "Kart Eklendi.";
        public static string CardUpdate = "Kart  Güncellendi";
        public static string CardDeleted = "Kart Silindi.";
        public static string CardListed = "Kart  Listelendi";

        // SYSTEM
        public static string MaintenanceTime = "Sistem Bakımda";

 
    }
}
