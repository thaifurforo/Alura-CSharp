using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investimento a longo prazo");

        decimal fatorRendimento = 1.005m;
        decimal investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001m;
        }
        
        // variável mes só existe dentro do contexto do loop for, se tentar usar ela fora vai dar erro
        
        Console.WriteLine("Valor final do investimento: " + investimento);
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}