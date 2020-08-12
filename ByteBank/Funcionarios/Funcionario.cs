using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public  string Nome   { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        
        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando funcionario");

            CPF = cpf;
            TotalDeFuncionarios++;
        }
        public virtual double GetBonificacao()
        {
      
                return Salario * 0.10;
        }

    }
}
