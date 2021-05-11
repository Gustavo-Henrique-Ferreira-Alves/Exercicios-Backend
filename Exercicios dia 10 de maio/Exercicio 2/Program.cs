using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Gasolina = 5.30;
        double Alcool = 4.90;
        double Total = 0;
        double Desconto = 0;
  
        Console.WriteLine("Digite o tipo de combustível, sendo G para gasolina e A álcool: ");
        string Combustivel = (Console.ReadLine());
            
        Console.WriteLine("Digite a quantidade de litros (Apenas o número): ");
        int Litros = int.Parse(Console.ReadLine()); 

        switch (Combustivel){
            case "g":

                if (Litros <= 20)
                {
                    /* double Custo = Litros * Gasolina;
                    double Desconto = (Custo * 4) / 100; */
                    Desconto = 5.30 * 0.04;
                    Total = Litros * (Gasolina - Desconto);
                    Console.WriteLine("O total a ser pago é igual a R$" + Total);
                }

                else if (Litros > 20){
                    /* double Custo = Litros * Gasolina;
                    double Desconto = (Custo * 6) / 100; */
                    Desconto = 5.30 * 0.06;
                    Total = Litros * (Gasolina - Desconto); 
                    Console.WriteLine("O total a ser pago é igual a R$" + Total);
                }
                break;

            case "a":
                if (Litros <= 20)
                {
                    /* double Custo = Litros * Alcool;
                    double Desconto = (Custo * 3) / 100; */
                    Desconto = 4.90 * 0.03;
                    Total = Litros * (Alcool - Desconto);
                    Console.WriteLine("O total a ser pago é igual a R$" + Total);
                }

                else if (Litros > 20){
                    /* double Custo = Litros * Alcool;
                    double Desconto = (Custo * 5) / 100; */
                    Desconto = 4.90 * 0.05;
                    Total = Litros * (Alcool - Desconto); 
                    Console.WriteLine("O total a ser pago é igual a R$" + Total);
                }
                break;
            }
        }
    }
}
