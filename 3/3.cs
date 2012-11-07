using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
	class _3
	{
		/// <summary>
		/// http://projecteuler.net/problem=3
		/// The prime factors of 13195 are 5, 7, 13 and 29.
		/// What is the largest prime factor of the number 600851475143 ?
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			_3 main = new _3();
			Console.WriteLine("Project Euler\n\nProblem 3");
			int result = main.largestPrimeFactor(600851475143);
			Console.WriteLine("The largest prime factor of 600851475143 is " + result);
			Console.ReadKey();
		}

		public int largestPrimeFactor(long target)
		{
			int i;
			for (i = 2; i <= target; i++)
			{
				if (target % i == 0)
				{
					target /= i;
					i--;
				}
			}
			return i;
		}
	}
}
