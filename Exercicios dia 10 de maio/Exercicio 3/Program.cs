using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string Nome = Console.ReadLine();
            
            Console.WriteLine("Digite a quantidade adquirida: ");
            int Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o preço unitário: ");
            double Preco = double.Parse(Console.ReadLine());

            double TotalInicial = Quantidade * Preco;

            if (Quantidade <= 5){
                double TotalFinal =  TotalInicial * 0.98;
                Console.WriteLine("O valor total é de R$" + TotalFinal);
            }

            else if (Quantidade > 5 && Quantidade <= 10){
                double TotalFinal =  TotalInicial * 0.97;
                Console.WriteLine("O valor total é de R$" + TotalFinal);
            }

            else {
                double TotalFinal =  TotalInicial * 0.95;
                Console.WriteLine("O valor total é de R$" + TotalFinal);
            }
        }
    }
}
