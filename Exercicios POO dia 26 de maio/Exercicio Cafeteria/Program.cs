using System;

namespace Exercicio_Cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            string RespostaComOuSem;
            string RespostaAcucar;
            int ColocarAcucar;

            Console.WriteLine("\nOlá!!! Digite se você deseja fazer com açucar ou sem: (Digite apenas com ou sem)");
            RespostaComOuSem = Console.ReadLine().ToLower();

            if (RespostaComOuSem == "com")
            {
                Console.WriteLine("\nVocê deseja digitar a quantidade de açúcar a ser colocada no café: (Digite apenas sim ou não)");
                RespostaAcucar = Console.ReadLine();

                if (RespostaAcucar == "sim")
                {
                    Console.WriteLine("\nDigite a quantidade de gramas de açúcar que você deseja no café? (Apenas o número)");
                    ColocarAcucar = int.Parse(Console.ReadLine());
                    m.FazerCafe(ColocarAcucar);
                }
                else
                {
                    ColocarAcucar = 10;
                    m.FazerCafe(ColocarAcucar);
                }
            }

            else
            {
                Console.WriteLine("\nO café sem açúcar está pronto!!!");
            }
        }
    }
}
