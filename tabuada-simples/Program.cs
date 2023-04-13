using System;
namespace tabuada_simples
{
class Program
{
    static void Main(string[] args)
    {
        double numero;

        Console.WriteLine("Digite Um Número da Tabuada: ");

        numero = double.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            double total = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + total);
        }
        Console.WriteLine("Criano uma tabuada simples no c#!");

    }
}
}
