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
            string real;
            Controle Con = new Controle();

            do
            {
                real = Con.menu();
            } while (real.ToUpper() != "Q");
            Console.Clear();
            Console.WriteLine("Fechado");
            Console.ReadKey();

        }
    }
}
