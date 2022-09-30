using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando for");

        for (int lin = 0; lin < 10; lin++)
        {
            for (int col = 0; col < lin; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("");
        
        for (int lin = 0; lin < 10; lin++)
        {
            for (int col = 0; col < lin; col++)
            {
                Console.Write("*");
                if (col >= lin)
                    break;
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}