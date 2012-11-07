using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
	class _4
	{
		/// <summary>
		/// http://projecteuler.net/problem=4
		/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 x 99.
		/// Find the largest palindrome made from the product of two 3-digit numbers.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine("Project Euler\n\nProblem 4");
			_4 main = new _4();
			// Console.WriteLine("101 is " + (main.isPalindrome(101) ? "" : "not ") + "a palindrome.");		//Test
			int digit = 3;
			int result = main.loop(main, digit);
			if (result == 0)
				Environment.Exit(-1);		// Should not reach here.

			Console.WriteLine("The largest palindrome made of two " + digit + " digit numbers is " + result);

			Console.ReadKey();
		}

		public Boolean isPalindrome(int number)
		{
			int orig = number;
			int reverse = 0;
			int digit;

			while (number > 0)
			{
				digit = number % 10;
				reverse = reverse * 10 + digit;
				number = number /= 10;
			}

			if (reverse == orig)
				return true;
			else
				return false;
		}

		public int loop(_4 main, int digits)
		{
			double start = 0;
			for (int i = digits-1; i >= 0; i--)
			{
				start += Math.Pow(10, i) * 9;
			}

			int value1, value2;
			for (value1 = (int)start; value1 > 900; value1--)
			{
				for (value2 = (int)start; value2 > 900; value2--)
				{
					if (main.isPalindrome(value1 * value2))
					{
						return value1 * value2;
					}
				}
			}
			return 0;
		}
	}
}
