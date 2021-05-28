using System;

namespace Exercicio_Elevador
{
    public class Elevador
    {
        protected int Capacidade { get; set; }
        protected int Andares { get; set; }
        protected int PessoasOuCaixas { get; set; }
        protected string Entra { get; set; }
        protected string ConfirmaçãoSair { get; set; }
        protected int AndarAtual { get; set; }
        protected int RespostaAndar { get; set; }
        protected int Contador { get; set; }

        public void Inicializar()
        {
            Console.WriteLine("\nQual a capacidade de pessoas ao mesmo tempo no elevador: (Digite apenas o número)");
            Capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantos andares há no prédio: (Digite apenas o número)");
            Andares = int.Parse(Console.ReadLine());
        }

        public void Entrar()
        {
            Console.WriteLine("\nVocê deseja entrar no elevador: (sim ou não)");
            Entra = Console.ReadLine().ToLower();

            if (Entra == "sim")
            {
                Console.WriteLine("\nQuantas pessoas há no elevador: (Digite apenas o número)");
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

        public void Sair()
        {
            if (PessoasOuCaixas > 0)
            {
                Console.WriteLine("\nVocê deseja sair do elevador (sim ou não)");
                ConfirmaçãoSair = Console.ReadLine();

                if (ConfirmaçãoSair == "sim")
                {
                    Console.WriteLine("\nAté mais!!!\n");
                }
            }
            else
            {
                Console.WriteLine("\nO elevador está vazio!!!\n");
            }
        }

        public void Subir()
        {
            do
            {
                Console.WriteLine("Para qual andar você quer ir: ");
                RespostaAndar = int.Parse(Console.ReadLine());

                if (RespostaAndar <= Andares)
                {
                    Contador = RespostaAndar - AndarAtual;
                    for (int i = 0; i < Contador; i++)
                    {
                        AndarAtual = AndarAtual + 1;
                        Console.WriteLine($"\nVocê está no {AndarAtual}° andar\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nNúmero do andar é inválido!!! Por favor digite um andar existente");
                }
            } while (RespostaAndar > Andares && RespostaAndar <= 0);
        }

        public void Descer()
        {
            do
            {
                Console.WriteLine("\nPara qual andar você quer ir: ");
                RespostaAndar = int.Parse(Console.ReadLine());

                if (RespostaAndar < Andares)
                {
                    Contador = RespostaAndar - AndarAtual;
                    for (int i = 0; i < Contador; i++)
                    {
                        AndarAtual = AndarAtual - 1;
                        Console.WriteLine($"\nVocê está no {AndarAtual}° andar!\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nNúmero de andar é inválido!!! Por favor digite um andar existente\n");
                }
            } while (RespostaAndar <= 0);
        }
    }
}