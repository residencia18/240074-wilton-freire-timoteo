using System;
using System.Collections.Generic;

namespace DLTAA.Classes
{
    public class Delegates
    {
        public static void Run()
        {
            var lista = new List<double> { 3, 7, 2, 4, 6 };

            var listaTransformada = lista.ConvertAll(elemento => elemento / 2);

            listaTransformada.ForEach(elemento => Console.WriteLine($"{elemento} "));
        }
    }
}

