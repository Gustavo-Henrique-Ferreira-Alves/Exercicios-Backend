using System;

namespace Exercicio_Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;
            do
            {
                Console.WriteLine("\nOlá!!! Digite a posição do jogador: (Escolha defesa, meio campo ou ataque)");
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "defesa":
                        Defesa d = new Defesa();
                        d.Salvar();
                        d.Mostrar();
                        d.Defensor();
                        d.AposentadoriaDefesa();
                        opcaoValida = true;
                        break;

                    case "meio campo":
                        MeioCampo m = new MeioCampo();
                        m.Salvar();
                        m.Mostrar();
                        m.Meia();
                        m.AposentadoriaMeia();
                        opcaoValida = true;
                        break;

                    case "ataque":
                        Ataque a = new Ataque();
                        a.Salvar();
                        a.Mostrar();
                        a.Atacante();
                        a.AposentadoriaAtaque();
                        opcaoValida = true;
                        break;

                    default:
                        Console.WriteLine("\nPor favor digite apenas defesa, meio campo ou ataque");
                        opcaoValida = false;
                        break;
                }
            } while (!opcaoValida);
        }
    }
}
