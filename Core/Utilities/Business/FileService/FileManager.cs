using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Core.Utilities.Helpers;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Business.FileService
{
	public class FileManager : IFileService
	{
		public void Delete(string filePath)
		{
			if(File.Exists(filePath))
			{
				File.Delete(filePath);
			}
		}

		public string Update(IFormFile file, string filePath, string root)
		{
			if(File.Exists(filePath))
			{
				File.Delete(filePath);
			}
			return Upload(file, root);
		}

		public string Upload(IFormFile file, string root)
		{
			try
			{
				if(!Directory.Exists(root))
				{
					Directory.CreateDirectory(root);
				}
				string extension = Path.GetExtension(file.FileName);
				string guid = GuidHelper.CreateGuid();
				string fileName = guid + extension;
				using (FileStream fileStream = File.Create(root + fileName))
				{
					file.CopyTo(fileStream);
					fileStream.Flush();
					return root + fileName;
				}
			}
			catch (Exception exception)
			{

				throw exception;
			}
		}
	}
}
