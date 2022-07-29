using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
	public interface ICarImageService
	{
		IDataResult<CarImage> GetById(int imageId);
		IDataResult<List<CarImage>> GetAll();
		IDataResult<List<CarImage>> GetAllByCarId(int carId);
		IResult Add(IFormFile file, CarImageDto carImageDto);
		IResult Delete(CarImage carImage);
		IResult Update(IFormFile file, CarImage carImage);
	}
}
