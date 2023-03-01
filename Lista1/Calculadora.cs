using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    public class Calculadora : Calculo
    {
        public void LerValores()
        {
            Console.WriteLine("Digite o valor A");
            ValorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor B");
            ValorB = Convert.ToDouble(Console.ReadLine());
        }
        public void ExecutarCalculadora()
        {
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Mostrar Maior");
            Console.WriteLine("5 - Imprimir Resultado");
            Console.WriteLine("0 - Sair");

            int valor = Convert.ToInt32(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    LerValores();
                    CalcularSoma();
                    break;
                case 2:
                    LerValores();
                    CalcularSubtracao();
                    break;
                case 3:
                    LerValores();
                    CalcularMultiplicacao();
                    break;
                case 4:
                    LerValores();
                    RetornaMaior();
                    break;
                case 5:
                    LerValores();
                    Console.WriteLine("Digite um valor: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    SomarGeral(value);
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Digite um valor correto");
                    break;

            }

        }
    }
}
