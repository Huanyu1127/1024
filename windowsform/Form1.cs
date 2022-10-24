using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void greetButtom_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello World!");
		}

		private void whobotton_Click(object sender, EventArgs e)
		{
			DialogResult result =MessageBox.Show("是不是要戳右臉頰一下","左臉頰",MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				MessageBox.Show("您戳了右臉頰一下");
			}
			else
			{
				MessageBox.Show("我才不想戳右臉頰");
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
