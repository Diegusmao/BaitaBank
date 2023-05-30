using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaitaBank.Modelos
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        public static int TotalDeContasCriadas { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private double _saldo;

        //getter e setter
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {

            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            Saldo = 0;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {

            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }


            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this._saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
            Console.WriteLine("Deposito " + valor + " realizado com sucesso.\nSeu novo saldo é de: " + this._saldo);
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada", ex);
            }
            contaDestino.Depositar(valor);

        }
    }




}

