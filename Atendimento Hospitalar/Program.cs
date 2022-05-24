using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
                Console.Clear();
                real = Con.menu();
            } while (real.ToUpper() != "Q");
            Console.Clear();
            Console.Write("Fechando ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + "... ");
                Thread.Sleep(1000);
            }
        }
    }
}
