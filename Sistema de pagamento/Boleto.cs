using System;

namespace Sistema_de_pagamento
{
        public class Boleto : Pagamento
    {
        private string CodigoDeBarras;
        Random r = new Random();

        public void Registrar()
        {
            CodigoDeBarras = r.Next(100000000).ToString();
            Console.WriteLine($"Boleto gerado com o código {CodigoDeBarras}\n");
            Console.WriteLine($"Boleto registrado com desconto, o valor é de R${this.Valor * 0.88}\n");
        }
    }
}