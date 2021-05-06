using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nascimento, Atual, Idade, Semana;
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Qual o ano de nascimento seu?");
            Nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ano atual?");
            Atual = int.Parse(Console.ReadLine());
            
            Idade = Atual - Nascimento;
            Semana = Idade * 52;
            Console.WriteLine("Sua idade é igual a " + Idade + " anos");
            Console.WriteLine("Sua idade em semanas é igual a " + Semana);
        }
    }
}
