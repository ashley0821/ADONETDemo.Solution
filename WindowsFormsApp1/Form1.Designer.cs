namespace WindowsFormsApp1
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
			this.button1 = new System.Windows.Forms.Button();
			this.waTextBox2 = new WindowsFormsApp1.WATextBox();
			this.waTextBox1 = new WindowsFormsApp1.WATextBox();
			this.waCheckBox1 = new WindowsFormsApp1.WACheckBox();
			this.ucGender1 = new WindowsFormsApp1.ucGender();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// waTextBox2
			// 
			this.waTextBox2.Location = new System.Drawing.Point(28, 51);
			this.waTextBox2.Name = "waTextBox2";
			this.waTextBox2.Size = new System.Drawing.Size(100, 22);
			this.waTextBox2.TabIndex = 2;
			// 
			// waTextBox1
			// 
			this.waTextBox1.Location = new System.Drawing.Point(28, 23);
			this.waTextBox1.Name = "waTextBox1";
			this.waTextBox1.Size = new System.Drawing.Size(100, 22);
			this.waTextBox1.TabIndex = 1;
			// 
			// waCheckBox1
			// 
			this.waCheckBox1.AutoSize = true;
			this.waCheckBox1.Location = new System.Drawing.Point(28, 79);
			this.waCheckBox1.Name = "waCheckBox1";
			this.waCheckBox1.Size = new System.Drawing.Size(93, 16);
			this.waCheckBox1.TabIndex = 0;
			this.waCheckBox1.Text = "waCheckBox1";
			this.waCheckBox1.UseVisualStyleBackColor = true;
			// 
			// ucGender1
			// 
			this.ucGender1.Location = new System.Drawing.Point(28, 101);
			this.ucGender1.Name = "ucGender1";
			this.ucGender1.Size = new System.Drawing.Size(89, 71);
			this.ucGender1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ucGender1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.waTextBox2);
			this.Controls.Add(this.waTextBox1);
			this.Controls.Add(this.waCheckBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private WACheckBox waCheckBox1;
		private WATextBox waTextBox1;
		private WATextBox waTextBox2;
		private System.Windows.Forms.Button button1;
		private ucGender ucGender1;
	}
}

