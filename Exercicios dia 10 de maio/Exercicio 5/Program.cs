using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Resultado;
            int PrimeiroNumero;
            int SegundoNumero;

            for (PrimeiroNumero = 1; PrimeiroNumero <= 10; PrimeiroNumero++)
            {
            Console.WriteLine("\nA tabuada é igual a:");
                for(SegundoNumero = 1; SegundoNumero <= 10; SegundoNumero++)
                {
                    Resultado = PrimeiroNumero * SegundoNumero;
                    Console.WriteLine(PrimeiroNumero + " X " + SegundoNumero + " = " + Resultado);
                }
            }
        }
    }
}
