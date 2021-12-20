/* FILESTREAM E STREAMREADER */

using System;
using System.IO;

namespace Aula187_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt"; // Caminho do arquivo desejado
            // FileStream fs = null; // Variavel tipo FileStream de valor nulo
            StreamReader sr = null; // Variavel tipo StreamReader de valor nulo
            try
            {
                // fs = new FileStream(path, FileMode.Open); // Abre o arquivo do caminho informado
                // sr = new StreamReader(fs); // Le o arquivo (podemos colocar linhas de comando no arquivo)
                sr = File.OpenText(path); // Instancia o FileStream e o StreamReader automaticamente
                while (!sr.EndOfStream) // Enquanto nao chegar ao final da Stream
                {
                    string line = sr.ReadLine(); // Le a primeira linha do arquivo
                    Console.WriteLine(line); // Exibe o que foi obtido com a leitura acima
                }

                // string line = sr.ReadLine(); // Le a primeira linha do arquivo
                // Console.WriteLine(line); // Exibe o que foi obtido com a leitura acima
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); // Fecha o StreamReader
                // if (fs != null) fs.Close(); // Fecha o FileStream
            }
        }
    }
}
