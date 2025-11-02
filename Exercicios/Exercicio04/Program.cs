using System;

class Exercicio4
{
    public static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int dobro = number * 2;
        int triplo = number * 3;
        double raiz = Math.Pow(number, 0.5);
        Console.WriteLine($"O dobro de {number} é {dobro}");
        Console.WriteLine($"O triplo de {number} é {triplo}");
        Console.WriteLine($"A raiz de {number} é {raiz}");

    }
}
