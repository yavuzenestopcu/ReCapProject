using System;
using System.Collections.Generic;
using System.Text;
using Entitites.Abstract;

namespace Entitites.Concrete
{
	public class Brand : IEntity
	{
		public int BrandId { get; set; }
		public string BrandName { get; set; }
	}
}
