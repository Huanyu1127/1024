namespace threebtn
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
			this.guessbutton1 = new System.Windows.Forms.Button();
			this.guessbotton2 = new System.Windows.Forms.Button();
			this.guseebotton3 = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.playAgainbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// guessbutton1
			// 
			this.guessbutton1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guessbutton1.Location = new System.Drawing.Point(86, 90);
			this.guessbutton1.Name = "guessbutton1";
			this.guessbutton1.Size = new System.Drawing.Size(119, 93);
			this.guessbutton1.TabIndex = 0;
			this.guessbutton1.Tag = "1";
			this.guessbutton1.Text = "1";
			this.guessbutton1.UseVisualStyleBackColor = true;
			this.guessbutton1.Click += new System.EventHandler(this.guessbutton_Click);
			// 
			// guessbotton2
			// 
			this.guessbotton2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guessbotton2.Location = new System.Drawing.Point(295, 89);
			this.guessbotton2.Name = "guessbotton2";
			this.guessbotton2.Size = new System.Drawing.Size(119, 93);
			this.guessbotton2.TabIndex = 1;
			this.guessbotton2.Tag = "2";
			this.guessbotton2.Text = "2";
			this.guessbotton2.UseVisualStyleBackColor = true;
			this.guessbotton2.Click += new System.EventHandler(this.guessbutton_Click);
			// 
			// guseebotton3
			// 
			this.guseebotton3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.guseebotton3.Location = new System.Drawing.Point(504, 89);
			this.guseebotton3.Name = "guseebotton3";
			this.guseebotton3.Size = new System.Drawing.Size(119, 93);
			this.guseebotton3.TabIndex = 2;
			this.guseebotton3.Tag = "3";
			this.guseebotton3.Text = "3";
			this.guseebotton3.UseVisualStyleBackColor = true;
			this.guseebotton3.Click += new System.EventHandler(this.guessbutton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(560, 283);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(63, 12);
			this.answerLabel.TabIndex = 3;
			this.answerLabel.Text = "answerLabel";
			// 
			// playAgainbtn
			// 
			this.playAgainbtn.Location = new System.Drawing.Point(548, 225);
			this.playAgainbtn.Name = "playAgainbtn";
			this.playAgainbtn.Size = new System.Drawing.Size(75, 23);
			this.playAgainbtn.TabIndex = 4;
			this.playAgainbtn.Text = "再玩一次";
			this.playAgainbtn.UseVisualStyleBackColor = true;
			this.playAgainbtn.Click += new System.EventHandler(this.playAgainbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 325);
			this.Controls.Add(this.playAgainbtn);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.guseebotton3);
			this.Controls.Add(this.guessbotton2);
			this.Controls.Add(this.guessbutton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button guessbutton1;
		private System.Windows.Forms.Button guessbotton2;
		private System.Windows.Forms.Button guseebotton3;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Button playAgainbtn;
	}
}

