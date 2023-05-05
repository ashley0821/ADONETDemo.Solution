using ISpan2023.EStore.SqlDataLayer;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.MultiLayers.WinApp.ViewModels
{
	/// <summary>
	/// 供FormCategories使用的view model
	/// </summary>
	public class CategoryVM
	{
        public int Id { get; set; }

		[Display(Name = "分類名稱")]
		public string Name { get; set; }

		[Display(Name = "顯示順序")]
		public int DisplayOrder { get; set; }
    }

	public static class CategoryDtoExts
	{
		public static CategoryVM ToViewModel (this CategoryDto dto)
		{
			return new CategoryVM
			{
				Id = dto.Id,
				Name = dto.Name,
				DisplayOrder = dto.DisplayOrder,
			};
		}
	}

	/// <summary>
	/// 供FormAddCategories使用
	/// </summary>
	public class CategoryAddVM
	{
		//public int Id { get; set; }

		[Display(Name = "分類名稱")]
		[Required(ErrorMessage = "分類名稱必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可大於{1}")]
		public string Name { get; set; }

		[Display(Name = "顯示順序")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1,1000, ErrorMessage = "{0}必須介於1-1000")]
		public int? DisplayOrder { get; set; }
	}

	public static class CategoryAddVMExts
	{
		public static CategoryAddDto ToDto (this CategoryAddVM vm)
		{
			return new CategoryAddDto
			{
				Name = vm.Name,
				DisplayOrder = vm.DisplayOrder.HasValue ? vm.DisplayOrder.Value : 0
			};
		}
	}

	/// <summary>
	/// 供FormEditCategories使用
	/// </summary>
	public class CategoryEditVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }

		[Display(Name = "分類名稱")]
		[Required(ErrorMessage = "分類名稱必填")]
		[MaxLength(30, ErrorMessage = "{0}長度不可大於{1}")]
		public string Name { get; set; }

		[Display(Name = "顯示順序")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1, 1000, ErrorMessage = "{0}必須介於1-1000")]
		public int DisplayOrder { get; set; }
	}

	public static class CategoryEditVMExts
	{
		public static CategoryEditDto ToDto (this CategoryEditVM vm)
		{
			return new CategoryEditDto
			{
				Id = vm.Id,
				Name = vm.Name,	
				DisplayOrder = vm.DisplayOrder
			};
		}

		public static CategoryEditVM ToViewModel (this CategoryEditDto dto)
		{
			return new CategoryEditVM
			{
				Id = dto.Id,
				Name = dto.Name,
				DisplayOrder = dto.DisplayOrder,
			};
		}
	}
}
