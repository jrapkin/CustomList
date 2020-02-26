using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomList<int> testList = new CustomList<int>();
			testList.Add(4);
			testList.Add(543);
			Console.WriteLine(testList[1].ToString());

		}
	}
}
