using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Digite seu nome de usuário: ");
                string Usuario = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                string Senha = Console.ReadLine();

                if (Usuario == Senha)
                Console.WriteLine("Erro!!! Não é possível ter um nome de usuário e senha iguais");

                else
                {
                Console.WriteLine("Cadastro concluído");
                Console.WriteLine("Obrigado por usar o nosso sistema!!!");
                resposta = true;
                }

            } while(resposta == false);
        }
    }
}
