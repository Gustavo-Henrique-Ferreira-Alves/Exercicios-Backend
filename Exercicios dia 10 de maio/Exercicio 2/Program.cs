using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Gasolina = 5.30;
            double Alcool = 4.90;
            double Desconto = 0;
            double Total = 0;

            Console.WriteLine("Digite o tipo de combustível, sendo G para gasolina e A para álcool (Não esqueça de digitar em maiúsculo): ");
            string Combustivel = (Console.ReadLine());

            Console.WriteLine("Digite a quantidade de litros (Apenas o número): ");
            int Litros = int.Parse(Console.ReadLine());

            switch (Combustivel)
            {
                case "G":

                    if (Litros <= 20)
                    {
                        Desconto = 5.30 * 0.04;
                        Total = Litros * (Gasolina - Desconto);
                    }

                    else
                    {
                        Desconto = 5.30 * 0.06;
                        Total = Litros * (Gasolina - Desconto);
                    }
                    break;

                case "A":
                    if (Litros <= 20)
                    {
                        Desconto = 4.90 * 0.03;
                        Total = Litros * (Alcool - Desconto);
                    }

                    else
                    {
                        Desconto = 4.90 * 0.05;
                        Total = Litros * (Alcool - Desconto);
                    }
                    break;

                default:
                    Console.WriteLine("Inválido!!! Por Favor siga as instruções passadas");
                    break;
            }

            Console.WriteLine("O total a ser pago é igual a R$ " + Total);
        }
    }
}
