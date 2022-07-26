﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IColorService
	{
		IDataResult<Color> GetById(int colorId);
		IDataResult<List<Color>> GetAll();
		IResult Add(Color color);
		IResult Delete(Color color);
		IResult Update(Color color);
	}
}
