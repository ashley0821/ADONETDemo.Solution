using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormEditProduct : Form
	{
		private int _productId;
		public FormEditProduct(int productId)
		{
			InitializeComponent();
			this._productId = productId;
		}

		private void FormEditProduct_Load(object sender, EventArgs e)
		{
			var product = new ProductRepository().Get(this._productId);
			if (product == null)
			{
				MessageBox.Show("Record not found");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			int Status = product.Status
				         ? 1
						 : 0;

			txtCategoryId.Text = product.CategoryId.ToString();
			txtName.Text = product.Name;
			txtDescription.Text = product.Description;
			txtPrice.Text = product.Price.ToString();
			txtStatus.Text = Status.ToString();
			txtProductImage.Text = product.ProductImage;
			txtStock.Text = product.Stock.ToString();
		}


		private void btnUpdate_Click(object sender, EventArgs e)
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
				Id = this._productId,
				CategoryId = CategoryId,
				Name = txtName.Text,
				Description = txtDescription.Text,
				Price = Price,
				Status = status,
				ProductImage = txtProductImage.Text,
				Stock = Stock
			};

			int rowsAffected = new ProductRepository().Update(product);

			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("記錄已更新");
			}
			else
			{
				MessageBox.Show("記錄沒有被異動，可能記錄已經被刪除");
			}

			FormEditProduct_Load(this, EventArgs.Empty);
		}
	}
}
