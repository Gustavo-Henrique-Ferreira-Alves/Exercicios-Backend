using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Digite a nota de 0 a 10: ");
                int nota = int.Parse(Console.ReadLine());
                if (nota > 10)
                Console.WriteLine("Nota inválida!");
            
                else
                {
                Console.WriteLine("Nota válida!");
                Console.WriteLine("Obrigado por usar o nosso sistema!!!");
                resposta = true;
                }

            } while(resposta == false);
        }
    }
}
