using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        bool base1 = salario >= 1900.0 && salario <= 2800.0;
        bool base2 = salario > 2800.0 && salario <= 3751.0;
        bool base3 = salario > 3751.0 && salario <= 4664.0;

        double deducao1 = 142.0;
        double deducao2 = 350.0;
        double deducao3 = 636.0;

        double ir1 = 0.075;
        double ir2 = 0.15;
        double ir3 = 0.225;

        double irrf = 0;

        if (base1)
            irrf = salario * ir1 - deducao1;
        else if (base2)
            irrf = salario * ir2 - deducao2;
        else if (base3)
            irrf = salario * ir3 - deducao3;

        Console.WriteLine("O valor do IRRF retido será: " + irrf);
        
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}