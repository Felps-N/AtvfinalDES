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



        public void cadastrar()
        {
            Console.WriteLine("Digite o cpf:");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um telefone:");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um email:");
            email = Console.ReadLine();
            Console.WriteLine("Digite um preferencial:");
            preferencial = Console.ReadLine();
        }


        public void send()
        {
            p = new Paciente();

            p.setCpf(cpf);

            p.setNome(nome);

            p.setIdade(idade);

            p.setTelefone(telefone);

            p.setEmail(email);

            p.setPreferencial(preferencial);

        }

         public void funcao(string escolha)
        {
            PacienteDAO pDAO = new PacienteDAO();

            if (escolha == "cadastrar"){

                pDAO.cadastrarPaciente(p);

            }else if (escolha == "consultar"){

                   pDAO.consultarPaciente(p);

             }

            //}else if ($lindin == 'atualizar'){

       // $funcDao->atualizarFuncionario($func);

           // }else if ($lindin == 'deletar'){
        
       // $funcDao->deletarFuncionario($codigo);
            //}
       }

    }
}
