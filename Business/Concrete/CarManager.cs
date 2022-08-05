using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

		public IDataResult<Car> GetById(int carId)
		{
			return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == carId));
		}

		public IDataResult<List<Car>> GetAll()
		{
			if (DateTime.Now.Hour == 18)
			{
				return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
			}
			else
			{
				return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
			}
		}

		[SecuredOperation("car.add,admin")]
		[ValidationAspect(typeof(CarValidator))]
		public IResult Add(Car car)
		{
			_carDal.Add(car);
			return new SuccessResult(Messages.CarAdded);
		}

		public IResult Delete(Car car)
		{
			_carDal.Delete(car);
			return new SuccessResult(Messages.CarDeleted);
		}

		public IResult Update(Car car)
		{
			if (car.Description.Length >= 2 && car.DailyPrice > 0)
			{
				_carDal.Update(car);
				return new SuccessResult(Messages.CarUpdated);
			}
			else
			{
				return new ErrorResult(Messages.CarNameInvalid + "\n" + Messages.PriceInvalid);
			}
		}

		public IDataResult<List<CarDetailDto>> GetCarDetails()
		{
			if (DateTime.Now.Hour == 15)
			{
				return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
			}
			else
			{
				return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
			}
		}
	}
}
