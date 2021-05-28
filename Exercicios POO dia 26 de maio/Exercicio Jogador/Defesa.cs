using System;

namespace Exercicio_Jogador
{
    public class Defesa : Jogador
    {
        public void Defensor()
        {
            if (Idade > 40)
            {
                Console.WriteLine("Possivelmente o jogador já se aponsentou");
            }

            else
            {
                Console.WriteLine("Anos para se aposentar: ");
            }
        }
    }
}