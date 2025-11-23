using System;
public class Exercicio12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe a tempera de graus celsios: C°");
        double celsios = Convert.ToDouble(Console.ReadLine());
        double f = CalculadoraTemperatura(celsios);
        Console.WriteLine($"A temperatura de C°{celsios} é igual a F°{f}");
    }
    public static double CalculadoraTemperatura(double c)
    {
        return ((9 * c) /5) + 32;
    }
}
