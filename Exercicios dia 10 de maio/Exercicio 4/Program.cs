using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int [10]; 

            for (var i = 0; i < 10; i++){
                Console.Write("Digite o número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }
            
            int MaiorNumero = Numeros[9];
            int MenorNumero = Numeros[0];
            Array.Sort(Numeros);
            Console.WriteLine("O maior número é igual a: " + MaiorNumero);
            Console.WriteLine("O menor número é igual a: " + MenorNumero);
        }
    }
}
