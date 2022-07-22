using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<Car> GetById(int carId);
		IDataResult<List<Car>> GetAll();
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
		IDataResult<List<CarDetailDto>> GetCarDetails();

	}
}
