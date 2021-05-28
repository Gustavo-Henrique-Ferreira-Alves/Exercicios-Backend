using System;

namespace Exercicio_Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador e = new Elevador();

            Console.WriteLine("\nO elevador chegou!!!");

            e.Inicializar();
            e.Entrar();
            e.Subir();
            e.Sair();

            /* for (var i = 1; i < f.Lista.Length; i++)
            {
                Console.WriteLine("\nDigite o produto que você deseja comprar: ");
                f.Lista[i] = Console.ReadLine().ToLower();
            } */
        }
    }
}
