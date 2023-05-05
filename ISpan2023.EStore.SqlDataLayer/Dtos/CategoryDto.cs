using ISpan2023.EStore.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan2023.EStore.SqlDataLayer.Dtos
{
	/// <summary>
	/// 供search結果使用
	/// </summary>
	public class CategoryDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}

	public static class CategoryEntityExts
	{
		public static CategoryDto ToDto(this CategoryEntity entity)
		{
			return new CategoryDto
			{
				Id = entity.Id,
				Name = entity.Name,
				DisplayOrder = entity.DisplayOrder,
			};
		}
	}

	public class CategoryAddDto
	{
		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}

	public static class CategoryAddDtoExts
	{
		public static CategoryEntity ToEntity(this CategoryAddDto dto)
		{
			return new CategoryEntity(dto.Name, dto.DisplayOrder);
		}
	}

	public class CategoryEditDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int DisplayOrder { get; set; }
	}

	public static class CategoryEditDtoExts
	{
		public static CategoryEditDto ToEditDto(this CategoryEntity entity)
		{
			return new CategoryEditDto
			{
				Id = entity.Id,
				Name = entity.Name,
				DisplayOrder = entity.DisplayOrder,
			};
		}

		public static CategoryEntity ToEntity(this CategoryEditDto dto)
		{
			return new CategoryEntity(dto.Name, dto.DisplayOrder, dto.Id);
		}
	}
}
