using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArquivosFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Arquivo01 = @"C:\Curso C\Testando arquivosFiles.txt";
            string CaminhoDestino = @"C:\Curso C\Testando arquivosFiles2.txt";

            try
            {
                FileInfo fileInfo= new FileInfo(Arquivo01);
                fileInfo.CopyTo(CaminhoDestino);
                string[] linhas =File.ReadAllLines(Arquivo01);
                foreach (string linhasLine in linhas)
                {
                    Console.WriteLine(linhasLine);
                }

            }
            catch (IOException e) { 
                Console.WriteLine("Um erro ocorreu!!" + e.Message);
            }
        }
    }
}
