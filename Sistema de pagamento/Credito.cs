using System;

namespace Sistema_de_pagamento
{
    public class Credito : Cartao
    {
        private float Limite = 3000f;
        public void Pagar()
        {
            float valor = this.Valor;
            int Vezes;

            if (valor > Limite)
            {
                Console.WriteLine("Você não tem limite suficiente para fazer essa compra!!!\n");
            }

            else
            {
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor R${valor}? (De 1 a 12)\n");
                    Vezes = int.Parse(Console.ReadLine());

                    if (Vezes >= 1 && Vezes <= 6)
                    {
                        Console.WriteLine($"Você optou por parcelar em {Vezes} vezes, dessa forma o juros será de 5% do valor total\n");
                        Console.WriteLine($"Você pagará R${valor * 1.05} em {Vezes} vezes de R${(valor * 1.05) / Vezes}");
                    }

                    else if (Vezes >= 7 && Vezes >= 12)
                    {
                        Console.WriteLine($"Você optou por parcelar em {Vezes} vezes, dessa forma o juros será de 5% do valor total\n");
                        Console.WriteLine($"Você pagará R${valor * 1.08} em {Vezes} vezes de R${(valor * 1.08) / Vezes}");
                    }

                    else
                    {
                        Console.WriteLine("Impossível parcelar nessa quantidade, escolha um número de vezes entre 1 a 12!!!\n");
                    }
                } while (Vezes > 12 || Vezes < 1);
            }
        }
    }
}
