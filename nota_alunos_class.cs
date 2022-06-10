using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresNotasdosAlunos
{
    internal class notass
    {
        public double nota { get; set; }
        public double notb { get; set; }

        public double notc { get; set; }

        public double final()
        {
            return (nota + notb + notc);
        }

    }
}
