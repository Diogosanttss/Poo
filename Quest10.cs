using System;


class Program

{

    static void Main()

    {

        Console.Write("Digite o valor em reais: ");

        double reais = double.Parse(Console.ReadLine());


        Console.Write("Digite a taxa de câmbio (valor de 1 dólar em reais): ");

        double taxaCambio = double.Parse(Console.ReadLine());


        

        double dolares = reais / taxaCambio;


        Console.WriteLine("O valor convertido em dólares é: {0}", dolares.ToString("F2"));

    }

}