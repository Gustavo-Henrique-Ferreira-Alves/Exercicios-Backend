using System;

namespace Sistema_de_pagamento
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void Pagar()
        {
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente para efetuar a compra!!!\n");
            }
            else
            {
                Console.WriteLine($"O valor de R${valor} foi pago com sucesso!!!\n");
            }
        }
    }
}
