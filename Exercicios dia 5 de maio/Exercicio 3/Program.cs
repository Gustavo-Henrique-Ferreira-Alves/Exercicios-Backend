using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        bool varNome = false;   
        do
        {  
            Console.WriteLine("Bom dia! Por favor digite seu nome: ");
            string Nome = (Console.ReadLine());

            if(string.IsNullOrEmpty(Nome)){
                Console.WriteLine("Erro!!! Não é possível ter um nome vazio ");
                varNome = false;
            } else {
                varNome = true;         
            }
        }while (varNome == false);
        
        bool varIdade = false;   
        do
        {    
            Console.WriteLine("Digite sua idade (Apenas o número): ");
            int Idade = int.Parse(Console.ReadLine());
            
            if (Idade > 120){
                Console.WriteLine("Erro!!! Digite uma idade menor que 120 anos "); 
                varIdade = false;
            } else {
                varIdade = true;
            }         
        }while (varIdade == false);

        bool varSalario = false;
        do
        {
            Console.WriteLine("Digite seu salário (Apenas o número): ");
            int Salario = int.Parse(Console.ReadLine());
            
            if (Salario <= 0){
                Console.WriteLine("Erro!!! Digite um salário maior que zero ");
                varSalario = false;
            } else {
                varSalario = true;
            }
        }while (varSalario == false);

        bool varEstadoCivil = false;
        do
        {
            Console.WriteLine("Digite seu estado civil, sendo s= solteiro(a), c= casado(a), v= viuvo(a), d= divorciado(a): ");
            string EstadoCivil = (Console.ReadLine());

            if (EstadoCivil == "c" || EstadoCivil == "s" || EstadoCivil == "v" || EstadoCivil == "d"){
                varEstadoCivil = true;
                Console.WriteLine("Seu cadastro foi concluído!\n"); 
            } else {
                Console.WriteLine("Erro!!! Digite apenas a primeira letra do seu estado civil");
                varEstadoCivil = false;
            }
        }while (varEstadoCivil == false);
        
        }
    }
}
