using System;

namespace _1_Exercicio_IMC
{
    public class IMC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1: Validando o IMC!");

            //Declarando variaveis
            double Peso;
            Peso = 0.0;
            double Altura;
            Altura = 0.0;
            double IMC;

            //Instruções para o usuário inserir o peso
            Console.WriteLine("Digite o peso: ");
            Peso = Convert.ToDouble(Console.ReadLine());

            //Instruções para o usuário inserir o altura
            Console.WriteLine("Digite a altura ");
            Altura = Convert.ToDouble(Console.ReadLine());

            //Calculo do IMC
            IMC = Peso / (Altura * Altura);

            //Estrutura de decisão
           if (IMC < 20)
            {
                Console.WriteLine("Abaixo do Peso.");
            }
            else if ((IMC >= 20) && (IMC <= 25))
            {
                Console.WriteLine("Peso ideal.");
            }
            else if (IMC >= 25)
            {
                Console.WriteLine("Acima do peso.");
            }

        }
    }
}
