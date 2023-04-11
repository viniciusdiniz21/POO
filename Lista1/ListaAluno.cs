using Lista1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaAluno : Aluno
    {
        
        public void ApresentarDadosAluno()
        {
            Console.WriteLine($"RA: {RA}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"NotaProva: {NotaProva}");
            Console.WriteLine($"NotaTrabalho: {NotaTrabalho}");
            Console.WriteLine($"NotaFinal: {NotaFinal}");
        }

    }
}
