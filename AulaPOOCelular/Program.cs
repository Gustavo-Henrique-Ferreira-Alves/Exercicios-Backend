using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostaLigar;
            string Opcoes;
            string ligacao;
            string mensagem;

            Console.WriteLine(@"
                |=================================================|
                |   Olá!!! Digite se você quer ligar o celular:   |
                |                   sim/não                       |
                |=================================================|                          
            ");
            respostaLigar = Console.ReadLine().ToLower();

            Celular phone = new Celular();

            if (respostaLigar == "sim")
            {
                phone.Ligar();
            }

            else
            {
                Console.WriteLine("O celular está desligado!!!");
            }

            if (phone.ligar == true)
            {
                do
                {
                    Menu();
                    Opcoes = Console.ReadLine();

                    switch (Opcoes)
                    {
                        case "1":
                            Console.WriteLine("Digite Para quem você quer ligar: ");
                            ligacao = Console.ReadLine();
                            Console.WriteLine("Ligando para " + ligacao + " (Digite 1 para encerrar a ligação)");
                            Console.ReadLine();
                            Console.WriteLine(phone.Ligacao());
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Digite Para quem você quer mandar uma mensagem: ");
                            mensagem = Console.ReadLine();
                            Console.WriteLine("Digite a mensagem para " + mensagem + ":");
                            Console.ReadLine();
                            Console.WriteLine(phone.Mensagem());
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Propriedades do celular: ");
                            Console.WriteLine(phone.cor);
                            Console.WriteLine(phone.modelo);
                            Console.WriteLine(phone.tamanho);
                            break;

                        case "4":
                            Console.WriteLine(phone.Desligar());
                            Console.Clear();
                            Console.WriteLine("Desligando!!!");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Erro!!! Por favor digitei apenas o número da opção que você quer usar: ");
                            phone.ligar = true;
                            break;
                    }
                } while (phone.ligar == true);
            }

            static void Menu()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@" 
                   |======================================|
                   |                                      |
                   |                                      |
                   |======================================|
                   |                                      |
                   |                                      |
                   |                                      |
                   |    DIGITE O NÚMERO DE ALGUMA OPÇÃO   |                               
                   |                                      | 
                   |                                      |
                   |    1- Fazer uma ligação              |
                   |    2- Enviar mensagem para alguém    |
                   |    3- Ver propriedades               |
                   |    4- Desligar                       |
                   |                                      |
                   |                                      |
                   |                                      |
                   |======================================|
                ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
