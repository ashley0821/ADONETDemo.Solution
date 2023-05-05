namespace ISpan.MultiLayers.WinApp
{
	partial class FormEditCategory
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtDisplayOrder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDisplayOrder
			// 
			this.txtDisplayOrder.Location = new System.Drawing.Point(113, 58);
			this.txtDisplayOrder.Name = "txtDisplayOrder";
			this.txtDisplayOrder.Size = new System.Drawing.Size(100, 22);
			this.txtDisplayOrder.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "DisplayOrder:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(113, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(138, 86);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// FormEditCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 144);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtDisplayOrder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "FormEditCategory";
			this.Text = "FormEditCategory";
			this.Load += new System.EventHandler(this.FormEditCategory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDisplayOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdate;
	}
}