using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            // CalcularBonificacao();
            UsarSistema();


            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            Diretor roberta = new Diretor("159.33.254-69");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("985.44.744-23");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            sistemaInterno.Logar(parceiro, "12345");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.22.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.33.254-69");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("485.65.897-21");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("985.44.744-23");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("465.454.848-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);


            Console.WriteLine("Total de bonificações do mês" + gerenciadorBonificacao.GetTotalBonificacao());


        }

    }
}
