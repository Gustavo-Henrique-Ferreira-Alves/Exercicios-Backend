using System;

namespace Sobreposicao_override
{
    class Program
    {
        static void Main(string[] args)
        {
            Megaman m = new Megaman();

            Zero z = new Zero();

            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());

            Console.WriteLine(z.Correr());
            Console.WriteLine(z.Pular());
        }
    }
}
