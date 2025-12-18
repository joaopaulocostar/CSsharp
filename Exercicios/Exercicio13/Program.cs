using System;

class Exercicio13 
{
    public static void Main()
    {
        Console.WriteLine("Informe a quantidade de Kilômetros rodados: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a quantidade de dias alugados: ");
        double dias = Convert.ToDouble(Console.ReadLine());
        double valor = Aluguel(km, dias);
        Console.WriteLine($"O valor total é de {valor:F2}");
    }

    static double Aluguel(double a, double b)
    {
        double preco = ((b * 60) + (a * 0.15));
        return preco;
    }    
}