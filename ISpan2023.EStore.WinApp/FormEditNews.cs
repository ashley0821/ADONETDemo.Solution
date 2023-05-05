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

namespace ISpan2023.EStore.WinApp
{
	public partial class FormEditNews : Form
	{
		private int _newsId;
		public FormEditNews(int newsId)
		{
			InitializeComponent();
			this._newsId = newsId;
		}

		private void FormEditNews_Load(object sender, EventArgs e)
		{
			var news = new NewsRepository().Get(this._newsId);
			if (news == null)
			{
				MessageBox.Show("Record not found");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			txtTitle.Text = news.Title;
			txtDescription.Text = news.Description;
			lblModifiedTime.Text = news.ModifiedTime.ToString("yyyy/MM/dd");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var news = new NewsEditDto 
			{
				Id = this._newsId,
				Title = txtTitle.Text,
				Description = txtDescription.Text,
				ModifiedTime = DateTime.Now
			};

			int rowsAffected = new NewsRepository().Update(news);
			
			// todo如果傳回筆數是1，表示有正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("記錄已更新");
			}
			else
			{
				MessageBox.Show("記錄沒有被異動，可能記錄已經被刪除");
			}

			FormEditNews_Load(this, EventArgs.Empty);
		}
	}
}
