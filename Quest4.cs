using System;

namespace Poo
{
	class Quest4
	{
		static void Main(string[]args)
		{
			int num = int.Parse(Console.ReadLine());

			if (num > 0)
			{
				Console.WriteLine("O número é positivo.");
			}else{
				if (num == 0)
				{
					Console.WriteLine("O número é igual a 0.");
				}else 
				{
					Console.WriteLine("O número é negativo");
				}
			}
		}
	}
}