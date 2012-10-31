using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
	class _1
	{
		/// <summary>
		/// http://projecteuler.net/problem=1
		/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
		/// Find the sum of all the multiples of 3 or 5 below 1000.
		/// </summary>
		/// <param name="args"></param>
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
