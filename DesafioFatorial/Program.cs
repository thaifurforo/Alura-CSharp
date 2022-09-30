using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio Fatorial");

        int fatorial = 1;
        
        for (int i = 0; i <= 10; i++)
        {
            if (i > 0)
                fatorial *= i;
            Console.WriteLine("O fatorial de " + i + " é " + fatorial);
        }
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}