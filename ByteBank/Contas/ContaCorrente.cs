using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set 
            { 
                if (value >0)
                {
                    numeroAgencia = value;
                }
            }

        }
        public string Conta { get; private set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }

        public ContaCorrente(int numeroAgencia, string conta, Cliente titular)
        {
            this.numeroAgencia=numeroAgencia;
            Conta = conta;
            Titular = titular;
            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine("Saldo em conta pós saque: " + Saldo);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
            }
        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                destino.Depositar(valor);
                return true;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Número da agência: " + numeroAgencia);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Titular: " + Titular.Nome);
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
}
