using System;

class Exercicio5
{
    public static void Main()
    {
        Console.WriteLine("Informe a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double media = (nota1 + nota2) / 2;
        if (media >= 7)
        {
            Console.WriteLine($"Sua média é {media}, você está APROVADO(A)!!");
        } else if (media >= 5)
        {
            Console.WriteLine($"Sua média é {media}, você está de RECUPERAÇÃO!!");
        } else
        {
            Console.WriteLine($"Sua média é {media}, você está REPROVADO(A)!!");
        }
    }
}