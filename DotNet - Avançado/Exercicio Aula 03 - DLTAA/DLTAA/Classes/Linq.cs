using System;
using System.Collections.Generic;
using static DLTAA.Classes.Linq;

namespace DLTAA.Classes;
public class Linq
{
    public required string Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }


    private static List<ItemMercado> itens = new List<ItemMercado>

{

    new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.9 },
    new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.5 },
    new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.9 },
    new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.9 },
    new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.5 },
    new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7 },
    new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.4 },
    new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.7 },
    new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.2 },
    new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.6 },
    new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.4 }

};


    public static List<ItemMercado> OrdenarItensHigienePorPrecoDecrescente()
    {
        return itens
            .Where(i => i.Tipo == Tipo.Higiene)
            .OrderByDescending(i => i.Preco)
            .ToList();
    }

    public static List<ItemMercado> ItensMaiorOuIgualQue5()
    {
        return itens
            .Where(i => i.Preco >= 5)
            .OrderBy(i => i.Preco)
            .ToList();
    }

    public static List<ItemMercado> ItensComidaOuBebida()
    {
        return itens
            .Where(i => i.Tipo == Tipo.Comida || i.Tipo == Tipo.Bebida)
            .OrderBy(i => i.Nome)
            .ToList();
    }

    public static Dictionary<Tipo, int> QuantidadeItensPorTipo()
    {
        return itens
            .GroupBy(i => i.Tipo)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    public static Dictionary<Tipo, (double max, double min, double media)> PrecoItensPorTipo()
    {
        return itens
            .GroupBy(i => i.Tipo)
            .ToDictionary(
                g => g.Key,
                g =>
                {
                    var precos = g.Select(i => i.Preco).ToList();
                    return (precos.Max(), precos.Min(), precos.Average());
                });
    }

    public static void Run()
{
    Linq.ItensMaiorOuIgualQue5().ForEach(i => Console.WriteLine($"{i.Nome} - R$ {i.Preco:F2}")); 
}

}
public enum Tipo
{
    Comida,
    Bebida,
    Higiene,
    Limpeza
}

public class ItemMercado
{
    public required string  Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }

}



