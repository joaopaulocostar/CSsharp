using System.Numerics;
using System.Runtime.Serialization;

namespace Aula02;

class Program
{
    public static void Main()
    {
        int n1 = ReadNumber();
        int n2 = ReadNumber();
        string userchoice = Type();
        if (userchoice == "addition")
        {
            int soma = Sum(n1, n2);
            Console.WriteLine($"The value is {soma}");
        } else if (userchoice == "subtraction")
        {
            int dimi = Dim(n1, n2);
            Console.WriteLine($"The value is {dimi}");
        } else if (userchoice == "multiplication")
        {
            int multi = Mult(n1, n2);
            Console.WriteLine($"The value is {multi}");
        } else if (userchoice == "division")
        {
            int divi = Divi(n1, n2);
            Console.WriteLine($"The value is {divi}");
        } else
        {
            Console.WriteLine("Invalid information");
        }         
    }

    public static int ReadNumber()
    {
        Console.WriteLine("Tell me a number: ");
        string user = Console.ReadLine();
        int number;
        if (int.TryParse(user, out number))
        {
            return number;
        } else
        {
            Console.WriteLine("Value invalid");
            return 0;
        }
    }

    public static string Type()
    {
        Console.WriteLine("Tell me your choice about: Addition, subtraction, multiplication or division? ");
        string choice = Console.ReadLine();
        string minu = choice.ToLower().Replace(" ","");
        return minu;

    }

    public static int Sum( int a, int b)
    {
        return a + b;
        
    }

    public static int Dim( int a, int b)
    {
        return a - b;
    }

    public static int Mult(int a, int b)
    {
        return a * b;
        
    }

    public static int Divi(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by 0 is invalid");
            return 0;
        }
        return a / b;
        
    }
}


