namespace ISpan2023.EStore.WinApp
{
	partial class FormEditNews
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblModifiedTime = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Description:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "Title:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(110, 67);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(178, 148);
			this.txtDescription.TabIndex = 3;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(110, 27);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(178, 22);
			this.txtTitle.TabIndex = 4;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(213, 259);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "Modified Time:";
			// 
			// lblModifiedTime
			// 
			this.lblModifiedTime.AutoSize = true;
			this.lblModifiedTime.Location = new System.Drawing.Point(108, 228);
			this.lblModifiedTime.Name = "lblModifiedTime";
			this.lblModifiedTime.Size = new System.Drawing.Size(84, 12);
			this.lblModifiedTime.TabIndex = 9;
			this.lblModifiedTime.Text = "lblModifiedTime";
			// 
			// FormEditNews
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblModifiedTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTitle);
			this.Name = "FormEditNews";
			this.Text = "FormEditNews";
			this.Load += new System.EventHandler(this.FormEditNews_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblModifiedTime;
	}
}