using System;


namespace Exercicios
{
    internal class Ex03
    {
        public static void Main()
        {
            Console.WriteLine("Informe um número: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O número sucessor de {number} é {number + 1}");
            Console.WriteLine($"O número antecessor de {number} é {number - 1}");

        }
    }
}
