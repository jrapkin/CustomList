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
/*			CustomList<int> testList = new CustomList<int>();
			testList.Add(5);
			testList.Add(7);
			testList.Add(7);
			testList.Add(7);
			testList.Add(7);
			testList.Add(7);*/
			List<int> vs = new List<int>();
			for (int i = 0; i < 8; i++)
			{
				vs.Add(i + 1);
			}

			vs.Remove(1);
		}
	}
}
