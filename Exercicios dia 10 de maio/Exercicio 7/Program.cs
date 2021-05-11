using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int [10];

            for (var i = 1; i < 16; i++){
                Console.Write("Digite o número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
