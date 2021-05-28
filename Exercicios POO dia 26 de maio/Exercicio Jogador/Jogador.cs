using System;

namespace Exercicio_Jogador
{
    public abstract class Jogador
    {
        public string Nome{get; set;}
        public int Nascimento{get; set;}
        public string Nacionalidade{get; set;}
        public string Altura{get; set;}
        public string Peso{get; set;}
        public int Idade{get; set;}
        public void Salvar()
        {
            Console.WriteLine("\nDigite o nome do jogador: ");
            Nome = Console.ReadLine();

            Console.WriteLine("\nDigite o ano de nascimento do jogador: ");
            Nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a nacionalidade do jogador: ");
            Nacionalidade = Console.ReadLine();

            Console.WriteLine("\nDigite a altura do jogador: ");
            Altura = Console.ReadLine();

            Console.WriteLine("\nDigite o peso do jogador: ");
            Peso = Console.ReadLine();

            Idade = 2021 - Nascimento;
        }
        public void Mostrar()
        {
            Console.WriteLine($@"
Dados do Jogador
Nome: {Nome}
Ano de nascimento: {Nascimento}
Nacionalidade: {Nacionalidade}
Altura: {Altura}
Peso: {Peso}
Idade: {Idade} anos
");
        }

        public void AposentadoriaDefesa()
        {
            Console.WriteLine($@"{40 - Idade}");
        }

        public void AposentadoriaAtaque()
        {
            Console.WriteLine($@"{35 - Idade}");
        }

        public void AposentadoriaMeia()
        {
            Console.WriteLine($@"{38 - Idade}");
        }
    }
}
