using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threebtn
{
	public partial class Form1 : Form
	{
		int answer = 0; //在外面先宣告
		public Form1()
		{
			//表單內一開始先取亂數1~3，存放在變數中，並在Label呈現答案，方便查看程式是否正確
			InitializeComponent();
			answer=new Random().Next(1,4); //
			answerLabel.Text = answer.ToString();
		}

		private void guessbutton_Click(object sender, EventArgs e)  //sender觸發控制項後的 按按鈕表示的
		{	//sender是按鈕，將他轉型為button之後，可以取得tag值
			Button btn=(Button)sender;
			int tag = Convert.ToInt32(btn.Tag);

			//MessageBox.Show(tag.ToString());

			//跟答案比對
			if (tag == answer)
			{
				MessageBox.Show("您答對了");
			}
			else
			{
				MessageBox.Show("您答錯了");
			}
		}

		private void playAgainbtn_Click(object sender, EventArgs e)
		{
			answer = new Random().Next(1, 4); 
			answerLabel.Text = answer.ToString();
		}
	}
}
