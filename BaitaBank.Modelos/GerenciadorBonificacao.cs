using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaitaBank.Modelos.Funcionarios;

namespace BaitaBank.Modelos
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}