using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IRentalService
	{
		IDataResult<Rental> GetById(int rentalId);
		IDataResult<List<Rental>> GetAll();
		IResult Add(Rental rental);
		IResult Delete(Rental rental);
		IResult Update(Rental rental);
	}
}
