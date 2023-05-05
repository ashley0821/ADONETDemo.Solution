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
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryID;
		public FormEditCategory(int categoryId)
		{
			_categoryID = categoryId;
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;

			bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);

			if (!isInt)
			{
				MessageBox.Show("displayOrder必須輸入整數");
				return;
			}

			CategoryEditVM vm = new CategoryEditVM()
			{
				Id = _categoryID,
				Name = name,
				DisplayOrder = displayOrder,
			};

			//todo, 驗證欄位是否正確

			//把vm轉成dto
			CategoryEditDto dto = vm.ToDto();

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			service.Update(dto);

			//新增完成，關閉自己，並通知Owner更新內容
			IGrid owner = this.Owner as IGrid;//若用as轉型失敗會傳回null，不會丟出例外，會比顯式轉型好

			if (owner == null)
			{
				MessageBox.Show("忘記把owner實作IGrid了，請補一下");
			}
			else
			{
				owner.Display();
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			CategoryEditDto dto = service.Get(this._categoryID);

			CategoryEditVM vm = dto.ToViewModel();

			txtName.Text = vm.Name;
			txtDisplayOrder.Text = vm.DisplayOrder.ToString();9114179
		}
	}
}
