using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício laço for");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
                Console.WriteLine(i);
        }
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}