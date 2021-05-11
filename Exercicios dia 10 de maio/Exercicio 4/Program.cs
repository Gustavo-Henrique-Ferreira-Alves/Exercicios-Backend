using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int [10]; 

            for (var i = 0; i < 10; i++){
                Console.WriteLine("Digite o número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(Numeros);
            Console.WriteLine("O menor número é igual a: " + Numeros[0]);
            Console.WriteLine("O maior número é igual a: " + Numeros[9]);
        }
    }
}
