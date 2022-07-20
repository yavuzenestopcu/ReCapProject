using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IColorService
	{
		Color GetById(int colorId);
		List<Color> GetAll();
		void Add(Color color);
		void Delete(Color color);
		void Update(Color color);
	}
}
