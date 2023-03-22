using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Impressora
{
    public class Impressora
    {
        public int qtdeCopia { get; set; }
        private readonly Documento documento;

        public Impressora(Documento documento)
        {
            qtdeCopia = 1;
            this.documento = documento;
        }
        public void Imprimir()
        {
            for (int i = 0; i < qtdeCopia; i++)
            {
                Console.WriteLine(documento.texto);
            }
        }
    }
}
