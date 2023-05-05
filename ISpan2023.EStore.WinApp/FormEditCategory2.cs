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
	public partial class FormEditCategory2 : Form
	{
		private int _categoryID;
		public FormEditCategory2(int categoryId)
		{
			InitializeComponent();

			this._categoryID = categoryId;
		}

		private void FormEditCategory2_Load(object sender, EventArgs e)
		{
			var category = new CategoryRepository().Get(_categoryID);
			if (category == null)
			{
				MessageBox.Show("Record not found");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			txtName.Text = category.Name;
			txtDisplayOrder.Text = category.DisplayOrder.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			bool isInt = Int32.TryParse(txtDisplayOrder.Text, out int displayOrder);
			if (!isInt)
			{
				MessageBox.Show("請輸入display order, 再試一次");
				return;
			}

			var category = new CategoryDto
			{
				Id = this._categoryID,
				Name = txtName.Text,
				DisplayOrder = displayOrder
			};

			int rowsAffected = new CategoryRepository().Update(category);

			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("記錄已更新");
			}
			else
			{
				MessageBox.Show("記錄沒有被異動，可能記錄已經被刪除");
			}

			FormEditCategory2_Load(this, EventArgs.Empty);
		}
	}
}
