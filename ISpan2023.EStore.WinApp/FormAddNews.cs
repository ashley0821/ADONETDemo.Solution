﻿using ISpan2023.EStore.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ISpan2023.EStore.WinApp
{
	public partial class FormAddNews : Form
	{
		public FormAddNews()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var news = new NewsDto
			{
				Title = txtDescription.Text,
				Description = txtDescription.Text,
			};

			int id = new NewsRepository().Create(news);
			MessageBox.Show($"記錄已新增，id={id}");
		}
	}
}
