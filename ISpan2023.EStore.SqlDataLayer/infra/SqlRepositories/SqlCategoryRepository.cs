using ISpan2023.EStore.SqlDataLayer.Core;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories
{
	public class SqlCategoryRepository : ICategoryRepository
	{
		public void Create(CategoryEntity entity)
		{
			string sql = "INSERT INTO Categories (Name, DisplayOrder) VALUES(@Name, @DisplayOrder)";

			var parameter = SqlParameterBuilder.create()
				.AddNvarchar("@Name", 20, entity.Name)
				.AddInt("@DisplayOrder", entity.DisplayOrder)
				.Build();

			sqlDb.Create(sqlDb.GetConnection, sql, parameter);
		}

		public void Delete(int categoryId)
		{
			string sql = "DELETE FROM Categories WHERE Id = " + categoryId;

			sqlDb.UpdateOrDelete(sqlDb.GetConnection, sql, null);
		}

		public CategoryEntity Get(int categoryId)
		{
			string sql = "SELECT * FROM Categories WHERE Id = " + categoryId;

			Func<SqlDataReader, CategoryEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder", 0);

				return new CategoryEntity(name, displayOrder, id);
			};

			return sqlDb.Get<CategoryEntity>(sqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<CategoryEntity> Search(string categoryName, int? categoryId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();//不知道要加幾個 所以用list而不是array

			string sql = "SELECT * FROM Categories";

			#region 組合出where條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(categoryName) == false)
			{
				where += " AND name = @name";
				parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20) { Value = categoryName });
			}

			if (categoryId.HasValue)
			{
				where += " AND id =" + categoryId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);//去除前面的" AND "
			sql += where;
			#endregion

			sql += " ORDER BY DisplayOrder";

			Func<SqlDataReader, CategoryEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder", 0);

				return new CategoryEntity(name, displayOrder, id);
			};

			return sqlDb.Search<CategoryEntity>(sqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(CategoryEntity entity)
		{
			string sql = "UPDATE Categories SET name = @name, DisplayOrder = @DiaplayOrder WHERE Id = @Id";

			var parameters = SqlParameterBuilder.create()
				             .AddInt("@Id", entity.Id)
							 .AddNvarchar("@name", 20, entity.Name)
							 .AddInt("@DiaplayOrder", entity.DisplayOrder)
							 .Build();

			sqlDb.UpdateOrDelete(sqlDb.GetConnection, sql, parameters);
		}
	}
}
