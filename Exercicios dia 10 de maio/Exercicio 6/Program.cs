using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Pessoas = new string [10];

            for (var i = 0; i < 10; i++){
                Console.WriteLine("Digite o nome da pessoa (Não esqueca de digitar a primeira letra em maiúsculo): ");
                Pessoas[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Digite o nome da pessoa que você quer encontrar (Não esqueca de digitar a primeira letra em maiúsculo): ");
            string BuscaNome = Console.ReadLine();

            foreach (var item in Pessoas){

                if (item == BuscaNome){
                Console.WriteLine("A pessoa está cadastrada");
                } 
                    
                else{
                    Console.WriteLine("A pessoa não está cadastrada");
                }
            }
        }
    }
}
