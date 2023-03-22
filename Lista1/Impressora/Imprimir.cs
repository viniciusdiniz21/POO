using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Impressora
{
    public class Imprimir
    {
        private Documento documento = new Documento();
        public void EnviarImpressao()
        {
            Impressora impressora = new Impressora(documento);
            impressora.Imprimir();
        }
        public void SolicitarTexto()
        {
            Console.WriteLine("Digite o texto que deseja imprimir: ");
            documento.texto = Console.ReadLine();
        }
    }
}
