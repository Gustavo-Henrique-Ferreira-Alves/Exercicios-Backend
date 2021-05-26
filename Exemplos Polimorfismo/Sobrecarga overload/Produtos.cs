using System;

namespace Sobrecarga_overload
{
    public class Produtos
    {
        public string[] Lista = new string [4];
        public void Mostrar()
        {
            foreach (var produto in Lista)
            {
                Console.WriteLine(produto);
            }
        }
        public void Mostrar(int Indice)
        {
            Console.WriteLine(Lista[Indice]);
        }
        public void Mostrar(string Busca)
        {
            for (int i = 1; i < Lista.Length; i++)
            {
                if (Lista[i] == Busca)
                {
                    Console.WriteLine($"{Lista[i]} foi encontrado no índice {i}");
                }
            }
        }
    }
}