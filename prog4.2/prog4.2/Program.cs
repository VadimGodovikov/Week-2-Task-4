using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4._2
{
	class Program
	{
		private static int readInt()
		{
			do
			{
				int res;
				bool parsed = int.TryParse(Console.ReadLine(), out res);
				if (parsed) return res;
				else Console.WriteLine("Введите корректное значение");
			} while (true);
		}
		static string decTwo(int n)
		{
			return (n == 0) ? "0" : decTwo2(n);
		}
		static string decTwo2(int n)
		{
			if (n >= 0)
			{
				return (n > 0) ? decTwo2(n / 2) + ((n % 2 == 0) ? "0" : "1") : "";
			}
			else
			{
				return (n < 0) ? decTwo2(n / 2) + ((n % 2 == 0) ? "0" : "1") : "";
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите число, которое хотите перевести в двоичную систему: ");
			int n = readInt();

			Console.WriteLine("Результат перевода: " + (n > 0 ? "" : "-") + decTwo(n));

		}
	}
}
