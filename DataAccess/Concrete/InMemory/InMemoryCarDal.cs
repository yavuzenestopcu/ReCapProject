using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entitites.Concrete;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;

		public InMemoryCarDal()
		{
			_cars = new List<Car> {
				new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 25, Description = "Arac1", ModelYear="2011" },
				new Car { Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 50, Description = "Arac2", ModelYear="2010" },
				new Car { Id = 3, BrandId = 2, ColorId = 4, DailyPrice = 35, Description = "Arac3", ModelYear="2019" },
				new Car { Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 29, Description = "Arac4", ModelYear="2020" },
				new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 100, Description = "Arac5", ModelYear="2022" }
			};
		}

		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
			_cars.Remove(carToDelete);
		}

		public Car Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetById(int carId)
		{
			return _cars.Where(c => c.Id == carId).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
			carToUpdate.ModelYear = car.ModelYear;
		}
	}
}
