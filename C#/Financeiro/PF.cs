using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.C_.Financeiro
{
    public class PF : Cliente
    {
        public PF(string codigo, string nome) : base(codigo, nome)
        {
        }
        public override decimal DescontarTaxa(decimal valor)
        {
            return valor - 1;
        }
    }
}
