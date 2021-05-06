using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá qual o seu nome?");
            string NomePessoa = Console.ReadLine();

            Console.WriteLine("Bom dia " + NomePessoa + " por favor digite sua idade");
            int Idade = int.Parse(Console.ReadLine());
            
            if (Idade >= 5 && Idade <= 7){
                Console.WriteLine("Sua categoria é a Infantil A");
            }

            if (Idade >= 8 && Idade <= 10){
                Console.WriteLine("Sua categoria é a Infantil B");
            }

            if (Idade >= 11 && Idade <= 13){
                Console.WriteLine("Sua categoria é a Juvenil A");
            }
    
            if (Idade >= 14 && Idade <= 17){
                Console.WriteLine("Sua categoria é a Juvenil B");
            }
            
            if (Idade >= 18){
                Console.WriteLine("Sua categoria é a Sênior");
            }
        }
    }
}
