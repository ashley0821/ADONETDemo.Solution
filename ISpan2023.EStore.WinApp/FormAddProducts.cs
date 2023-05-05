using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormAddProducts : Form
	{
		public FormAddProducts()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			

			bool isInt = int.TryParse(txtCategoryId.Text, out int CategoryId);
			if (!isInt)
			{
				MessageBox.Show("請重新輸入Category Id，再試一次");
				return;
			}

			isInt = int.TryParse(txtPrice.Text, out int Price);
			if (!isInt)
			{
				MessageBox.Show("請重新輸入Price，再試一次");
				return;
			}

			isInt = int.TryParse(txtStock.Text, out int Stock);
			if (!isInt)
			{
				MessageBox.Show("請重新輸入Stock，再試一次");
				return;
			}

			bool status;

			if (txtStatus.Text == "0")
			{
				status = false;
			}
			else if (txtStatus.Text == "1")
			{
				status = true;
			}
			else if (!bool.TryParse(txtStatus.Text, out status))
			{
				MessageBox.Show("请重新输入有效的 Status 值");
				return;
			}

			var product = new ProductAddOrEditDto
			{
				CategoryId = CategoryId,
				Name = txtName.Text,
				Description = txtDescription.Text,
				Price = Price,
				Status = status,
				ProductImage = txtProductImage.Text,
				Stock = Stock
			};

			int id = new ProductRepository().Create(product);
			MessageBox.Show($"記錄已新增，id={id}");
		}
	}
}
