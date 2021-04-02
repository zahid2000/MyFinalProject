﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid="Urun ismi gecersiz";
        public static string MaintenanceTime="Sistem bakimda";
        public static string Productlisted="Urunler listelendi";
        public static string ProductUpdated = "Urun guncellendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 urun ola bilir";
        public static string ProductNameAlreadyExists="Bu isimde zaten baska  bir urun var";
       
        public static string CategoryLimitExceded="Kategori limiti asildigi ucun yeni urun eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayi oldu";
        public static string UserNotFound ="Kullanici bulunamadi";
        public static string PasswordError="Parola hatasi";
        public static string SuccessfulLogin="Basarili giris";
        public static string UserAlreadyExists="Kullanici mevcut";
        public static string AccessTokenCreated="Token olusturuldu";
    }
}
