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
			this.SayHibtn = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.greetingLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SayHibtn
			// 
			this.SayHibtn.Location = new System.Drawing.Point(137, 222);
			this.SayHibtn.Name = "SayHibtn";
			this.SayHibtn.Size = new System.Drawing.Size(75, 23);
			this.SayHibtn.TabIndex = 2;
			this.SayHibtn.Text = "按我一下";
			this.SayHibtn.UseVisualStyleBackColor = true;
			this.SayHibtn.Click += new System.EventHandler(this.SayHibtn_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(137, 125);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 22);
			this.nameTextBox.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(102, 128);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(29, 12);
			this.lblName.TabIndex = 4;
			this.lblName.Text = "姓名";
			// 
			// greetingLabel
			// 
			this.greetingLabel.AutoSize = true;
			this.greetingLabel.Location = new System.Drawing.Point(102, 180);
			this.greetingLabel.Name = "greetingLabel";
			this.greetingLabel.Size = new System.Drawing.Size(69, 12);
			this.greetingLabel.TabIndex = 5;
			this.greetingLabel.Text = "greetingLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 383);
			this.Controls.Add(this.greetingLabel);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.SayHibtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button SayHibtn;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label greetingLabel;
	}
}

