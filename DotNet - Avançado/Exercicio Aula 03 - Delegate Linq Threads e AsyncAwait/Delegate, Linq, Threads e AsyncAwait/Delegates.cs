using System;
using System.Collections.Generic;


namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double> { 3, 7, 2, 4, 6 };

            List<double> novaLista = lista.ConvertAll(elemento => elemento / 2);

            novaLista.ForEach(elemento => Console.WriteLine(elemento));
        }
    }
}

