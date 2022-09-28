using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
        
        //long é um tipo de variável de 64 bits
        long x = 2000000000000000000;
        Console.WriteLine(x);
        
        short y = 32000;
        Console.WriteLine(y);
        
        float z = 1.6234f;
        Console.WriteLine(z);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}