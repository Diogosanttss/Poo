using System;


class Program
{

    static void Main(string[] args)
    {

        int soma = 1;
        int numero;

        Console.Write("Digite um número (ou 0 para terminar):\n");

        numero = 1;

        while (numero != 0){
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.WriteLine("A soma de todos os números digitados é: {0}",soma);

    }

}