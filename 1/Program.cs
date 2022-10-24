using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入年月日：");
			string input=Console.ReadLine();
			bool isDatetime=DateTime.TryParse(input, out DateTime date);
			if (isDatetime == false)
			{
				Console.WriteLine("請輸入年/月/日");
			}
			else
			{
				Console.WriteLine($"輸入正確，輸入的是{date}");
			}
		}
	}
}
