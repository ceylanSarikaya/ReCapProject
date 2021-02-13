using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public static string BrandNameInvalid = "Marka İsmi 2 Karakter Uzun Olmalı";

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
        public static string UserNameInvalid = "Kullanıcı Password Geçersiz.";
        public static string UsersListed = "Kullanıcılar Listelendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdate = "Kullanıcı Güncellendi";
      

        // RENTAL
        public static string RentalAdded = "Araba Kiralama Bilgisi Eklendi.";
        public static string RentalUpdate = "Araba Kiralama Bilgisi Güncellendi";
        public static string RentalDelete = "Araba Kiralama Bilgisi Silindi";
        public static string RentalsListed = "Araba kiralama Bilgiler Listelendi";

        // SYSTEM
        public static string MaintenanceTime = "Sistem Bakımda";
    }
}
