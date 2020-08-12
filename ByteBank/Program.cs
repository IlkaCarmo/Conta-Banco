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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario carlos = new Funcionario("546.879.157-20");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("565.996.741 - 20");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("bonificação referencia direto:" + roberta.GetBonificacao());

            Console.WriteLine("bonificação referencia funcionario:" + robertaTeste.GetBonificacao());


            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(carlos.GetBonificacao());


            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total bonificação:"+gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
