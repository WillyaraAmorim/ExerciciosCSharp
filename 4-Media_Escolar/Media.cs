using System;

namespace _4_Media_Escolar
{
    public class Media
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média Escolar");

            //Declarando as variáveis
            double nota1, nota2, nota3, media;


            //Instrução para o usuário
            Console.WriteLine("Por favor, inserir o Salário do Funcionário: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, inserir o Salário do Funcionário: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, inserir o Salário do Funcionário: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            //Operação matemática
            media = (nota1 + nota2 + nota3) / 3 ;

            //Estrutura de decisão
            if (media >= 7)
            {
                Console.WriteLine("Parabéns! Você passou.");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Atenção! Você ficou em Exame.");
            }
            else if (media < 5)
            {
                Console.WriteLine("Reprovado!");
            }

            //Resposta ao usuário
            Console.WriteLine("Sua média é {0}", media);
        }
    }
}
