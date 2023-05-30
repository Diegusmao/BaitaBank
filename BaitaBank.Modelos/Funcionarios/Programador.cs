using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaitaBank.Modelos.Funcionarios
{
    public class Programador : Funcionario
    {
        public Programador(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}