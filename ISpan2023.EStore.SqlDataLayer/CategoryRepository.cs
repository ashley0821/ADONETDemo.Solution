using ISpan2023.EStore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class CategoryRepository
	{
		public int Create(CategoryDto category)
		{
			Func<SqlConnection> funcConn = sqlDb.GetConnection;

			string sql = @"insert into Categories 
(Name, DisplayOrder)
values (@Name, @DisplayOrder)";

			var parameters = SqlParameterBuilder.create()
	.AddNvarchar("@Name", 30, category.Name)
	.AddInt("@DisplayOrder", category.DisplayOrder)
	.Build();

			return sqlDb.Create(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public int Delete(int categoryId)
		{
			string sql = @"DELETE Categories WHERE Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddInt("@Id", categoryId)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public CategoryDto Get(int categoryId)
		{
			var sql = $"SELECT * FROM Categories WHERE Id = {categoryId}";

			Func<SqlConnection> funcConn = sqlDb.GetConnection;

			Func<SqlDataReader, CategoryDto> funcAssembler = reader => {
				return new CategoryDto
				{
					Id = reader.GetInt32("Id", 0),
					Name = reader.GetString("Name"),
					DisplayOrder = reader.GetInt32("DisplayOrder", 0)
				};
			};

			return sqlDb.Get(funcConn, funcAssembler, sql);
		}

		public Category Get2(int categoryId)
		{
			using (SqlConnection conn = sqlDb.GetConnection("default"))
			{
				conn.Open();

				var sql = $"SELECT * FROM Categories WHERE Id = {categoryId}";
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					//再reader不再使用時，自動關閉connection

					if (reader.Read())
					{
						var category = new Category();
						//category.Id = int.Parse(reader["Id"].ToString());
						//category.Name = reader["Name"].ToString();
						//category.DisplayOrder = int.Parse(reader["DisplayOrder"].ToString());

						category.Id = reader.GetInt32("Id", 0);
						category.Name = reader.GetString("Name");
						category.DisplayOrder = reader.GetInt32("DisplayOrder", 0);

						return category;
					}
					else
					{
						return null;
					}

				}
			}
		}

		public List<CategoryDto> Search(int? categoryId = null)
		{
			Func<SqlConnection> funcConn = sqlDb.GetConnection;//委派

			var sql = $"SELECT * FROM Categories as C";

			if (categoryId.HasValue)
			{
				//WHERE前面要加空格
				sql += " WHERE C.Id=" + categoryId.Value;
			}

			//ORDER BY前面要加空格
			sql += " ORDER BY C.Id";

			Func<SqlDataReader, CategoryDto> funcAssembler = reader => {
				return new CategoryDto
				{
					Id = reader.GetInt32("Id",0),
					Name = reader.GetString("Name"),
					DisplayOrder = reader.GetInt32("DisplayOrder", 0)
				};
			};

			return sqlDb.Search<CategoryDto>(funcConn, funcAssembler, sql);
		}

		public int Update(CategoryDto dto)
		{
			string sql = @"UPDATE Categories SET
Name = @Name,
DisplayOrder = @DisplayOrder
WHERE
Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddNvarchar("@Name", 30, dto.Name)
				.AddInt("@DisplayOrder", dto.DisplayOrder)
				.AddInt("@Id", dto.Id)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}
	}

	//public class CategoryDto
	//{
	//	public int Id { get; set; }
	//	public string Name { get; set; }
	//	public int DisplayOrder { get; set; }
	//}
}
