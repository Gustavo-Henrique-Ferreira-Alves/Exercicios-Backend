using System;

namespace Exercicio_Jogador
{
    public class MeioCampo : Jogador
    {
        public void Meia()
        {
            if (Idade > 38)
            {
                Console.WriteLine("\nPossivelmente o jogador já se aponsentou");
            }

            else
            {
                Console.WriteLine("Anos para se aposentar: ");
            }
        }
    }
}