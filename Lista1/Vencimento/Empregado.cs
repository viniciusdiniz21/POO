using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Vencimento
{
    public abstract class Empregado
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string Cpf { get; set; }
        public abstract double Vencimento();
    }
}
