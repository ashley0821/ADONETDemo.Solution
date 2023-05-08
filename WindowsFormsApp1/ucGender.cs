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
	public partial class ucGender : UserControl , ISmartControl
	{
		public ucGender()
		{
			InitializeComponent();
		}

		public string GetValue()
		{
			if (radioButton1.Checked)
			{
				return "1";
			}
			else if (radioButton2.Checked)
			{
				return "0";
			}
			else
			{
				return string.Empty;
			}
		}
	}
}
