using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer
{
	public static class SqlDataReaderExtensions
	{
		//如果欄位名稱不存在，會引發異常
		public static string GetString (this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal (columnName);//取得第幾欄
			return reader.IsDBNull(colIndex)
				? null
				: reader.GetString (colIndex);
		}

		public static bool? GetBool(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (bool?)null
				: reader.GetBoolean(colIndex);
		}

		public static bool GetBool(this SqlDataReader reader, string columnName, bool defaultValue)
		{
			bool? result = reader.GetBool(columnName);//這支是呼叫上面那一支
			return result.HasValue ? result.Value : defaultValue;
		}

		public static int? GetInt32(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (int?)null
				: reader.GetInt32(colIndex);//這支是內建的
		}

		public static int GetInt32(this SqlDataReader reader, string columnName, int defaultValue)
		{
			int? result = reader.GetInt32(columnName);//這支是呼叫上面那一支
			return result.HasValue ? result.Value : defaultValue;
		}

		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}

		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}
	}
}
