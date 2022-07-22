using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IBrandService
	{
		IDataResult<Brand> GetById(int brandId);
		IDataResult<List<Brand>> GetAll();
		IResult Add(Brand brand);
		IResult Delete(Brand brand);
		IResult Update(Brand brand);
	}
}
