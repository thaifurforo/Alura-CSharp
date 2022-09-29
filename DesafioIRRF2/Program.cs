using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        
        double deducao1 = 142.0;
        double deducao2 = 350.0;
        double deducao3 = 636.0;

        double ir1 = 0.075;
        double ir2 = 0.15;
        double ir3 = 0.225;

        double irrf = 0;

        switch (salario)
        {
            case >= 1900.0 and <= 2800.0:
                irrf = salario * ir1 - deducao1;
                break;
            case > 2800.0 and <= 3751.0:
                irrf = salario * ir2 - deducao2;
                break;
            case > 3751.0 and <= 4664.0:
                irrf = salario * ir3 - deducao3;
                break;
            default:
                Console.WriteLine("Faixa salarial inválida");
                break;
        }
        
        
        Console.WriteLine("O valor do IRRF retido será: " + irrf);
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}