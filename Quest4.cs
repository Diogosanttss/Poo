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
				Console.WriteLine("O n�mero � positivo.");
			}else{
				if (num == 0)
				{
					Console.WriteLine("O n�mero � igual a 0.");
				}else 
				{
					Console.WriteLine("O n�mero � negativo");
				}
			}
		}
	}
}