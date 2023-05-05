using ISpan.MultiLayers.WinApp.ViewModels;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using ISpan2023.EStore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.MultiLayers.WinApp
{
	public partial class FormAddCategory : Form
	{
		public FormAddCategory()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;

			bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);

			if (!isInt)
			{
				MessageBox.Show("displayOrder必須輸入整數");
				return;
			}

			CategoryAddVM vm = new CategoryAddVM()
			{
				Name = name,
				DisplayOrder = displayOrder,
			};

			//todo, 驗證欄位是否正確

			//把vm轉成dto
			CategoryAddDto dto = vm.ToDto();

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			service.Create(dto);

			//新增完成，關閉自己，並通知Owner更新內容
			//泛化 : 把要處理的表單轉成介面
			IGrid owner = (IGrid)this.Owner;//= this.Owner as IGrid 比較溫和 沒有轉型成功會變成null
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
	}
}
