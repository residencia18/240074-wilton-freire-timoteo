using System;

namespace Exercicio
{
    enum Exercicio
    {
        Academia = 1,
        Luta = 2,
        Corrida = 3,
        Sair = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios:");
            foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
            {
                Console.WriteLine($"{Convert.ToInt32(exercicio)} - {exercicio}");
            }

            Console.Write("Escolha um exercício: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine());

            Exercicio exercicioEscolhido = (Exercicio)opcaoEscolhida;

            Console.WriteLine($"Você escolheu: {exercicioEscolhido}");

            while (exercicioEscolhido != Exercicio.Sair)
            {
                Console.WriteLine("Escolha um exercício:");
                foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
                {
                    Console.WriteLine($"{Convert.ToInt32(exercicio)} - {exercicio}");
                }

                Console.Write("Escolha um exercício: ");
                opcaoEscolhida = int.Parse(Console.ReadLine());

                exercicioEscolhido = (Exercicio)opcaoEscolhida;

                Console.WriteLine($"Você escolheu: {exercicioEscolhido}");
            }


        }
    }
}



