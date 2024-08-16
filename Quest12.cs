using System;


class Program

{

    static void Main()

    {

        Console.Write("Digite um n�mero para gerar a sequ�ncia de Fibonacci at� esse n�mero: ");

        int n = int.Parse(Console.ReadLine());


        if (n <= 0)

        {

            Console.WriteLine("Por favor, digite um n�mero inteiro positivo.");

            return;

        }


        int a = 0;

        int b = 1;


        Console.WriteLine("Sequ�ncia de Fibonacci at� " + n + ":");


        Console.WriteLine(a);


        while (b <= n)

        {

            Console.WriteLine(b);

            int proximo = a + b;

            a = b;

            b = proximo;

        }

    }

}