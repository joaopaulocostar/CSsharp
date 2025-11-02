using System;

namespace ex02;

class Ex02
{
    public static void Main()
    {
        Console.WriteLine("Informe um número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe outro número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int soma = n1 + n2;
        Console.WriteLine($"A soma entre {n1} e {n2} é igual á = {soma}");

    }
}