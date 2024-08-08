using System;

namespace Poo
{
	class Quest1
	{
		static void Main(string []args)
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());
			Console.WriteLine(Soma(x,y));
			Console.WriteLine(multiplicacao(x,y));
			Console.WriteLine(subtracao(x,y));
			Console.WriteLine(divisao(x,y));
		}

		static int Soma(int x, int y)
		{
			return x + y;
		}
		static int multiplicacao(int x, int y)
		{
			return x*y;
		}

		static int subtracao(int x, int y)
		{
			return x-y;
		}

		static int divisao(int x, int y)
		{
			return x/y;
		}
	}
}