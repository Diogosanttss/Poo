using System;

namespace Poo
{
	class Quest3
	{
		static void Main(string []args)
		{
			string nome = Console.ReadLine();
			int idade = int.Parse(Console.ReadLine());
			Console.WriteLine("Olá {0}, você tem {1} anos",nome,idade);
		}
	}
}