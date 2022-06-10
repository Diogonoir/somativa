using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_funcionario
{
    internal class funcionarios
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public double imposto { get; set; }
        public double aumento { get; set; }


        public double liq()
        {
            return (salario - imposto);
        }

        public double Porcentagem()
        {
            return (aumento / 100) * liq();
        }
    }
}