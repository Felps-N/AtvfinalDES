using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Menu
    {
        public string escolha;

        public void escolhamenu()
        {
            Console.WriteLine("Escolha uma das opcções abaixo para o sistema");
            Console.WriteLine("C - Cadastrar Paciente");
            Console.WriteLine("L - Listar Pacientes");
            Console.WriteLine("A - Alterar Dados dos Paciente");
            Console.WriteLine("T - Atender Paciente");
            Console.WriteLine("Q - Encerrar Programa");
            escolha = Console.ReadLine();
            Console.Clear();
        }

        public void funcaomenu()
        {
            Paciente[] P = new Paciente[10];
            do
                if (escolha == "C" || escolha == "c")
                {
                    
                }
                else if (escolha == "L" || escolha == "l")
                {
                    Console.WriteLine("-----Lista dos Pacientes-----");
                    for (int i = 0; i < 2; i++)
                    {
                        P[i].listar();
                        Console.WriteLine("    ");
                    }
                    Console.ReadKey();
                }
            while (escolha != "Q" || escolha != "q");
            Console.WriteLine("Programa Encerrado");
        }
    }
}
