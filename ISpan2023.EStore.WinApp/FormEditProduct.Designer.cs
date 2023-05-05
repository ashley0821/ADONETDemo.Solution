namespace ISpan2023.EStore.WinApp
{
	partial class FormEditProduct
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtProductImage = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(206, 304);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(111, 241);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(171, 22);
			this.txtStock.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 244);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 12);
			this.label7.TabIndex = 3;
			this.label7.Text = "Stock:";
			// 
			// txtProductImage
			// 
			this.txtProductImage.Location = new System.Drawing.Point(111, 213);
			this.txtProductImage.Name = "txtProductImage";
			this.txtProductImage.Size = new System.Drawing.Size(171, 22);
			this.txtProductImage.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 12);
			this.label6.TabIndex = 4;
			this.label6.Text = "ProductImage:";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(111, 185);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(171, 22);
			this.txtStatus.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 5;
			this.label5.Text = "Status:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(111, 157);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(171, 22);
			this.txtPrice.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "Price:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(111, 129);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(171, 22);
			this.txtDescription.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "Description:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(111, 45);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(171, 78);
			this.txtName.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "Name:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(111, 17);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(171, 22);
			this.txtCategoryId.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "CategaryId:";
			// 
			// FormEditProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 450);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtProductImage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label1);
			this.Name = "FormEditProduct";
			this.Text = "FormEditProduct";
			this.Load += new System.EventHandler(this.FormEditProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtProductImage;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label1;
	}
}