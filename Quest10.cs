using System;


class Program

{

    static void Main()

    {

        Console.Write("Digite o valor em reais: ");

        double reais = double.Parse(Console.ReadLine());


        Console.Write("Digite a taxa de c�mbio (valor de 1 d�lar em reais): ");

        double taxaCambio = double.Parse(Console.ReadLine());


        

        double dolares = reais / taxaCambio;


        Console.WriteLine("O valor convertido em d�lares �: {0}", dolares.ToString("F2"));

    }

}