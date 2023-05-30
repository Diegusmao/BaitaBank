using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaitaBank.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
         public double Saldo { get; }
        public double ValorSaque { get; }

        public OperacaoFinanceiraException()
        {
            
        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base (mensagem, excecaoInterna)
        {
          

        }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }
    }
}