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
                    for (int i=0; i<3; i++)
                    {
                        P[i] = new Paciente();
                    }
                   
                    if (P[0].nome != "")
                    {
                        P[0] = new Paciente();
                        P[0].cadastrar();
                        P[0].preferencia();
                    }
                    else if (P[1].nome != "")
                    {
                        P[1] = new Paciente();
                        P[1].cadastrar();
                        P[1].preferencia();
                    }
                    else if (P[2].nome != "")
                    {
                        P[2] = new Paciente();
                        P[2].cadastrar();
                        P[2].preferencia();
                    }
                    else if (P[3].nome == "")
                    {

                    }
                    else if (P[4].nome == "")
                    {

                    }
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
