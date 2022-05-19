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

            PacienteDAO PDAO = new PacienteDAO();

            Controle Con = new Controle();

            Console.WriteLine("Digite o que gostaria de realizar:");

            real = Console.ReadLine();

            switch (real)
            {
                case "cadastrar":
                    Con.cadastrar();
                    Con.send();
                    Con.funcao(real);
                    break;
                case "consultar":
                    Con.funcao(real);
                    break;
            }
            Console.ReadKey();
        }
    }
}
