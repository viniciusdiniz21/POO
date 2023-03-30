using ConsoleApp1;
using Lista1;
using Lista1.Funcionarios;
using Lista1.Geometria;
using Lista1.Impressora;
using Lista1.Vencimento;

void Exercicio1()
{
    Aluno aluno = new Aluno();
    aluno.ReceberDados();
    aluno.CalcularMedia();
    aluno.CalcularNotaFinal();
}
void Exercicio2()
{
    Calculadora calculadora = new Calculadora();
    calculadora.ExecutarCalculadora();
}
void Exercicio3()
{
    Arquivo arquivo = new Arquivo();

    arquivo.EnderecoNomeArquivo = "C:\\Users\\047106\\Documents\\Arquivo\\arquivo.txt";

    arquivo.SalvarDadoseArquivo();

    arquivo.PesquisarConteudoArquivo(arquivo.EnderecoNomeArquivo);

    List<ListaAluno> lista = new List<ListaAluno>();

    Console.WriteLine("Quantos alunos deseja adicionar?");
    int lenght = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < lenght; i++)
    {
        lista[i].ReceberDados();
        lista[i].ApresentarDadosAluno();
    }
}
void Exercicio4()
{
    List<ListaAluno> listaDeAlunos = new List<ListaAluno>();
    
    Console.WriteLine("Quantos alunos deseja adicionar?");
    int qtdeAlunos = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < qtdeAlunos; i++)
    {
        ListaAluno aluno = new ListaAluno();
        aluno.ReceberDados();
        listaDeAlunos.Add(aluno);
    }
    for (int i = 0; i < listaDeAlunos.Count; i++)
    {
        listaDeAlunos[i].ApresentarDadosAluno();
    }
}
void Exercicio5()
{
    GerarForma forma = new GerarForma();

    forma.SolicitarForma();
}
void Exercicio6()
{
    Imprimir imprimir = new Imprimir();
    imprimir.SolicitarTexto();
    imprimir.EnviarImpressao();
}

void Exercicio7()
{
    void Menu()
    {
        int tipoEmpregado = 0;
        do
        {
            Console.WriteLine("O empregado é \n 1-Assalariado \n 2-Comissionado \n 3-Horista \n 4-Sair");
            tipoEmpregado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do empregado: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do empregado: ");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do empregado: ");
            var cpf = Console.ReadLine();

            switch (tipoEmpregado)
            {
                case 1:
                    Assalariado assalariado = new Assalariado();
                    assalariado.Nome = nome;
                    assalariado.Sobrenome = sobrenome;
                    assalariado.Cpf = cpf;
                    Console.WriteLine("Digite o salario do empregado: ");
                    assalariado.Salario = Convert.ToDouble(Console.ReadLine());
                    assalariado.Vencimento();
                    break;
                case 2:
                    Comissionado comissionado = new Comissionado();
                    comissionado.Nome = nome;
                    comissionado.Sobrenome = sobrenome;
                    comissionado.Cpf = cpf;
                    Console.WriteLine("Digite o total de vendas do empregado: ");
                    comissionado.TotalVenda = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a taxa de comissao do empregado: ");
                    comissionado.TaxaComissao = Convert.ToDouble(Console.ReadLine());
                    comissionado.Vencimento();
                    break;
                case 3:
                    Horista horista = new Horista();
                    horista.Nome = nome;
                    horista.Sobrenome = sobrenome;
                    horista.Cpf = cpf;
                    Console.WriteLine("Digite o valor da hora do empregado: ");
                    horista.PrecoHora = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o total de horas trabalhadas do empregado: ");
                    horista.HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                    horista.Vencimento();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        } while (tipoEmpregado != 4);
    }
    Menu();
}

void Exercicio8()
{
    Controle controle = new Controle();
    void Menu()
    {
        int opcao = 0;
        do
        {
            Console.WriteLine("3-Adicionar Funcionário \n 4-Remover Funcionário \n 3-Adicionar Dependente \n 4-Remover Dependente \n 3-Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do funcionário: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf do funcionário: ");
            var cpf = Console.ReadLine();

            switch (opcao)
            {
                case 1:
                    controle.AdicionarFuncionario();
                    break;
                case 2:
                    controle.RemoverFuncionario();
                    break;
                case 3:
                    controle.AdicionarDependente();
                    break;
                case 4:
                    controle.RemoverDependente();
                    break;
                case 5:
                    return;
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        } while (opcao != 5);
    }
    Menu();

}

//Exercicio1();
//Exercicio2();
//Exercicio3();
//Exercicio4();
//Exercicio5();
//Exercicio6();
//Exercicio7();
//Exercicio8();






