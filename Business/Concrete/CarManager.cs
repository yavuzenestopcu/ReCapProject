using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public Car GetById(int carId)
		{
			return _carDal.Get(p=> p.Id == carId);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}

		public void Add(Car car)
		{
			if(car.Description.Length >= 2 && car.DailyPrice > 0)
				_carDal.Add(car);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır ve araba günlük fiyatı 0'dan büyük olmalıdır");
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public void Update(Car car)
		{
			if (car.Description.Length >= 2 && car.DailyPrice > 0)
				_carDal.Update(car);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır ve araba günlük fiyatı 0'dan büyük olmalıdır");
		}

		public List<CarDetailDto> GetCarDetails()
		{
			return _carDal.GetCarDetails();
		}
	}
}
