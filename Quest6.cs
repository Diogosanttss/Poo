using System;

namespace Poo
{
	class Quest4
	{
		static void Main(string[]args)
		{
			int idade = int.Parse(Console.ReadLine());
			
			if(idade >= 18){
				Console.WriteLine("Você é de maior e está apto para votar e dirigir");
			}else {
				if(idade >= 16)
				{
					Console.WriteLine("Você é de menor e está apto a votar");
				}else {
					Console.WriteLine("Você é menor de idade e não está apto para votar nem dirigir");
				}
			}
		}
	}
}