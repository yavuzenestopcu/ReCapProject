using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Core.Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
		IDataResult<List<OperationClaim>> GetClaims(User user);
		IDataResult<User> GetByMail(string email);
		IDataResult<User> GetById(int userId);
		IDataResult<List<User>> GetAll();
		IResult Add(User user);
		IResult Delete(User user);
		IResult Update(User user);
	}
}
