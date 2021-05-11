using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        bool VarTabuada = false;
        do
        {
            Console.WriteLine("Digite a tabuada que você deseja (de 1 a 10): ");
            int Tabuada = int.Parse(Console.ReadLine());
            
            if (Tabuada == 1){
                Console.WriteLine("A tabuada do 1 é igual a: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10.");
                VarTabuada = true;
            }

            if (Tabuada == 2){
                Console.WriteLine("A tabuada do 2 é igual a: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20.");
                VarTabuada = true;
            }

            if (Tabuada == 3){
                Console.WriteLine("A tabuada do 3 é igual a: 3, 6, 9, 12, 15, 18, 21, 24, 27, 30.");
                VarTabuada = true;
            }

            if (Tabuada == 4){
                Console.WriteLine("A tabuada do 4 é igual a: 4, 8, 12, 16, 20, 24, 28, 32, 36, 40.");
                VarTabuada = true;
            }

            if (Tabuada == 5){
                Console.WriteLine("A tabuada do 5 é igual a: 5, 10, 15, 20, 25, 30, 35, 40, 45, 50.");
                VarTabuada = true;
            }

            if (Tabuada == 6){
                Console.WriteLine("A tabuada do 6 é igual a: 6, 12, 18, 24, 30, 36, 42, 48, 54, 60.");
                VarTabuada = true;
            }

            if (Tabuada == 7){
                Console.WriteLine("A tabuada do 7 é igual a: 7, 14, 21, 28, 35, 42, 49, 56, 63, 70.");
                VarTabuada = true;
            }
            
            if (Tabuada == 8){
                Console.WriteLine("A tabuada do 8 é igual a: 8, 16, 24, 32, 40, 48, 56, 64, 72, 80.");
                VarTabuada = true;
            }

            if (Tabuada == 9){
                Console.WriteLine("A tabuada do 9 é igual a: 9, 18, 27, 36, 45, 54, 63, 72, 81, 90.");
                VarTabuada = true;
            }

            if (Tabuada == 10){
                Console.WriteLine("A tabuada do 10 é igual a: 10, 20, 30, 40, 50, 60, 70, 80, 90, 100.");
                VarTabuada = true;
            }
            
            else {
                VarTabuada = false;
            }

        }while (VarTabuada == false);
        }
    }
}
