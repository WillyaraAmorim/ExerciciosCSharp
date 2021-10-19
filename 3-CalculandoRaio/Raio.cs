using System;

namespace _3_CalculandoRaio
{
    public class Raio
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Raio! (Mas não é o que cai do céu)");

            //Declarando as variáveis
            double Volume;
            double Raio;
            double Pi;
            Pi = 3.14;

            //Instrução para o usuário
            Console.WriteLine("Por favor, inserir o valor do Raio da Esfera ");
            Raio = Convert.ToDouble(Console.ReadLine());

            //Operação matemática
            Volume = (4/3*Pi)*(Raio*Raio*Raio);

            //Resposta ao usuário
            Console.WriteLine("O volume da esfera é de: {0}", Volume);
        }
    }
}
