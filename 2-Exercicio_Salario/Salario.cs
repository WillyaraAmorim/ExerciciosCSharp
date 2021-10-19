using System;

namespace _2_Exercicio_Salario
{
    public class Salario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos salários minimos o funcionário recebe?");

            //Declarando as variáveis
            double SalarioFunc;
            SalarioFunc = 0.0;
            double SalarioMinimo;
            SalarioMinimo = 1100.00;
            double QuantSalarioMinimo;

            //Instrução para o usuário
            Console.WriteLine("Por favor, inserir o Salário do Funcionário: ");
            SalarioFunc = Convert.ToDouble(Console.ReadLine());

            //Operação matemática
            QuantSalarioMinimo = SalarioFunc / SalarioMinimo;
            
            //Resposta ao usuário
            Console.WriteLine("Você recebe até {0}", QuantSalarioMinimo);

        }
    }
}
