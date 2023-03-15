using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Geometria
{
    public abstract class Forma : GerarForma
    {
        public double Area { get; set; }
        public int Perimetro { get; set; }

        public virtual void CalcularArea()
        {
        }
        public virtual void CalcularPerimetro()
        {
        }
    }
}
