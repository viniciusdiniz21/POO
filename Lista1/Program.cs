using ConsoleApp1;
using Lista1;
using Lista1.Geometria;
using Lista1.Impressora;

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

//Exercicio1();
//Exercicio2();
//Exercicio3();
//Exercicio4();
//Exercicio5();
//Exercicio6();






