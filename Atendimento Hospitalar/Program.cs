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
            string real, pull;

            Controle Con = new Controle();

            do
            {
                PacienteDAO PDAO = new PacienteDAO();
                Console.WriteLine("Digite o que gostaria de realizar:");
                Console.WriteLine("I - Cadastrar");
                Console.WriteLine("S - Consultar");
                Console.WriteLine("U - Atualizar");
                Console.WriteLine("D - Deletar");
                Console.WriteLine("Q - Fechar");

                real = Console.ReadLine();

                switch (real.ToUpper())
                {
                    case "I":
                        Console.Clear();
                        Con.cadastrar();
                        Con.set();
                        Con.funcao(real.ToUpper());
                        Console.Clear();
                        break;
                    case "S":
                        Console.Clear();
                        Con.funcao(real.ToUpper());
                        Console.Clear();
                        break;
                    case "U":
                        Console.Clear();
                        Con.atualizar();
                        Con.set();
                        Con.funcao(real.ToUpper());
                        Console.Clear();
                        break;
                    case "D":
                        Console.Clear();
                        pull = Con.deletar();
                        if (pull != "a")
                        {
                            Con.set();
                            Con.funcao(real.ToUpper());
                        }

                        Console.Clear();
                        break;

                }
            } while (real.ToUpper() != "Q");
            Console.Clear();
            Console.WriteLine("Fechado");
            Console.ReadKey();

        }
    }
}
