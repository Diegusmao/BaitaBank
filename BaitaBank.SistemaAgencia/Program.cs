using BaitaBank.Modelos;
using BaitaBank.Modelos.Funcionarios;
using Humanizer;

namespace BaitaBank.SistemaAgencias
{
    class Program
    {
        private static void Main(string[] args)
        {

            DateTime dataFimPagamento = new DateTime(2018, 6, 20);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(40); //dataFimPagfamento - dataCorrente;

            string mensagem = "vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);


           // ContaCorrente conta = new ContaCorrente(847,987234);

            //Funcionario funcionario = null;


            Console.ReadLine();

        }
    }
}