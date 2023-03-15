using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Geometria
{
    public class GerarForma
    {
        public void SolicitarForma()
        {
            int forma = 0;
            Console.WriteLine("Escolha a forma");
            Console.WriteLine("1- Circunferência");
            Console.WriteLine("2- Triangulo");
            Console.WriteLine("3- Quadrado");
            forma = Convert.ToInt32(Console.ReadLine());

            switch (forma)
            {
                case 1:
                    Console.WriteLine("Digite o valor do raio: ");
                    break;
                case 2:
                    Console.WriteLine("Digite o valor dos lados do Triangulo");
                    Console.WriteLine("Lado A");
                    Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lado B");
                    Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Lado C");
                    Convert.ToDouble(Console.ReadLine());

                    break;
                case 3:
                    Console.WriteLine("Digite o valor dos lados do Quadrado");
                    Console.WriteLine("Lado A");
                    var ladoA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lado B");
                    Convert.ToDouble(Console.ReadLine());
                    var ladoB = Convert.ToInt32(Console.ReadLine());
                    Quadrado quadrado = new Quadrado();
                    quadrado.LadoA = ladoA;
                    quadrado.LadoB = ladoB;
                    quadrado.CalcularPerimetro();
                    Console.WriteLine(quadrado.Perimetro);
                    break;
                default:
                    Console.WriteLine("Escolha uma forma válida");
                    break;
            }
        }
    }
}
