using System;
class Exercicio6
{
    public static void Main()
    {
        double numero = Conversor();
        double centimetros = Centimetros(numero);
        double milimetros = Milimetros(numero);
        Console.WriteLine($"O valor em Centimetros: {centimetros}");
        Console.WriteLine($"O valor em Milímetros: {milimetros}");

    }

    public static double Conversor()
    {
        Console.WriteLine("Escreva o valor em metros: ");
        string usuario = Console.ReadLine();
        double metros;
        if (double.TryParse(usuario, out metros))
        {
            return metros;
        } else
        {
            Console.WriteLine("Valor inválido");
            return 0;
        }
    }

    public static double Centimetros(double a)
    {
        return a * 100;

    }

    public static double Milimetros(double a)
    {
        return a * 1000;
    }
}
