using System;
class Exercicio8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor em real R$: ");
        double usuario = Convert.ToDouble(Console.ReadLine());
        double usuarioConvertido = ConversorDolar(usuario);
        Console.WriteLine($"O valor de R${usuario:F2} em dolar é igual á U${usuarioConvertido:F2}");
    }

    public static double ConversorDolar(double a)
    {
        return  a / 5.40;
    }
}