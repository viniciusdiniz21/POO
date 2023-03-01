using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaAluno
    {
        public string RA;
        public string Nome;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        public decimal NotaFinal;

        public void CalcularMedia()
        {
            decimal soma = NotaProva + NotaTrabalho;
            decimal media = soma / 2;
            Console.WriteLine($"{media}");
        }
        public void CalcularNotaFinal()
        {
            NotaFinal = NotaProva + NotaTrabalho;
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota Final: {NotaFinal}");
        }
        public void ReceberDados()
        {
            Console.WriteLine("Digite o RA");
            RA = Console.ReadLine();
            Console.WriteLine("Digite o Nome");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a Nota da prova");
            NotaProva = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a Nota do Trabalho");
            NotaTrabalho = Convert.ToDecimal(Console.ReadLine());

        }
        public void ApresentarDadosAluno()
        {
            Console.WriteLine(RA);
            Console.WriteLine(Nome);
        }

    }
}
