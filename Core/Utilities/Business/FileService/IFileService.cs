using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Business.FileService
{
	public interface IFileService
	{
		string Upload(IFormFile file, string root);
		string Update(IFormFile file, string filePath, string root);
		void Delete(string filePath);
	}
}
