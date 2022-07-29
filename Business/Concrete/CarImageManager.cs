using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Business.FileService;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
	public class CarImageManager : ICarImageService
	{
		ICarImageDal _carImageDal;
		IFileService _fileService;

		public CarImageManager(ICarImageDal carImageDal, IFileService fileService)
		{
			_carImageDal = carImageDal;
			_fileService = fileService;
		}
		public IDataResult<List<CarImage>> GetAll()
		{
			return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
		}

		public IDataResult<CarImage> GetById(int imageId)
		{
			return new SuccessDataResult<CarImage>(_carImageDal.Get(p => p.Id == imageId));
		}

		public IResult Add(IFormFile file, CarImageDto carImageDto)
		{
			IResult result = BusinessRules.Run(CheckIfImageCountOfCarCorrect(carImageDto.CarId));

			if (result != null)
			{
				return result;
			}
			string filePath = _fileService.Upload(file, PathConstants.ImagesRootPath);
			CarImage carImage = new CarImage { Id = carImageDto.Id, CarId = carImageDto.CarId, ImagePath = filePath, Date = DateTime.Now };
			_carImageDal.Add(carImage);
			return new SuccessResult(Messages.ImageAdded);
		}

		public IResult Delete(CarImage carImage)
		{
			string filePath = _carImageDal.Get(p => p.Id == carImage.Id).ImagePath;
			if (filePath != null)
			{
				_fileService.Delete(filePath);
				_carImageDal.Delete(carImage);
				return new SuccessResult(Messages.ImageDeleted);
			}
			return new ErrorResult();
		}

		public IResult Update(IFormFile file, CarImage carImage)
		{
			string filePath = _fileService.Update(file, carImage.ImagePath, PathConstants.ImagesRootPath);
<<<<<<< HEAD
			CarImage updatedCarImage = new CarImage { Id = carImage.Id, CarId = carImage.CarId, ImagePath = filePath, Date = DateTime.Now };
			_carImageDal.Update(updatedCarImage);
=======
			//CarImage updateCarImage = new CarImage { Id = carImage.Id, CarId = carImage.CarId, ImagePath = filePath, Date = DateTime.Now };
			_carImageDal.Update(carImage);
>>>>>>> 19a388644960aefe3fc0220efb5334e5c49d38d5
			return new SuccessResult(Messages.ImageUpdated);
		}

		public IDataResult<List<CarImage>> GetAllByCarId(int carId)
		{
			var result = BusinessRules.Run(CheckIfCarImageExists(carId));
			if (result == null)
			{
				return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == carId));
			}
			return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
		}

		private IResult CheckIfImageCountOfCarCorrect(int carId)
		{
			var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
			if (result >= 5)
			{
				return new ErrorResult(Messages.ImageCountOfCarError);
			}
			return new SuccessResult();
		}

		private IResult CheckIfCarImageExists(int carId)
		{
			var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
			if (result > 0)
			{
				return new SuccessResult();
			}
			return new ErrorResult();
		}

		private IDataResult<List<CarImage>> GetDefaultImage(int carId)
		{
			List<CarImage> carImages = new List<CarImage>();
			carImages.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "wwwroot\\Uploads\\Images\\DefaultVehicle.png" });
			return new SuccessDataResult<List<CarImage>>(carImages);
		}

	}
}
