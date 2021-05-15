using System;

namespace Sistema_de_produtos
{
    class Program
    {
        static string[] Nome = new string[10];
        static float[] Preco = new float[10];
        static bool[] Promocao = new bool[10];
        static int i = 0;
        static string Opcoes;
        static string RespostaPromocao;
        static string RespostaProduto;
        static string SimOuNao;
        static bool Condicao = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao sistema!!!!!");
            do
            {
                Menu();
                Opcoes = Console.ReadLine();

                switch (Opcoes)
                {
                    case "1":
                        do
                        {
                            Cadastrar();
                        } while (RespostaProduto == "sim");
                        break;

                    case "2":
                        Console.Clear();
                        Listar();
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por usar nosso sistema");
                        Condicao = true;
                        break;

                    default:
                        Console.WriteLine("Erro!!! Por favor digitei apenas o número da função que você quer usar: ");
                        break;
                }
            } while (!Condicao);


            static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@" 
                |==================================================|
                |                                                  |
                |           SELECIONE UMA DAS OPÇÕES               |                               
                |                                                  |     
                |           1- Cadastrar Produtos                  |
                |           2- Listar Produtos                     |
                |           0- Sair                                |
                |                                                  |
                |==================================================|
                ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            static void Cadastrar()
            {
                Console.WriteLine("Por favor digite o nome do produto (Você pode cadastrar no máximo 10): ");
                Nome[i] = Console.ReadLine();

                Console.WriteLine("Digite o preço unitário do produto (Digite apenas o valor, sem R$ ou reais): ");
                Preco[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite se o produto está em promoção: ");
                RespostaPromocao = Console.ReadLine().ToLower();

                if (RespostaPromocao == "sim")
                {
                    Promocao[i] = true;
                }
                else
                {
                    Promocao[i] = false;
                }

                Console.WriteLine("Você quer digitar outro produto (Digite apenas sim ou não): ");
                RespostaProduto = Console.ReadLine().ToLower();
                i++;
            }

            static void Listar()
            {
                for (var c = 0; c < i; c++)
                {
                    if (Promocao[c] == true)
                    {
                        SimOuNao = Promocao[c].ToString();
                        SimOuNao = "Sim";
                    }
                    else
                    {
                        SimOuNao = Promocao[c].ToString();
                        SimOuNao = "Não";
                    }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($@" 
                         
                Nome = {Nome[c]}                     
                Preço = R${Preco[c]} 
                Promoção = {SimOuNao}            
                ");
                }
            }
        }
    }
}
