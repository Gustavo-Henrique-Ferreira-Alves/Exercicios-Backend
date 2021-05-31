using System;

namespace Exercicio_Elevador
{
    class Program
    {
        static bool recomecar = false;
        static void Main(string[] args)
        {
            ElevadorServico se = new ElevadorServico();
            ElevadorSocial so = new ElevadorSocial();

            Console.WriteLine("Olá!!! Você deseja usar o elevador social ou de serviço: (Digite apenas serviço ou social)");
            string RespostaElevador = Console.ReadLine().ToLower();

            if (RespostaElevador == "social")
            {
                so.Inicializar();

                do
                {
                    Console.WriteLine(@"
|------------------------------|
|      Opcoes do Elevador:     |      
|                              |
|      1 - Entrar              |
|      2 - Subir               |
|      3 - Descer              |  
|      4 - Sair                |
|------------------------------|
");
                    string Resposta = Console.ReadLine();

                    switch (Resposta)
                    {
                        case "1":
                            so.Entrar();
                            Voltar();
                            break;

                        case "2":
                            so.Subir();
                            Voltar();
                            break;

                        case "3":
                            so.Descer();
                            Voltar();
                            break;

                        case "4":
                            so.Sair();
                            Voltar();
                            break;

                        default:
                            Console.WriteLine("\nPor favor digite alguma das opções!!!");
                            break;
                    }
                } while (recomecar);
            }

            else
            {
                se.InicializarSe();

                do
                {
                    Console.WriteLine(@"
|------------------------------|
|      Opcoes do Elevador:     |      
|                              |
|      1 - Entrar              |
|      2 - Subir               |
|      3 - Descer              |  
|      4 - Sair                |
|------------------------------|
");
                    string Resposta = Console.ReadLine();

                    switch (Resposta)
                    {
                        case "1":
                            se.EntrarSe();
                            Voltar();
                            break;

                        case "2":
                            se.Subir();
                            Voltar();
                            break;

                        case "3":
                            se.Descer();
                            Voltar();
                            break;

                        case "4":
                            se.Sair();
                            Voltar();
                            break;

                        default:
                            Console.WriteLine("\nPor favor digite alguma das opções!!!");
                            break;
                    }
                } while (recomecar);
            }
        }

        static void Voltar()
        {
            Console.WriteLine(@"
|------------------------------|
|      Quer voltar ao menu:    |      
|                              |             
|      1 - Sim                 |
|      2 - Não                 |                 
|------------------------------|
            ");

            string Resposta = Console.ReadLine();

            if (Resposta == "1")
            {
                recomecar = true;
            }

            if (Resposta == "2")
            {
                recomecar = false;
            }
        }
    }
}
