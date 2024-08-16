using System;


class Program

{

    static void Main()

    {

        Console.Write("Digite um n�mero inteiro para calcular o fatorial: ");

        int numero = int.Parse(Console.ReadLine());

        int fatorial = CalcularFatorial(numero);

        if (numero < 0)
        {
            Console.WriteLine("O fatorial n�o est� definido para n�meros negativos.");
        }else
        {
            Console.WriteLine("O fatorial de {0} �: {1}",numero,fatorial);
        }

    }

    static int CalcularFatorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }else if (n < 0)
        {
            throw new ArgumentException("O fatorial n�o est� definido para n�meros negativos.");
        }else
        {
            return n * CalcularFatorial(n - 1);
        }

    }

}

