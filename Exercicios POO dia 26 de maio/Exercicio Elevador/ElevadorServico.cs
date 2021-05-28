using System;

namespace Exercicio_Elevador
{
    public class ElevadorServico : Elevador
    {
        public void InicializarSe()
        {
            Console.WriteLine("\nQual a capacidade de caixas do elevador: (Digite apenas o número)");
            Capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantos andares há no prédio: (Digite apenas o número)");
            Andares = int.Parse(Console.ReadLine());
        }

        public void EntrarSe()
        {
            Console.WriteLine("\nVocê deseja entrar no elevador: (sim ou não)");
            Entra = Console.ReadLine().ToLower();

            if (Entra == "sim")
            {
                Console.WriteLine("\nQuantas caixas há no elevador: (Digite apenas o número)");
                PessoasOuCaixas = int.Parse(Console.ReadLine().ToLower());

                if (PessoasOuCaixas < Capacidade)
                {
                    Console.WriteLine("\nVocê pode entrar no elevador!!!\n");
                }

                else
                {
                    Console.WriteLine("\nO elevador está lotado!!! Por favor entre em outro momento!!!\n");
                }
            }
            else
            {
                Console.WriteLine("\nNão aperte o botão para usar o elevador se você não for utilizar!!!\n");
            }
        }
    }
}