using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Controle
    {

        string pull;
        string real;
        string ac;
        Paciente p;
        PacienteDAO pDAO;

        public string menu()
        {
            pDAO = new PacienteDAO();
            p = new Paciente();
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
                    p.cadastrar();
                    pDAO.cadastrarPaciente(p);
                    Console.Clear();
                    break;
                case "S":
                    Console.Clear();
                    pDAO.consultarPaciente(p, ac = "s");
                    Console.Clear();
                    break;
                case "U":
                    Console.Clear();
                    Console.WriteLine("CPFs de pacientes cadastrados:");
                    pDAO.consultarPaciente(p, ac = "upd");
                    p.atualizar();
                    pDAO.atualizarPaciente(p);
                    Console.Clear();
                    break;
                case "D":
                     Console.Clear();
                     Console.WriteLine("CPF do paciente:");
                     pull = pDAO.consultarPaciente(p, ac = "del");
                    if (pull != "a")
                     {
                         p.deletar();
                         pDAO.deletarPaciente(p);
                     }
                     Console.Clear();
                     break;
                }
            return real;
        } 

            
       }

    }
