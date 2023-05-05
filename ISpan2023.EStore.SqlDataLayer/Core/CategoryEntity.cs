using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Core
{
	public class CategoryEntity
	{
		//屬性做readonly即可，不允許修改
		public int Id { get; private set; }
		public string Name { get; private set; }
		public int DisplayOrder { get; private set; }

		public CategoryEntity(string name, int displayName, int id = 0)
		{
			//todo 在這裡，檢查各傳入值的正確性

			this.Id = id;
			this.Name = name;
			this.DisplayOrder = displayName;
		}
	}
}
