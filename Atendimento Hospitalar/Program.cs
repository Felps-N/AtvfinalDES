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
            string esc;
            Menu M = new Menu();

            do
            {
                esc = M.escolhamenu();
                M.funcaomenu();
            }while (esc != "Q" || esc != "q") ;
            Console.WriteLine("Programa Encerrado");
            Console.ReadKey();
        }
    }
}
