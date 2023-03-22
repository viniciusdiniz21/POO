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
                    var raio = Convert.ToDouble(Console.ReadLine());
                    Circunferencia circunferencia = new Circunferencia();
                    circunferencia.Raio = raio;
                    circunferencia.CalcularPerimetro();
                    circunferencia.CalcularArea();
                    break;
                case 2:
                    Console.WriteLine("Digite o valor dos lados do Triangulo");
                    Console.WriteLine("Lado A");
                    var ladoATriangulo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lado B");
                    var ladoBTriangulo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lado C");
                    var ladoCTriangulo = Convert.ToInt32(Console.ReadLine());
                    Triangulo triangulo = new Triangulo();
                    triangulo.LadoA = ladoATriangulo;
                    triangulo.LadoB = ladoBTriangulo;
                    triangulo.LadoC = ladoCTriangulo;
                    triangulo.CalcularPerimetro();
                    triangulo.CalcularArea();

                    break;
                case 3:
                    Console.WriteLine("Digite o valor dos lados da forma quadratica");
                    Console.WriteLine("Lado A");
                    var ladoA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lado B");
                    var ladoB = Convert.ToInt32(Console.ReadLine());
                    Quadrado quadrado = new Quadrado();
                    quadrado.LadoA = ladoA;
                    quadrado.LadoB = ladoB;
                    quadrado.CalcularPerimetro();
                    quadrado.CalcularArea();
                    break;
                default:
                    Console.WriteLine("Escolha uma forma válida");
                    break;
            }
        }
    }
}
