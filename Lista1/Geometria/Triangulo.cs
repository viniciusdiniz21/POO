using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Geometria
{
    public class Triangulo : Forma
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }
        public override void CalcularArea()
        {
            base.CalcularArea();
            string VerificarTipoTriangulo(double lado1, double lado2, double lado3)
            {
                if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
                {
                    return "Medidas inválidas. Todos os lados do triângulo devem ser maiores que zero.";
                }
                else if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
                {
                    return "As medidas informadas não formam um triângulo.";
                }
                else if (lado1 == lado2 && lado2 == lado3)
                {
                    return "equilatero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    return "isosceles";
                }
                else
                {
                    return "escaleno";
                }
            }
            var tipo = VerificarTipoTriangulo(LadoA, LadoB, LadoC);
            switch (tipo)
            {
                case "equilatero":
                    break;
                case "isosceles":
                    break;
                case "escaleno":
                    break;
                default:
                    Console.WriteLine("Triangulo de proporções inválidas!");
                    break;
            }

        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            Perimetro = LadoA + LadoB + LadoC;
        }
    }
}
