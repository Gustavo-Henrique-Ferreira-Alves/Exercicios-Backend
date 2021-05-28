using System;

namespace Exercicio_Cafeteria
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel;
        public string CafeSemAcucar;
        public int ColocarAcucar;
        public void FazerCafe(int ColocarAcucar)
        {
            AcucarDisponivel = 250;

            if (ColocarAcucar <= AcucarDisponivel)
            {
                Console.WriteLine("\nO café está pronto!!!");
                AcucarDisponivel = AcucarDisponivel - ColocarAcucar;
                Console.WriteLine($"\nQuantidade de açúcar disponível na máquina: {AcucarDisponivel} gramas");
            }
            else
            {
                Console.WriteLine("\nSó é possível fazer o café sem açúcar");
                Console.WriteLine("\nDigite se deseja fazer o café sem açucar: (Apenas sim ou não)");
                CafeSemAcucar = Console.ReadLine().ToLower();

                if (CafeSemAcucar == "sim")
                {
                    Console.WriteLine("\nO café está pronto!!!");
                    Console.WriteLine("\nColoque açucar da próxima vez, caso você quiser fazer o café");
                }
                else
                {
                    Console.WriteLine("\nDesligue a máquina e coloque o açucar, só assim irá conseguir fazer o café com açucar");
                }
            }
        }

        public void FazerCafe()
        {
            if (AcucarDisponivel >= ColocarAcucar)
            {
                Console.WriteLine("\nO café está pronto!!!");
                AcucarDisponivel = AcucarDisponivel - 10;
                Console.WriteLine($"\nQuantidade de açúcar disponível na máquina: {AcucarDisponivel} gramas");
            }
            else
            {
                Console.WriteLine("\nSó é possível fazer o café sem açúcar");
                Console.WriteLine("\nDigite se deseja fazer o café sem açucar: (Apenas sim ou não)");
                CafeSemAcucar = Console.ReadLine().ToLower();

                if (CafeSemAcucar == "sim")
                {
                    Console.WriteLine("\nO café está pronto!!!");
                    Console.WriteLine("\nColoque açucar da próxima vez, caso você quiser fazer o café");
                }
                else
                {
                    Console.WriteLine("\nDesligue a máquina e coloque o açucar, só assim irá conseguir fazer o café com açucar");
                }
            }
        }
    }
}