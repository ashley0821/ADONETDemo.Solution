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
	public partial class FormCategories : Form
	{
		public FormCategories()
		{
			InitializeComponent();
		}

		private void FormCategories_Load(object sender, EventArgs e)
		{
			var repo = new CategoryRepository();
			var products = repo.Search();

			this.dataGridView1.DataSource = products;
		}
	}
}
