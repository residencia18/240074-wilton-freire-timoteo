using System;
using System.Threading.Tasks;

namespace DLTAA.Classes
{
    class AsyncAwait
    {
        public static async Task Run()
        {
            Task tarefa1 = DoWorkAsync("Tarefa 1", 3, 500);
            Task tarefa2 = DoWorkAsync("Tarefa 2", 5, 1000);

            await Task.WhenAll(tarefa1, tarefa2);

            Console.WriteLine("Ambas as tarefas foram concluídas.");
        }

        static async Task DoWorkAsync(string nome, int numeroDeIteracoes, int milisegundos)
        {
            for (int i = 1; i <= numeroDeIteracoes; i++)
            {
                Console.WriteLine($"{nome} está em andamento (iteração {i}/{numeroDeIteracoes})");
                await Task.Delay(milisegundos);
            }
            
        }
        
    }
}
