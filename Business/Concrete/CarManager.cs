using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public List<Car> GetCarsByBrandId(int brandId)
		{
			return _carDal.GetAll(p => p.BrandId == brandId);
		}

		public List<Car> GetCarsByColorId(int colorId)
		{
			return _carDal.GetAll(p => p.ColorId == colorId);
		}

		public void AddCar(Car car)
		{
			if(car.Description.Length >= 2 && car.DailyPrice > 0)
				_carDal.Add(car);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır ve araba günlük fiyatı 0'dan büyük olmalıdır");
		}

		public void DeleteCar(Car car)
		{
			_carDal.Delete(car);
		}

		public void UpdateCar(Car car)
		{
			if (car.Description.Length >= 2 && car.DailyPrice > 0)
				_carDal.Update(car);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır ve araba günlük fiyatı 0'dan büyük olmalıdır");
		}
	}
}
