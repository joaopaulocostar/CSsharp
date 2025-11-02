using System;
public class Exercicio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor do produto! R$");
        double valor = Convert.ToDouble(Console.ReadLine());
        double desconto = Desconto(valor);
        Console.WriteLine($"O produto de R${valor:F2} com 5% de desconto, ficará R${desconto:F2}");
    }

    static double Desconto(double d)
    {
        double desconto =  d * 0.05;
        return d - desconto;
    }
}
