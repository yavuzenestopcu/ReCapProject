using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		Car GetById(int carId);
		List<Car> GetAll();
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
		List<CarDetailDto> GetCarDetails();

	}
}
