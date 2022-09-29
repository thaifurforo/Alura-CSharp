using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        decimal investimento = 1000;
        // Rendimento de 0,5% a.m

        decimal aliquota = 0.005m;

        int tempo = 12;
        int mes = 0;
        
        while (mes < tempo)
        {
            mes += 1;
            investimento = investimento * (1 + aliquota);
            Console.WriteLine("O valor do investimento no mês " + mes + " é de " + investimento);
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}