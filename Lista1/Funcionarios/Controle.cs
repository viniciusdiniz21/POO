using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1.Funcionarios
{
    public class Controle : Funcionario
    {
        public List<Funcionario> Funcionarios { get; set; }
        public void AdicionarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite o nome do funcionario: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do funcionario: ");
            var cpf = Console.ReadLine();
            foreach (var fun in Funcionarios)
            {
                if (fun.Cpf == cpf)
                {
                    Console.WriteLine("CPF já registrado");
                    return;
                }
            }
            funcionario.Nome = nome;
            funcionario.Cpf = cpf;
            Funcionarios.Add(funcionario);
        }
        public void RemoverFuncionario()
        {
            Console.WriteLine("Digite o cpf do funcionario");
            var cpf = Console.ReadLine();
            Funcionarios.RemoveAll(fun => fun.Cpf == cpf);
        }
        public void AdicionarDependente()
        {
            Console.WriteLine("Digite o cpf do funcionario em que deseja adicionar o dependente\n");
            var cpfFuncionario = Console.ReadLine();

            var funcionario = Funcionarios.Find(fun => fun.Cpf == cpfFuncionario);
            Dependente dependente = new Dependente();
            Console.WriteLine("Digite o nome do dependente: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do dependente: ");
            var cpf = Console.ReadLine();
            foreach(var dep in funcionario.Dependentes)
            {
                if(dep.Cpf == cpf)
                {
                    Console.WriteLine("CPF já registrado");
                    return;
                }
            }
            dependente.Nome = nome;
            dependente.Cpf = cpf;

            funcionario.Dependentes.Add(dependente);
        }
        public void RemoverDependente()
        {
            Console.WriteLine("Digite o cpf do funcionario em que deseja remover o dependente\n");
            var cpfFuncionario = Console.ReadLine();

            var funcionario = Funcionarios.Find(fun => fun.Cpf == cpfFuncionario);

            Console.WriteLine("Digite o cpf do dependente");
            var cpf = Console.ReadLine();
            funcionario.Dependentes.RemoveAll(dep => dep.Cpf == cpf);
        }
    }
}
