namespace ISpan2023.EStore.WinApp
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetConnStr = new System.Windows.Forms.Button();
			this.labelConnStr = new System.Windows.Forms.Label();
			this.btnGetConnection = new System.Windows.Forms.Button();
			this.checkBoxPooling = new System.Windows.Forms.CheckBox();
			this.btnUsing = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearchProducts = new System.Windows.Forms.Button();
			this.btnAddNews = new System.Windows.Forms.Button();
			this.btnEditNews = new System.Windows.Forms.Button();
			this.txtNewsId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDeleteNews = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearchCategories = new System.Windows.Forms.Button();
			this.btnAddCategories = new System.Windows.Forms.Button();
			this.btnEditCategories = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnEditProduct = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetConnStr
			// 
			this.btnGetConnStr.Location = new System.Drawing.Point(12, 12);
			this.btnGetConnStr.Name = "btnGetConnStr";
			this.btnGetConnStr.Size = new System.Drawing.Size(89, 23);
			this.btnGetConnStr.TabIndex = 0;
			this.btnGetConnStr.Text = "取得連線字串";
			this.btnGetConnStr.UseVisualStyleBackColor = true;
			this.btnGetConnStr.Click += new System.EventHandler(this.btnGetConnStr_Click);
			// 
			// labelConnStr
			// 
			this.labelConnStr.AutoSize = true;
			this.labelConnStr.Location = new System.Drawing.Point(12, 41);
			this.labelConnStr.Name = "labelConnStr";
			this.labelConnStr.Size = new System.Drawing.Size(66, 12);
			this.labelConnStr.TabIndex = 1;
			this.labelConnStr.Text = "labelConnStr";
			// 
			// btnGetConnection
			// 
			this.btnGetConnection.Location = new System.Drawing.Point(14, 62);
			this.btnGetConnection.Name = "btnGetConnection";
			this.btnGetConnection.Size = new System.Drawing.Size(75, 23);
			this.btnGetConnection.TabIndex = 2;
			this.btnGetConnection.Text = "連線到Db";
			this.btnGetConnection.UseVisualStyleBackColor = true;
			this.btnGetConnection.Click += new System.EventHandler(this.btnGetConnection_Click);
			// 
			// checkBoxPooling
			// 
			this.checkBoxPooling.AutoSize = true;
			this.checkBoxPooling.Location = new System.Drawing.Point(100, 66);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(60, 16);
			this.checkBoxPooling.TabIndex = 3;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// btnUsing
			// 
			this.btnUsing.Location = new System.Drawing.Point(14, 94);
			this.btnUsing.Name = "btnUsing";
			this.btnUsing.Size = new System.Drawing.Size(75, 23);
			this.btnUsing.TabIndex = 4;
			this.btnUsing.Text = "Using";
			this.btnUsing.UseVisualStyleBackColor = true;
			this.btnUsing.Click += new System.EventHandler(this.btnUsing_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "選取一筆category";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(154, 138);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "Id:";
			// 
			// btnSearchProducts
			// 
			this.btnSearchProducts.Location = new System.Drawing.Point(13, 22);
			this.btnSearchProducts.Name = "btnSearchProducts";
			this.btnSearchProducts.Size = new System.Drawing.Size(91, 23);
			this.btnSearchProducts.TabIndex = 8;
			this.btnSearchProducts.Text = "取得所有商品";
			this.btnSearchProducts.UseVisualStyleBackColor = true;
			this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
			// 
			// btnAddNews
			// 
			this.btnAddNews.Location = new System.Drawing.Point(16, 21);
			this.btnAddNews.Name = "btnAddNews";
			this.btnAddNews.Size = new System.Drawing.Size(75, 23);
			this.btnAddNews.TabIndex = 9;
			this.btnAddNews.Text = "新增 News";
			this.btnAddNews.UseVisualStyleBackColor = true;
			this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
			// 
			// btnEditNews
			// 
			this.btnEditNews.Location = new System.Drawing.Point(16, 51);
			this.btnEditNews.Name = "btnEditNews";
			this.btnEditNews.Size = new System.Drawing.Size(75, 23);
			this.btnEditNews.TabIndex = 10;
			this.btnEditNews.Text = "Edit News";
			this.btnEditNews.UseVisualStyleBackColor = true;
			this.btnEditNews.Click += new System.EventHandler(this.btnEditNews_Click);
			// 
			// txtNewsId
			// 
			this.txtNewsId.Location = new System.Drawing.Point(154, 51);
			this.txtNewsId.Name = "txtNewsId";
			this.txtNewsId.Size = new System.Drawing.Size(100, 22);
			this.txtNewsId.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "NewsId:";
			// 
			// btnDeleteNews
			// 
			this.btnDeleteNews.Location = new System.Drawing.Point(16, 80);
			this.btnDeleteNews.Name = "btnDeleteNews";
			this.btnDeleteNews.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteNews.TabIndex = 13;
			this.btnDeleteNews.Text = "Delete News";
			this.btnDeleteNews.UseVisualStyleBackColor = true;
			this.btnDeleteNews.Click += new System.EventHandler(this.btnDeleteNews_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNewsId);
			this.groupBox1.Controls.Add(this.btnAddNews);
			this.groupBox1.Controls.Add(this.btnDeleteNews);
			this.groupBox1.Controls.Add(this.btnEditNews);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(14, 191);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 115);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "維護News";
			// 
			// btnSearchCategories
			// 
			this.btnSearchCategories.Location = new System.Drawing.Point(10, 18);
			this.btnSearchCategories.Name = "btnSearchCategories";
			this.btnSearchCategories.Size = new System.Drawing.Size(91, 23);
			this.btnSearchCategories.TabIndex = 15;
			this.btnSearchCategories.Text = "取得所有分類";
			this.btnSearchCategories.UseVisualStyleBackColor = true;
			this.btnSearchCategories.Click += new System.EventHandler(this.btnSearchCategories_Click);
			// 
			// btnAddCategories
			// 
			this.btnAddCategories.Location = new System.Drawing.Point(10, 50);
			this.btnAddCategories.Name = "btnAddCategories";
			this.btnAddCategories.Size = new System.Drawing.Size(91, 23);
			this.btnAddCategories.TabIndex = 16;
			this.btnAddCategories.Text = "新增分類";
			this.btnAddCategories.UseVisualStyleBackColor = true;
			this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
			// 
			// btnEditCategories
			// 
			this.btnEditCategories.Location = new System.Drawing.Point(10, 82);
			this.btnEditCategories.Name = "btnEditCategories";
			this.btnEditCategories.Size = new System.Drawing.Size(91, 23);
			this.btnEditCategories.TabIndex = 17;
			this.btnEditCategories.Text = "編輯分類";
			this.btnEditCategories.UseVisualStyleBackColor = true;
			this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 12);
			this.label3.TabIndex = 18;
			this.label3.Text = "CategoryId:";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(171, 82);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(100, 22);
			this.txtCategoryId.TabIndex = 19;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDeleteCategory);
			this.groupBox2.Controls.Add(this.txtCategoryId);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnEditCategories);
			this.groupBox2.Controls.Add(this.btnAddCategories);
			this.groupBox2.Controls.Add(this.btnSearchCategories);
			this.groupBox2.Location = new System.Drawing.Point(14, 322);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(286, 144);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "維護Categories";
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.Location = new System.Drawing.Point(10, 114);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(91, 23);
			this.btnDeleteCategory.TabIndex = 20;
			this.btnDeleteCategory.Text = "刪除分類";
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(13, 52);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(91, 23);
			this.btnAddProduct.TabIndex = 21;
			this.btnAddProduct.Text = "新增商品";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnEditProduct
			// 
			this.btnEditProduct.Location = new System.Drawing.Point(13, 82);
			this.btnEditProduct.Name = "btnEditProduct";
			this.btnEditProduct.Size = new System.Drawing.Size(91, 23);
			this.btnEditProduct.TabIndex = 22;
			this.btnEditProduct.Text = "編輯商品";
			this.btnEditProduct.UseVisualStyleBackColor = true;
			this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 12);
			this.label4.TabIndex = 23;
			this.label4.Text = "商品Id:";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(159, 82);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(100, 22);
			this.txtProductId.TabIndex = 24;
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Location = new System.Drawing.Point(13, 112);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(91, 23);
			this.btnDeleteProduct.TabIndex = 25;
			this.btnDeleteProduct.Text = "刪除商品";
			this.btnDeleteProduct.UseVisualStyleBackColor = true;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtProductId);
			this.groupBox3.Controls.Add(this.btnDeleteProduct);
			this.groupBox3.Controls.Add(this.btnSearchProducts);
			this.groupBox3.Controls.Add(this.btnAddProduct);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.btnEditProduct);
			this.groupBox3.Location = new System.Drawing.Point(369, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(276, 148);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "維護商品";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnUsing);
			this.Controls.Add(this.checkBoxPooling);
			this.Controls.Add(this.btnGetConnection);
			this.Controls.Add(this.labelConnStr);
			this.Controls.Add(this.btnGetConnStr);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetConnStr;
		private System.Windows.Forms.Label labelConnStr;
		private System.Windows.Forms.Button btnGetConnection;
		private System.Windows.Forms.CheckBox checkBoxPooling;
		private System.Windows.Forms.Button btnUsing;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearchProducts;
		private System.Windows.Forms.Button btnAddNews;
		private System.Windows.Forms.Button btnEditNews;
		private System.Windows.Forms.TextBox txtNewsId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDeleteNews;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearchCategories;
		private System.Windows.Forms.Button btnAddCategories;
		private System.Windows.Forms.Button btnEditCategories;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnEditProduct;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.Button btnDeleteProduct;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}

