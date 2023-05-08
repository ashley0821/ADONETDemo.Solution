using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.interfaces
{
	public interface IUserRepository
	{
		User Get(int userId);
		User GetByAccount(string Account);
	}

	public class User
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}
}
