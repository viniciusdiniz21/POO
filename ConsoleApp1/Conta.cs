using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Conta
    {
        public string? Nome;
        public string? NumeroConta;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
