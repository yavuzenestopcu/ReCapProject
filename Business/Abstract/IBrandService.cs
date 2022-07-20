using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IBrandService
	{
		Brand GetById(int brandId);
		List<Brand> GetAll();
		void Add(Brand brand);
		void Delete(Brand brand);
		void Update(Brand brand);
	}
}
