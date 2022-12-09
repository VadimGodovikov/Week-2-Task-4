using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4._1
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
				else Console.WriteLine("Введите корректное значение: ");
			} while (true);
		}

		private static double rec(int i, int N)
		{
			if (i == N) return Math.Sqrt(N);
			else return Math.Sqrt(i + rec(i + 1, N));
		}

		static void Main(string[] args)
		{

			n1: Console.WriteLine("Введите N: ");
			int N = readInt();
			
			if(N <= 0)
			{
				Console.WriteLine("Данное значение N не может быть меньше единицы");
				goto n1;
			}

			Console.WriteLine($"Результат вычисления данной функции: {N/rec(1, N):f4}");

		}
	}
}
