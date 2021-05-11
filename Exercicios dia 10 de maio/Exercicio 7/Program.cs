using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int [15];

            for (var i = 0; i < 15; i++){
                Console.WriteLine("Digite o número: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            for(var i = 14; i >= 0; i--){
            Console.WriteLine("O número de forma inversa ficaria igual a : " + Numeros[i]);
            }
        }
    }
}
