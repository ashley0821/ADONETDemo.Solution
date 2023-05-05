using ISpan2023.EStore.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.interfaces
{
	public interface ICategoryRepository
	{
		void Create(CategoryEntity entity);
		void Update(CategoryEntity entity);
		void Delete(int categoryId);
		CategoryEntity Get(int categoryId);

		//需要join資料表時，回傳dto比較恰當
		List<CategoryEntity> Search(string categoryName, int? categoryId);
	}
}
