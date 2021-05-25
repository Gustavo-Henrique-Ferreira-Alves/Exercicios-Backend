using System;

namespace Sistema_de_pagamento
{    
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string Cvv;

        public string SalvarCartao()
        {
            Console.WriteLine("Digite a bandeira do cartão: \n");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão: \n");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão: \n");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o cvv do cartão: \n");
            Cvv = Console.ReadLine();

            return $"Cartão de número {Numero} salvo com sucesso\n";
        }
    }
}
