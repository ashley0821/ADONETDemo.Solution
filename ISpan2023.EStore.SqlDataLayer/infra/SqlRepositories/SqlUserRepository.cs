using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories
{
	public class SqlUserRepository : IUserRepository
	{
		public User Get(int userId)
		{
			throw new NotImplementedException();
		}

		public User GetByAccount(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account = @Account";

			SqlParameter parameter = new SqlParameter("@Account", System.Data.SqlDbType.NVarChar, 50) { Value = account };

			Func<SqlDataReader, User> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string acc = reader.GetString("Account");
				string password = reader.GetString("Password");
				return new User() { Id = id, Account = acc, Password = password };
			};

			return sqlDb.Get<User>(sqlDb.GetConnection, funcAssembler, sql, parameter);
		}
	}
}
