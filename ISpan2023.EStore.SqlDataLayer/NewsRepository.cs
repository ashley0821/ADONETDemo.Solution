using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public class NewsRepository
	{
		public int Create(NewsDto dto)
		{
			string sql = @"INSERT INTO News
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, DEFAULT, DEFAULT)";

			var parameters = SqlParameterBuilder.create()
				.AddNvarchar("@Title", 50, dto.Title)
				.AddNvarchar("@Description", 3000, dto.Description)
				.Build();

			return sqlDb.Create(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public int Create2(NewsDto dto)
		{
			//SET NOCOUNT ON : 不要顯示"(一個資料列受影響)"
			//SCOPE_IDENTITY : 取得新增資料的自動編號
			string sql = @"SET NOCOUNT ON;
INSERT INTO News
(Title, Description, CreatedTime, ModifiedTime)
VALUES
(@Title, @Description, DEFAULT, DEFAULT);
SET @newId = SCOPE_IDENTITY()";

			//SqlParameter[] parameters = new SqlParameter[]
			//{
			//	new SqlParameter("@Title", SqlDbType.NVarChar, 50) {Value = dto.Title},
			//	new SqlParameter("@Description", SqlDbType.NVarChar, 3000) {Value = dto.Description},
			//	new SqlParameter("@newId", SqlDbType.Int) {Direction = ParameterDirection.Output},
			//};

			var parameters = SqlParameterBuilder.create()
				.AddNvarchar("@Title", 50, dto.Title)
				.AddNvarchar("@Description", 3000, dto.Description)
				.AddOutputInt("@newId")
				.Build();

			using (var conn = sqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);
					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}


		public int Delete(int newsId)
		{
			string sql = @"DELETE News WHERE Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddInt("@Id", newsId)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public int Delete2(int newsId)
		{
			string sql = @"DELETE News WHERE Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddInt("@Id", newsId)
				.Build();

			using (var conn = sqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
					//傳回被異動的筆數，若是零，代表沒有異動記錄
				}
			}
		}

		public NewsEditDto Get(int newsId)
		{
			Func<SqlConnection> funcConn = sqlDb.GetConnection;//委派

			var sql = $"SELECT * FROM News WHERE Id = {newsId}";

			Func<SqlDataReader, NewsEditDto> funcAssembler = reader => {
				return new NewsEditDto
				{
					Id = newsId,
					Title = reader.GetString("title"),
					Description = reader.GetString("description"),
					ModifiedTime = reader.GetDateTime("ModifiedTime", DateTime.MinValue)
				};
			};

			return sqlDb.Get(funcConn, funcAssembler, sql);
		}

		public NewsEditDto Get2(int newsId)
		{
			using (SqlConnection conn = sqlDb.GetConnection("default"))
			{
				conn.Open();

				var sql = $"SELECT * FROM News WHERE Id = {newsId}";
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					//再reader不再使用時，自動關閉connection

					if (reader.Read())
					{
						var dto = new NewsEditDto
						{
							Id = newsId,
							Title = reader.GetString("title"),
							Description = reader.GetString("description"),
							ModifiedTime = reader.GetDateTime("ModifiedTime", DateTime.MinValue)
						};

						return dto;
					}
					else
					{
						return null;
					}

				}
			}
		}

		public int Update(NewsEditDto dto)
		{
			string sql = @"UPDATE News SET
Title = @Title,
Description = @Description,
ModifiedTime = @ModifiedTime
WHERE
Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddNvarchar("@Title", 50, dto.Title)
				.AddNvarchar("@Description", 3000, dto.Description)
				.AddDateTime("@ModifiedTime", dto.ModifiedTime)
				.AddInt("@Id", dto.Id)
				.Build();

			return sqlDb.UpdateOrDelete(sqlDb.GetConnection,
										sql,
										parameters);
		}

		public int Update2(NewsEditDto dto)
		{
			string sql = @"UPDATE News SET
Title = @Title,
Description = @Description,
ModifiedTime = @ModifiedTime
WHERE
Id = @Id";

			SqlParameter[] parameters = SqlParameterBuilder.create()
				.AddNvarchar("@Title", 50, dto.Title)
				.AddNvarchar("@Description", 3000, dto.Description)
				.AddDateTime("@ModifiedTime", dto.ModifiedTime)
				.AddInt("@Id", dto.Id)
				.Build();

			using (var conn = sqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();
					//傳回被異動的筆數，若是零，代表沒有異動記錄
				}
			}
		}
	}
}
