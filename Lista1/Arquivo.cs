using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    public class Arquivo
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadoseArquivo()
        {
            if (!File.Exists(EnderecoNomeArquivo))
            {
                // Create the file.
                using (FileStream fs = File.Create(EnderecoNomeArquivo))
                {
                    Console.WriteLine("Digite o conteúdo do arquivo");
                    string text = Console.ReadLine();
                    Byte[] info =
                        new UTF8Encoding(true).GetBytes(text);

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    return true;
                }
            }
            using (FileStream fs = File.OpenWrite(EnderecoNomeArquivo))
            {
                Console.WriteLine("Digite o conteúdo a modificar no arquivo: ");
                string text = Console.ReadLine();
                Byte[] info =
                    new UTF8Encoding(true).GetBytes(text);

                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        public string PesquisarConteudoArquivo(string endereco)
        {
            using (StreamReader sr = File.OpenText(EnderecoNomeArquivo))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Conteudo.Concat(s);
                }
                Console.WriteLine(Conteudo);
                return Conteudo;
            }
        }
    }
}
