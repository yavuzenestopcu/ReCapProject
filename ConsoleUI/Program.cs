using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitites.Concrete;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new EfCarDal());

			carManager.UpdateCar(new Car { Id = 3, ColorId = 3, BrandId = 2, DailyPrice = 350, Description = "BMW", ModelYear = "2015" });

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Description + " " + car.ModelYear);
			}

			foreach (var carByBrand in carManager.GetCarsByBrandId(1))
			{
				Console.WriteLine(carByBrand.ModelYear);
			}

			foreach (var carByColor in carManager.GetCarsByColorId(1))
			{
				Console.WriteLine(carByColor.ModelYear);
			}

			
		}
	}
}
