using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Vencimento
{
    public class Comissionado : Empregado
    {
        public double TotalVenda { get; set; }
        public double TaxaComissao { get; set; }
        public override double Vencimento()
        {
            return (TotalVenda * TaxaComissao) / 100;
        }
    }
}
