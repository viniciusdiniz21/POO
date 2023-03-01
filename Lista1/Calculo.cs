using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    public class Calculo
    {
        private double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public double RetornaMaior()
        {
            var maior = ValorA > ValorB ? ValorA : ValorB;
            return maior;
        }
        public double SomarGeral(double valor)
        {
            return ValorA + ValorB + valor;
        }

        public double ImprimirResultado()
        {
            Console.WriteLine(Resultado);
            return Resultado;
        }
    }
}
