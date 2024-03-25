using System;

namespace ExercicioAula02Generics
{
    public class ContaBancaria
    {
        private double saldo;

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaBancaria(double saldoInicial)
        {
            this.saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor inválido para depósito", valor);
            }

            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor inválido para saque", valor);
            }

            if (this.saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para saque", this.saldo);
            }

            this.saldo -= valor;
        }

        public void Transferir(double valor, ContaBancaria contaDestino)
        {
            if (valor <= 0)
            {
                throw new ValorInvalidoException("Valor inválido para transferência", valor);
            }

            if (this.saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para transferência", this.saldo);
            }

            this.Sacar(valor);
            contaDestino.Depositar(valor);
        }


        public class ValorInvalidoException : Exception
        {
            public double ValorInvalido { get; }

            public ValorInvalidoException(string message, double valorInvalido) : base(message)
            {
                this.ValorInvalido = valorInvalido;
            }
        }

        public class SaldoInsuficienteException : Exception
        {
            public double SaldoDisponivel { get; }

            public SaldoInsuficienteException(string message, double saldoDisponivel) : base(message)
            {
                this.SaldoDisponivel = saldoDisponivel;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaBancaria(100);
            var conta2 = new ContaBancaria(200);

            try
            {
                conta1.Depositar(10);
                Console.WriteLine("Deposito realizado com sucesso!\n" + "Saldo: " + conta1.GetSaldo());
                conta1.Sacar(20);
                Console.WriteLine("Saque realizado com sucesso!\n" + "Saldo: " + conta1.GetSaldo());
                conta1.Transferir(30, conta2);
                Console.WriteLine("Transferência realizado com sucesso!\n" + "Saldo: " + conta1.GetSaldo());
            }
            catch (ContaBancaria.ValorInvalidoException e)
            {
                Console.WriteLine($"Erro: {e.Message} - Valor inválido: {e.ValorInvalido}");
            }
            catch (ContaBancaria.SaldoInsuficienteException e)
            {
                Console.WriteLine($"Erro: {e.Message} - Saldo disponível: {e.SaldoDisponivel}");
            }
        }
    }
}

