using System;

namespace Poo
{
	class Quest4
	{
		static void Main(string[]args)
		{
			int idade = int.Parse(Console.ReadLine());
			
			if(idade >= 18){
				Console.WriteLine("Voc� � de maior e est� apto para votar e dirigir");
			}else {
				if(idade >= 16)
				{
					Console.WriteLine("Voc� � de menor e est� apto a votar");
				}else {
					Console.WriteLine("Voc� � menor de idade e n�o est� apto para votar nem dirigir");
				}
			}
		}
	}
}