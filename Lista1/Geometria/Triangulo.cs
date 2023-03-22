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
            void CalcularAreaTrianguloEscaleno()
            {
                double s = (LadoA + LadoB + LadoC) / 2;
                Area = Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            }
            void CalcularAreaTrianguloIsosceles()
            {
                double baseTriangulo = Math.Max(Math.Max(LadoA, LadoB), LadoC);
                double alturaTriangulo = Math.Sqrt((LadoB * LadoB) - ((baseTriangulo * baseTriangulo) / 4));
                Area = (baseTriangulo * alturaTriangulo) / 2;
            }
            void CalcularAreaTrianguloEquilatero()
            {
                Area = (Math.Pow(LadoA, 2) * Math.Sqrt(3)) / 4;
            }
            base.CalcularArea();
            string VerificarTipoTriangulo(int lado1, int lado2, int lado3)
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
            Console.WriteLine(tipo);
            switch (tipo)
            {
                case "equilatero":
                    CalcularAreaTrianguloEquilatero();
                    break;
                case "isosceles":
                    CalcularAreaTrianguloIsosceles();
                    break;
                case "escaleno":
                    CalcularAreaTrianguloEscaleno();
                    break;
                default:
                    Console.WriteLine("Triangulo de proporções inválidas!");
                    break;
            }
            Console.WriteLine($"Área: {Area}");

        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            Perimetro = LadoA + LadoB + LadoC;
            Console.WriteLine($"Perimetro: {Perimetro}");
        }
    }
}
