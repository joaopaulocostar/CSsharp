using System;

class Exercicio7
{
    public static void Main()
    {
        Console.WriteLine("Informe um número para verificar a sua tabuada: ");
        int usuario = Convert.ToInt32(Console.ReadLine());
        Tabuada(usuario);

    }

    public static void Tabuada(int a)
    {
        for (int i = 0; i <= 10; i++ ){
            int resultado = a * i;
            Console.WriteLine($"{a} X {i} = {resultado}");
        }
    }
}