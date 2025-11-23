using System;
public class Exercicio11
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Informe o valor do seu sálario: R$");
        double salario = Convert.ToDouble(Console.ReadLine());
        double aumento = Aumento(salario);
        Console.WriteLine($"Seu sálario de R${salario:F2} com 15% de aumento irá para R${aumento + salario:F2}");

    }

    public static double Aumento(double a)
    {
        return 0.15 * a;
    }
}