using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			starLabel.Text=string.Empty;
		}
		private void inputbtn_Click(object sender, EventArgs e)
		{
			//取列數
			int? rows = GetRows(); //若要顯示null要+?
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				return;
			}

			//判斷>0
			if(rows.Value <= 0)
			{
				MessageBox.Show("請輸入正整數");
				return ;
			}
			//做星星
			string result = GenerateStar(rows.Value);

			//放入TextBox
			starText.Text = result;
			starLabel.Text= result;
		}
		private int? GetRows() //若要顯示null要+? 要回傳都要有東西
		{
			bool isInt = int.TryParse(rowText.Text, out int rows);
			if (isInt) { return rows; }
			else { return null; } 
		}
		private string GenerateStar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n"; //+=忘記了
			}
			return result; //記得要return
		}
	}
}
