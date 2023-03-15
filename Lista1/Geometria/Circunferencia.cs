using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Geometria
{
    public class Circunferencia : Forma
    {
        public double Raio { get; set; }
        public override void CalcularArea()
        {
            base.CalcularArea();
            Area = 3.1415 * Raio * Raio;
        }
        public override void CalcularPerimetro()
        {
            base.CalcularPerimetro();
            Perimetro = Convert.ToInt32(2 * 3.1415 * Raio);
        }
    }
}
