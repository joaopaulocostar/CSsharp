using System;
class Exercicio15
{
    public static void Main()
    {
        List<string> alunos = new List<string>();
        string entrada;
        Console.WriteLine("Escreva o nome do Aluno:(Escreva FIM para encerrar.) -> ");
        while (true)
        {
            entrada = Console.ReadLine();
            if(entrada.ToUpper() == "FIM") break;
            else if (entrada == null) break;
            else alunos.Add(entrada);
        }

        string escolhido = Sorteio(alunos);
        if (escolhido != null) Console.WriteLine($"O aluno sorteado foi {escolhido}");
        else Console.WriteLine("Nenhum nome inserido para sorteio");
    }

    static string Sorteio(List<string> Lista)
    {
        if (Lista.Count == 0) return null;
        Random sorteio = new Random();
        string escolhido = Lista[sorteio.Next(Lista.Count)];
        return escolhido;
    }
    
        
    
}