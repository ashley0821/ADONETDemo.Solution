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
	public partial class FormCategories : Form, IGrid
	{
		private List<CategoryVM> vm;
		public FormCategories()
		{
			InitializeComponent();
		}

		private void FormCategories_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		public void Display()
		{
			string name = txtName.Text;
			int? id = int.TryParse(txtId.Text, out int num) ? num : (int?)null;

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			//List<CategoryDto> data = service.Search(name, id);
			//List<CategoryVM> vm = data.Select(x => x.ToViewModel()).ToList();

			vm = service.Search(name, id)
				        .Select(x => x.ToViewModel())
					    .ToList();
			dataGridView1.DataSource = vm;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormAddCategory();

			//owner縮小時，視窗會一起縮小
			//視窗關掉後，owner會自動更新
			frm.Owner = this;

			frm.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;//點到標題欄不算

			int categoryId = vm[e.RowIndex].Id;

			var frm = new FormEditCategory(categoryId);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
