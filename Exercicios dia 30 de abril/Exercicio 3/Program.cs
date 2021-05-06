using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string NomePessoa = Console.ReadLine();

            Console.WriteLine("Bom dia " + NomePessoa + " qual o valor do seu salário?");
            double Salario = double.Parse(Console.ReadLine());
            
            if (Salario < 500)
            {
                double Reajuste = Salario * 1.3;
                Console.WriteLine("Seu salário será reajustado para " + "R$" + Reajuste);
            } else {
                Console.WriteLine("Seu salário não será reajustado");
            }
        }
    }
}
