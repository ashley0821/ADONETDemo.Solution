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
	public partial class FormEditCategory : Form
	{
		private readonly int _categoryID;
		public FormEditCategory(int categoryId)
		{
			_categoryID = categoryId;
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;

			bool isInt = int.TryParse(txtDisplayOrder.Text, out int displayOrder);

			if (!isInt)
			{
				MessageBox.Show("displayOrder必須輸入整數");
				return;
			}

			CategoryEditVM vm = new CategoryEditVM()
			{
				Id = _categoryID,
				Name = name,
				DisplayOrder = displayOrder,
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
			CategoryEditDto dto = vm.ToDto();

			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			try
			{
				service.Update(dto);
			} 
			catch(Exception ex)
			{
				MessageBox.Show("更新失敗，原因是:" + ex.Message);
				return;
			}

			//新增完成，關閉自己，並通知Owner更新內容
			IGrid owner = this.Owner as IGrid;//若用as轉型失敗會傳回null，不會丟出例外，會比顯式轉型好

			if (owner == null)
			{
				MessageBox.Show("忘記把owner實作IGrid了，請補一下");
			}
			else
			{
				owner.Display();
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}

		private void FormEditCategory_Load(object sender, EventArgs e)
		{
			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			CategoryEditDto dto = service.Get(this._categoryID);

			CategoryEditVM vm = dto.ToViewModel();

			txtName.Text = vm.Name;
			txtDisplayOrder.Text = vm.DisplayOrder.ToString();
		}

		private (bool isValid, List<ValidationResult> errors) Validate(CategoryEditVM vm)
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			ICategoryRepository categoryRepository = new SqlCategoryRepository();
			CategoryService service = new CategoryService(categoryRepository);

			service.Delete(this._categoryID);

			//新增完成，關閉自己，並通知Owner更新內容
			IGrid owner = this.Owner as IGrid;//若用as轉型失敗會傳回null，不會丟出例外，會比顯式轉型好

			if (owner == null)
			{
				MessageBox.Show("忘記把owner實作IGrid了，請補一下");
			}
			else
			{
				owner.Display();
			}

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
	}
}
