using System;
class Exercicio9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da altura da parede em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a largura da parede em metros: ");
        double largura = Convert.ToDouble(Console.ReadLine());
        double area = AreaParede(altura, largura);
        double tinta = TintaParede(area);
        Console.WriteLine($"A área da parede é de {area:F2} metros quadrados!");
        Console.WriteLine($"Sua parede exige {tinta:F2} litros de tinta!");
    }

    public static double AreaParede(double a, double b)
    {
        return a * b;
    }

    public static double TintaParede(double a)
    {
        return a / 2;
    }
}
