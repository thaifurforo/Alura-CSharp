using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;

        idade = 10;
        Console.WriteLine("Minha idade é " + idade);

        idade = 6 * 2 - 5;
        Console.Write("A idade de Fulano é " + idade + " anos. ");
        
        idade = (27 - 5) * 2;
        Console.WriteLine("Já a Ciclana tem " + idade + " anos.");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}