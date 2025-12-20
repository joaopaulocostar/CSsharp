using System;
using System.Linq;
class Exercicio16
{
    public static void Main()
    {
        Console.WriteLine("Informe uma frase: ");
        string frase = Console.ReadLine();
        int quantidade = Quantidade(frases);
        Console.WriteLine($"A quantidade de A na frase é igual {quantidade}");
    }

    static int Quantidade(string frases)
    {
        int quantidade = frases.Count(n => n == "A");
        return quantidade;
    }
}