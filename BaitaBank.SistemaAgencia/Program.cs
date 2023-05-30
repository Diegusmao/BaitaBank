using BaitaBank.Modelos;
using BaitaBank.Modelos.Funcionarios;

namespace BaitaBank.SistemaAgencias
{
    class Program
    {
        private static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847,987234);

            Funcionario funcionario = null;

            Console.WriteLine("funcionou");

            Console.ReadLine();

        }
    }
}