﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
	public static class Messages
	{
		public static string CarAdded = "Araç Eklendi.";
		public static string CarDeleted = "Araç Silindi.";
		public static string CarUpdated = "Araç Güncellendi.";
		public static string CarNameInvalid = "Araba ismi minimum 2 karakter olmalıdır.";
		public static string PriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalıdır";
		public static string CarsListed = "Araçlar listelendi.";

		public static string BrandAdded = "Marka eklendi.";
		public static string BrandDeleted = "Marka silindi.";
		public static string BrandUpdated = "Marka güncellendi.";
		public static string BrandsListed = "Markalar listelendi.";

		public static string ColorAdded = "Renk eklendi.";
		public static string ColorDeleted = "Renk silindi.";
		public static string ColorUpdated = "Renk güncellendi.";
		public static string ColorsListed = "Renkler listelendi.";

		public static string CustomerAdded = "Müşteri eklendi.";
		public static string CustomerDeleted = "Müşteri silindi.";
		public static string CustomerUpdated = "Müşteri güncellendi.";
		public static string CustomersListed = "Müşteriler listelendi.";

		public static string UserAdded = "Kullanıcı eklendi.";
		public static string UserDeleted = "Kullanıcı silindi.";
		public static string UserUpdated = "Kullanıcı güncellendi.";
		public static string UsersListed = "Kullanıcılar listelendi.";
		public static string UserRegistered = "Kayıt oldu.";
		public static string UserNotFound = "Kullanıcı bulunamadı.";
		public static string UserAlreadyExists = "Kullanıcı mevcut.";

		public static string RentalAdded = "Kiralama eklendi.";
		public static string RentalDeleted = "Kiralama silindi.";
		public static string RentalUpdated = "Kiralama güncellendi.";
		public static string RentalsListed = "Kiralamalar listelendi.";
		public static string CarNotDelivered = "Araç henüz teslim edilmedi.";

		public static string MaintenanceTime = "Bakım zamanı";

		public static string ImageCountOfCarError = "Bir aracın en fazla 5 tane resmi olabilir.";
		public static string ImageAdded = "Resim eklendi.";
		public static string ImageDeleted = "Resim silindi";
		public static string ImageUpdated = "Resim güncellendi.";

		public static string AuthorizationDenied = "Yetkiniz yok.";
		public static string PasswordError = "Parola hatası!";
		public static string SuccessfulLogin = "Başarılı giriş.";
		public static string AccessTokenCreated = "Token oluşturuldu.";
	}
}
