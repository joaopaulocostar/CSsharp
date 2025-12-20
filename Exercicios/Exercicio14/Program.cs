using System;
class Exercicio14{
    public static void Main(){
        Console.WriteLine("====== Hipotenusa ======");
        Console.WriteLine("Informe o valor do Cateto: ");
        double cateto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o valor do Adjacente: ");
        double adjacente = Convert.ToDouble(Console.ReadLine());
        double hipotenusa = Hipotenusa(cateto, adjacente);
        Console.WriteLine($"O valor da hipotenusa é {hipotenusa}");


    }
    static double Hipotenusa(double a, double b){
    return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    }
}
