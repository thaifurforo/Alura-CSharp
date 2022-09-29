using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 9 - Escopo");
        
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        
        // A variável tem que ser declarada no escopo principal pra poder ser usada dentro do próximo if, senão dará erro
        string textoAdicional;

        if (!acompanhado)
            textoAdicional = "João não está acompanhado";
        else
            textoAdicional = "João está acompanhado";

        Console.WriteLine(textoAdicional);
        
        if (idadeJoao >= 18 || acompanhado)
            Console.WriteLine("Pode entrar!");
        else
            Console.WriteLine("Não pode entrar!");

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}