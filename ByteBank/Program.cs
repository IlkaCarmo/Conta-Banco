using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.22.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.33.254-69");
            pedro.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("485.65.897-21");
            pedro.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("985.44.744-23");
            pedro.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês" + gerenciadorBonificacao.GetTotalBonificacao());


        }

    }
}
