using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Geometria
{
    public class Quadrado : Forma
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public override void CalcularArea()
        {
            base.CalcularArea();
            Area = LadoA * LadoB;
        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            Perimetro = (LadoA * 2) + (LadoB * 2);
        }
    }
}
