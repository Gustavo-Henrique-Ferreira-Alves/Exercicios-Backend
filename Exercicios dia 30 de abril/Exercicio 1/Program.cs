using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Anos, Meses, Dias, Horas, Minutos;
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Qual é a sua idade?");
            Anos = int.Parse(Console.ReadLine());

            Meses = Anos * 12;
            Dias = Anos * 365;
            Horas = Anos * 8760;
            Minutos = Anos * 525600;

            Console.WriteLine("Sua idade em meses é:" + Meses);
            Console.WriteLine("Sua idade em dias é:" + Dias);
            Console.WriteLine("Sua idade em horas é:" + Horas);
            Console.WriteLine("Sua idade em minutos é:" + Minutos);
        }
    }
}
