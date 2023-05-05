using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan2023.EStore.WinApp
{
	public partial class Form1 : Form
	{
        public Form1()
		{
			InitializeComponent();
		}

		private void btnGetConnStr_Click(object sender, EventArgs e)
		{
			sqlDb.ApplicationName = "connTest";
			sqlDb.Pooling = checkBoxPooling.Checked;
			string connStr = sqlDb.GetConnentionString("default");

			labelConnStr.Text = connStr;
		}

		private void btnGetConnection_Click(object sender, EventArgs e)
		{

			sqlDb.Pooling = checkBoxPooling.Checked;

			SqlConnection conn = sqlDb.GetConnection("default");
			conn.Open();

			//寫SQL語法
			string sql = "SELECT Id FROM News";
			SqlCommand command = new SqlCommand(sql, conn);

			SqlDataReader reader = command.ExecuteReader();
			reader.Close();

			conn.Close(); //記得一定要關閉
		}

		private void btnUsing_Click(object sender, EventArgs e)
		{
			sqlDb.Pooling = checkBoxPooling.Checked;

			using (SqlConnection conn = sqlDb.GetConnection("default"))
			{
				conn.Open();

				string sql = "SELECT Id FROM News";
				using (SqlCommand command = new SqlCommand(sql, conn))
				{
					SqlDataReader reader = command.ExecuteReader();
					reader.Close();

					//conn.Close(); //記得一定要關閉
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textBox1.Text, out int categoryId);
			if(!isInt)
			{
				MessageBox.Show("請輸入category id, 再試一次");
				return;
			}

			var frm = new FormEditCategory(categoryId);
			frm.ShowDialog();
		}

		private void btnSearchProducts_Click(object sender, EventArgs e)
		{
			var frm = new FormProducts();
			frm.ShowDialog();
		}

		private void btnAddNews_Click(object sender, EventArgs e)
		{
			var frm = new FormAddNews();
			frm.ShowDialog();
		}

		private void btnEditNews_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入news id, 再試一次");
				return;
			}

			var frm = new FormEditNews(newsId);
			frm.ShowDialog();
		}


		private void btnDeleteNews_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtNewsId.Text, out int newsId);
			if (!isInt)
			{
				MessageBox.Show("請輸入news id, 再試一次");
				return;
			}

			int rowsAffected = new NewsRepository().Delete(newsId);

			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected == 1)
			{
				MessageBox.Show("記錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有記錄被刪除，可能此記錄不存在");
			}
		}

		private void btnSearchCategories_Click(object sender, EventArgs e)
		{
			var frm = new FormCategories();
			frm.ShowDialog();
		}

		private void btnAddCategories_Click(object sender, EventArgs e)
		{
			var frm = new FormAddCategories();
			frm.ShowDialog();
		}

		private void btnEditCategories_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtCategoryId.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入category id, 再試一次");
				return;
			}

			var frm = new FormEditCategory2(categoryId);
			frm.ShowDialog();
		}

		private void btnDeleteCategory_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtCategoryId.Text, out int categoryId);
			if (!isInt)
			{
				MessageBox.Show("請輸入category id, 再試一次");
				return;
			}

			int rowsAffected = new CategoryRepository().Delete(categoryId);

			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected == 1)
			{
				MessageBox.Show("記錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有記錄被刪除，可能此記錄不存在");
			}
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			var frm = new FormAddProducts();
			frm.ShowDialog();
		}

		private void btnEditProduct_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtProductId.Text, out int productId);
			if (!isInt)
			{
				MessageBox.Show("請輸入productId id, 再試一次");
				return;
			}

			var frm = new FormEditProduct(productId);
			frm.ShowDialog();
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(txtProductId.Text, out int productId);
			if (!isInt)
			{
				MessageBox.Show("請輸入productId id, 再試一次");
				return;
			}

			int rowsAffected = new ProductRepository().Delete(productId);

			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected == 1)
			{
				MessageBox.Show("記錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有記錄被刪除，可能此記錄不存在");
			}
		}
	}
}
