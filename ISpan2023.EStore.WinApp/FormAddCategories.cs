using ISpan2023.EStore.SqlDataLayer;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormAddCategories : Form
	{
		public FormAddCategories()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);
			if (!isInt)
			{
				MessageBox.Show("請輸入display order, 再試一次");
				return;
			}

			var category = new CategoryDto
			{
				Name = txtName.Text,
				DisplayOrder = displayOrder
			};

			int id = new CategoryRepository().Create(category);
			MessageBox.Show($"記錄已新增，id={id}");
		}
	}
}
