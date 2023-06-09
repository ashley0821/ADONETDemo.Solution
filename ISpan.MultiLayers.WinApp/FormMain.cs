﻿using System;
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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonCategories_Click(object sender, EventArgs e)
		{
			var frm = new FormCategories();
			frm.ShowDialog();
		}

		private void 維護商品分類ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormCategories();
			frm.ShowDialog();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
