using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            int AnoNascimento = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o ano atual: ");
            int AnoAtual = int.Parse(Console.ReadLine());
            
            int Idade = AnoNascimento - AnoAtual;
            
            if (Idade >= 18){
                Console.WriteLine("Você pode votar!");
            }
            
            else{
                Console.WriteLine("Você não pode votar!");
            }
        }
    }
}
