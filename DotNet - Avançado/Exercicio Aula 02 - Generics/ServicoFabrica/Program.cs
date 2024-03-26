using System;

interface IServico
{
    void Executar();
}

class ServicoFabrica
{
    public T NovaInstancia<T>() where T : IServico, new()
    {
        if (!typeof(T).IsInterface || !typeof(IServico).IsAssignableFrom(typeof(T)))
        {
            throw new ArgumentException("O tipo passado não é um tipo de serviço");
        }
        return new T();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fabrica = new ServicoFabrica();
        var servico = fabrica.NovaInstancia<Servico>();
        servico.Executar();