using System;

namespace Sobrecarga_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos f = new Produtos();

            Console.WriteLine("\nOlá bem vindo a cantina do senai!!!");

            for (var i = 1; i < f.Lista.Length; i++)
            {
                Console.WriteLine("\nDigite o produto que você deseja comprar: ");
                f.Lista[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nTodos os produtos listados: ");
            f.Mostrar();

            Console.WriteLine("\nProduto do índice que você escolheu: ");
            f.Mostrar(2);

            Console.WriteLine("\nProduto que você escolheu: ");
            f.Mostrar("café");
        }
    }
}
