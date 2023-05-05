using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class ProductRepository
	{
		public int Create(ProductAddOrEditDto dto)
		{
			string sql = @"INSERT INTO Products
(CategoryId, Name, Description, Price, Status, ProductImage, Stock)
VALUES
(@CategoryId, @Name, @Description, @Price, @Status, @ProductImage, @Stock)";

			var parameters = SqlParameterBuilder.create()
				.AddInt("@CategoryId", dto.CategoryId)
				.AddNvarchar("@Name", 50, dto.Name)
				.AddNvarchar("@Description", 3000, dto.Description)
				.AddInt("@Price", dto.Price)
				.AddBit("@Status", dto.Status)
				.AddNvarchar("@ProductImage", 70, dto.ProductImage)
				.AddInt("@Stock", dto.Stock)
				.Build();

			return sqlDb.Create(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public int Delete(int productId)
		{
			string sql = @"DELETE Products WHERE Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddInt("@Id", productId)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public ProductAddOrEditDto Get(int productId)
		{
			Func<SqlConnection> funcConn = sqlDb.GetConnection;//委派

			var sql = $"SELECT * FROM Products WHERE Id = {productId}";

			Func<SqlDataReader, ProductAddOrEditDto> funcAssembler = reader => {
				return new ProductAddOrEditDto
				{
					Id = productId,
					CategoryId = reader.GetInt32("CategoryId", 0),
					Name = reader.GetString("Name"),
					Description = reader.GetString("Description"),
					Price = reader.GetInt32("Price", 0),
					Status = reader.GetBool("Status", false),
					ProductImage = reader.GetString("ProductImage"),
					Stock = reader.GetInt32("Stock", 0),
				}; 
			};

			return sqlDb.Get(funcConn, funcAssembler, sql);
		}

		public List<ProductDto> Search(int? categoryId = null)
		{
			Func<SqlConnection> funcConn = sqlDb.GetConnection;

			#region sql
			var sql = @"SELECT P.ID, P.Name, P.Price, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories as C ON C.Id = P.CategoryId";

			if (categoryId.HasValue)
			{
				//WHERE前面要加空格
				sql += " WHERE C.Id=" + categoryId.Value;
			}

			//ORDER BY前面要加空格
			sql += " ORDER BY C.DisplayOrder";
			#endregion

			Func<SqlDataReader, ProductDto> funcAssembler = reader =>
			{
				return new ProductDto()
				{
					ProductId = reader.GetInt32("Id", 0),
					ProductName = reader.GetString("Name"),
					Price = reader.GetInt32("Price", 0),
					CategoryName = reader.GetString("CategoryName")
				};
			};

			return sqlDb.Search<ProductDto>(funcConn, funcAssembler, sql); //這個要指定型別 因為程式無法自動判斷
		}


		public List<ProductDto> Search2(int? categoryId = null)
		{
			using (SqlConnection conn = sqlDb.GetConnection("default"))
			{
				conn.Open();

				var sql = @"SELECT P.ID, P.Name, P.Price, C.Name as CategoryName
FROM Products as P
INNER JOIN Categories as C ON C.Id = P.CategoryId";

				if (categoryId.HasValue)
				{
					//WHERE前面要加空格
					sql = sql + " WHERE C.Id=" + categoryId.Value;
				}

				//ORDER BY前面要加空格
				sql = sql + " ORDER BY C.DisplayOrder";

				var products = new List<ProductDto>();

				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					//再reader不再使用時，自動關閉connection

					while (reader.Read())
					{
						ProductDto dto = new ProductDto()
						{
							ProductId = reader.GetInt32("Id", 0),
							ProductName = reader.GetString("Name"),
							Price = reader.GetInt32("Price", 0),
							CategoryName = reader.GetString("CategoryName")
						};
						products.Add(dto);
					}
				}
				return products;
			}
		}

		public int Update(ProductAddOrEditDto dto)
		{
			string sql = @"UPDATE Products SET
CategoryId = @CategoryId,
Name = @Name,
Description = @Description,
Price = @Price,
Status = @Status,
ProductImage = @ProductImage,
Stock = @Stock
WHERE
Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddInt("@CategoryId", dto.CategoryId)
				.AddNvarchar("@Name", 50, dto.Name)
				.AddNvarchar("@Description", 3000, dto.Description)
				.AddInt("@Price", dto.Price)
				.AddBit("@Status", dto.Status)
				.AddNvarchar("@ProductImage", 70, dto.ProductImage)
				.AddInt("@Stock", dto.Stock)
				.AddInt("@Id", dto.Id)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}
	}

	public class ProductDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Price { get; set; }
		public string CategoryName { get; set; }
	}

	public class ProductAddOrEditDto
	{
		public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public string ProductImage { get; set; }
        public int Stock { get; set; }
    }
}