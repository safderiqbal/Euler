using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
	class _1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Project Euler\n\nProblem 1");
			int total = 0;
			for (int i = 1; i < 1000; i++)
				if (i % 3 == 0 || i % 5 == 0)
				{
					total += i;
				}
			Console.WriteLine("Sum of all multiples = " + total);
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
