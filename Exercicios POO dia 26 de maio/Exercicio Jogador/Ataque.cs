using System;

namespace Exercicio_Jogador
{
    public class Ataque : Jogador
    {
        public void Atacante()
        {
            if (Idade > 35)
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