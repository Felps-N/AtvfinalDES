using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Menu M = new Menu();

            escolha = M.escolhamenu();
            while (escolha != "Q" || escolha != "q")
            {
                M.funcaomenu();
                escolha = M.escolhamenu();
            };
            Console.WriteLine("Programa Encerrado");
            Console.ReadKey();
        }
    }
}
