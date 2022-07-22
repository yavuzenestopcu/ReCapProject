using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//CarTest();
			RentalTest();

		}

		private static void RentalTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());

			foreach (var rental in rentalManager.GetAll().Data)
			{
				Console.WriteLine(rental.Id + " " + rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
			}
			//Console.WriteLine(rentalManager.Update(new Rental { Id = 2, CarId = 2, CustomerId = 3, RentDate = DateTime.Now.Date, ReturnDate = DateTime.Now.Date }).Message);

			//Console.WriteLine(rentalManager.Add(new Rental { Id = 2, CarId = 2, CustomerId = 1, RentDate = DateTime.Now.Date }).Message);
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			var result = carManager.GetCarDetails();

			if (result.Success == true)
			{
				foreach (var car in result.Data)
				{
					Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}
		}
	}
}
