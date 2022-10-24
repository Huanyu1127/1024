namespace windowsform
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
			this.whobotton = new System.Windows.Forms.Button();
			this.greetButtom = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// whobotton
			// 
			this.whobotton.BackColor = System.Drawing.Color.MistyRose;
			this.whobotton.Location = new System.Drawing.Point(39, 79);
			this.whobotton.Margin = new System.Windows.Forms.Padding(5);
			this.whobotton.Name = "whobotton";
			this.whobotton.Size = new System.Drawing.Size(83, 62);
			this.whobotton.TabIndex = 5;
			this.whobotton.Text = "button1";
			this.whobotton.UseVisualStyleBackColor = false;
			this.whobotton.Click += new System.EventHandler(this.whobotton_Click);
			// 
			// greetButtom
			// 
			this.greetButtom.BackColor = System.Drawing.SystemColors.Control;
			this.greetButtom.Location = new System.Drawing.Point(189, 307);
			this.greetButtom.Margin = new System.Windows.Forms.Padding(5);
			this.greetButtom.Name = "greetButtom";
			this.greetButtom.Size = new System.Drawing.Size(218, 50);
			this.greetButtom.TabIndex = 7;
			this.greetButtom.Text = "Say hi";
			this.greetButtom.UseVisualStyleBackColor = false;
			this.greetButtom.Click += new System.EventHandler(this.greetButtom_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.MistyRose;
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 11F);
			this.button2.Location = new System.Drawing.Point(461, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 62);
			this.button2.TabIndex = 6;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.greetButtom_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 164);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(372, 65);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(160, 44);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(90, 25);
			this.textBox2.TabIndex = 0;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(342, 44);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(90, 25);
			this.textBox3.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(182, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(363, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cornsilk;
			this.ClientSize = new System.Drawing.Size(780, 490);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.greetButtom);
			this.Controls.Add(this.whobotton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(796, 529);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(598, 462);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button whobotton;
		private System.Windows.Forms.Button greetButtom;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

