using System;
using System.Collections.Generic;
using System.Text;
using Entitites.Concrete;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		List<Car> GetCarsByBrandId(int brandId);
		List<Car> GetCarsByColorId(int colorId);
		void AddCar(Car car);
		void DeleteCar(Car car);
		void UpdateCar(Car car);

	}
}
