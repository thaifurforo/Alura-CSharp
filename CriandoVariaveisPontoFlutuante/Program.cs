using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        
        double salario;
        salario = 3000.13;
        Console.WriteLine(salario);

        double idade;
        
        idade = 7 / 5;
        Console.WriteLine(idade);

        idade = 7.0 / 5;
        Console.WriteLine(idade);

        idade = 7 / 5.0;
        Console.WriteLine(idade);
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
    
}