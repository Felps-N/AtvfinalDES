using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Controle
    {

        private double cpf;
        private string nome;
        private int idade;
        private double telefone;
        private string email;
        private string preferencial;
        Paciente p;
        PacienteDAO pDAO = new PacienteDAO();



        public void cadastrar()
        {
            Console.WriteLine("Digite o cpf:");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o telefone:");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email:");
            email = Console.ReadLine();
            Console.WriteLine("Digite se é preferencial(s/n):");
            preferencial = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cadastrado");
            Console.ReadKey();
        }


        public void set()
        {
            p = new Paciente();

            p.setCpf(cpf);

            p.setNome(nome);

            p.setIdade(idade);

            p.setTelefone(telefone);

            p.setEmail(email);

            p.setPreferencial(preferencial);

        }

        public void atualizar()
        {
            pDAO = new PacienteDAO();
            Console.WriteLine("CPFs de pacientes cadastrados:");
            pDAO.attconsulPaciente(p);
            Console.WriteLine("Digite o cpf do paciente que será modificado:");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Atualize o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Atualize a idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Atualize o telefone:");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Atualize o email:");
            email = Console.ReadLine();
            Console.WriteLine("Atualize se é preferencial(s/n):");
            preferencial = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Atualizado");
            Console.ReadKey();

        }

        public string deletar()
        {
            string pull;
            pDAO = new PacienteDAO();
            Console.WriteLine("CPF do paciente:");
            pull = pDAO.dltconsulPaciente(p);
            if (pull != "a")
            {
                Console.WriteLine("Insira o cpf do paciente que será deletado:");
                cpf = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Deletado");
                Console.ReadKey();
            }
            return pull;
            
        }

        public void funcao(string escolha)
        {
            pDAO = new PacienteDAO();

            if (escolha == "I"){

                pDAO.cadastrarPaciente(p);

            }else if (escolha == "S"){

                pDAO.consultarPaciente(p);

            }else if (escolha == "U"){

                pDAO.atualizarPaciente(p);

            }else if (escolha == "D"){

                pDAO.deletarPaciente(p);
            }
       }

    }
}
