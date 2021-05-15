using System;

namespace Projeto_Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            string Usuario;
            string Senha;
            string SenhaCorreta;
            string Opcoes;
            string[] NomePassageiro = new string[5];
            string[] Origem = new string[5];
            string[] Destino = new string[5];
            string[] DataVoo = new string[5];
            int i = 0;
            string Resposta;
            bool Condicao = false;

            do
            {
                Console.WriteLine("Por favor digite o nome de usuário: ");
                Usuario = Console.ReadLine();

                Console.WriteLine("Digite a sua senha para acessar o menu: ");
                Senha = (Console.ReadLine());

                SenhaCorreta = "123456";

                if (Senha == SenhaCorreta)
                {
                    do
                    {
                        Console.WriteLine(@" 
                |==================================================|
                |                                                  |
                |           SELECIONE UMA DAS OPÇÕES               |                               
                |                                                  |     
                |           1- Cadastrar                           |
                |           2- Listar Passagens                    |
                |           0- Sair                                |
                |                                                  |
                |==================================================|
                ");
                        Opcoes = Console.ReadLine();

                        switch (Opcoes)
                        {
                            case "1":
                                do
                                {
                                    Console.WriteLine("Por favor digite o nome do passageiro: ");
                                    NomePassageiro[i] = Console.ReadLine();

                                    Console.WriteLine("Digite onde você mora: ");
                                    Origem[i] = Console.ReadLine();

                                    Console.WriteLine("Digite para onde você gostaria de ir: ");
                                    Destino[i] = Console.ReadLine();

                                    Console.WriteLine("Digite a data do voo: ");
                                    DataVoo[i] = Console.ReadLine();

                                    Console.WriteLine("Você quer digitar outra passagem (Digite sim ou não): ");
                                    Resposta = Console.ReadLine();
                                    i++;
                                } while (Resposta == "sim");

                                break;

                            case "2":
                                Console.Clear();
                                for (var c = 0; c < i; c++)
                                {
                                    Console.WriteLine($"\n Nome = {NomePassageiro[c]}       Origem = {Origem[c]}      Destino = {Destino[c]}       Data do Voo = {DataVoo[c]}\n");
                                }
                                break;

                            case "0":
                                Console.WriteLine("Obrigado por usar nosso sistema");
                                Condicao = true;
                                break;

                            default:

                                break;
                        }
                    } while (!Condicao);
                }
                else
                {
                    Console.WriteLine("\nVocê não conseguiu entrar no menu!!! Verifique se o nome de usuário e senha estão corretos\n");
                }

            } while (Senha != SenhaCorreta);
        }
    }
}
