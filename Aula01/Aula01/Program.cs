using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter texto = new StreamWriter(@"C:\Users\PC\Desktop\Aula01.txt");
            texto.WriteLine("Atividade da Aula 01");
            texto.Close();
            Console.WriteLine("Arquivo criado com sucesso");
            

            StreamReader ler = new StreamReader(@"C:\Users\PC\Desktop\Aula01.txt", Encoding.UTF8);
            string lido = ler.ReadToEnd();
            Console.WriteLine(lido);
            Console.ReadKey();
        }
    }
}
