using ConsoleApp1;
using Lista1;
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
                    Console.WriteLine("Digite o salario do empregado: ");
                    assalariado.Salario = Convert.ToDouble(Console.ReadLine());
                    assalariado.Vencimento();
                    break;
                case 2:
                    Comissionado comissionado = new Comissionado();
                    Console.WriteLine("Digite o total de vendas do empregado: ");
                    comissionado.TotalVenda = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a taxa de comissao do empregado: ");
                    comissionado.TaxaComissao = Convert.ToDouble(Console.ReadLine());
                    comissionado.Vencimento();
                    break;
                case 3:
                    Horista horista = new Horista();
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
        Menu();
    }
}

//Exercicio1();
//Exercicio2();
//Exercicio3();
//Exercicio4();
//Exercicio5();
//Exercicio6();






