﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{
		IColorDal _colorDal;

		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public void Add(Color color)
		{
			_colorDal.Add(color);
		}

		public void Delete(Color color)
		{
			_colorDal.Delete(color);
		}

		public Color GetById(int colorId)
		{
			return _colorDal.Get(p=> p.Id == colorId);
		}

		public List<Color> GetAll()
		{
			return _colorDal.GetAll();
		}

		public void Update(Color color)
		{
			_colorDal.Update(color);
		}
	}
}
