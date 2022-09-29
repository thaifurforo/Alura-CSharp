using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        bool teste = true;
        
        if (teste)
        {
            Console.WriteLine("Teste está ok");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}