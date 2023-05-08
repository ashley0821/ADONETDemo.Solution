using ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using ISpan2023.EStore.SqlDataLayer.Services;
using System;
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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			IUserRepository userRepository = new SqlUserRepository();
			UserService service = new UserService(userRepository);

			try
			{
				bool validationResult = service.IsValid(txtAccount.Text, txtPassword.Text);
				if (validationResult == false)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}

				//清空表單值，以便下次顯示十，不會有值
				txtAccount.Text =string.Empty;
				txtPassword.Text = string.Empty;

				var frm = new FormMain();
				frm.Owner = this;

				//不能將FormLogin關閉，只能隱藏
			    //不然現在的app就會視同結束
				this.Hide();

				//稍後FormMain關閉時，再將FormLogin顯示
				frm.ShowDialog();

			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
	}
}
