using ISpan.MultiLayers.WinApp.ViewModels;
using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.infra.SqlRepositories;
using ISpan2023.EStore.SqlDataLayer.interfaces;
using ISpan2023.EStore.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.MultiLayers.WinApp
{
	public partial class FormAddCategory : Form
	{
		public FormAddCategory()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;

			bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);

			//if (!isInt)
			//{
			//	MessageBox.Show("displayOrder必須輸入整數");
			//	return;
			//}

			CategoryAddVM vm = new CategoryAddVM()
			{
				Name = name,
				DisplayOrder = displayOrder
			};

			//針對view model進行驗證欄位，如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			//把vm轉成dto
			CategoryAddDto dto = vm.ToDto();

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			service.Create(dto);

			//新增完成，關閉自己，並通知Owner更新內容
			//泛化 : 把要處理的表單轉成介面
			IGrid owner = (IGrid)this.Owner;//= this.Owner as IGrid 比較溫和 沒有轉型成功會變成null
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}

		private (bool isValid, List<ValidationResult> errors) Validate(CategoryAddVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", txtName},
				{"DisplayOrder", txtDisplayOrder}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
	}
}
