using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//string v1 = this.waTextBox1.GetValue();
			//string v2 = this.waTextBox2.GetValue();
			//string v3 = this.waCheckBox1.GetValue();

			foreach (var ctrl in this.Controls.OfType<ISmartControl>())
			{
				string v = ctrl.GetValue();
			}
		}
	}
}
