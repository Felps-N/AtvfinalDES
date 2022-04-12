using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Hospitalar
{
    class Paciente
    {
        public double cpf;
        public string nome;
        public int idade;
        public double telefone;
        public string email;
        public string preferencial;
        public bool preferencialbool;
        
        public void cadastrar()
        {
            Console.WriteLine("-----Insira os dados do paciente para cadastro-----");
            Console.WriteLine("Insira o CPF do paciente");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do paciente");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a idade do paciente");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o telefone do paciente");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o e-mail do paciente");
            email = Console.ReadLine();
            Console.WriteLine("Insira se o paciente irá para fila preferencial");
            preferencial = Console.ReadLine();
            Console.WriteLine("--Cadastro Efetuado--");
            Console.ReadKey();
            Console.Clear();
        }

        public void preferencia()
        {
            if (preferencial == "Sim" || preferencial == "sim")
            {
                preferencialbool = true;
            }
            else
            {
                preferencialbool = false;
            }
        }

        public void novocadastrar()
        {
            Console.WriteLine("-----Insira os novos dados do paciente para recadastrar-----");
            Console.WriteLine("Insira o novo CPF do paciente");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o novo nome do paciente");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a nova idade do paciente");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o novo telefone do paciente");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o novo e-mail do paciente");
            email = Console.ReadLine();
            Console.WriteLine("Insira de novo, se o paciente irá para fila preferencial");
            preferencial = Console.ReadLine();
            Console.WriteLine("--Cadastro Efetuado--");
            Console.ReadKey();
            Console.Clear();
        }

        public void listar()
        {
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Telefone: {0}", telefone);
            Console.WriteLine("E-mail: {0}", email);
            Console.WriteLine("Preferência: {0}", preferencialbool);
        }

        public void alteracao()
        {
            Console.Write("CPF: {0}", cpf);
        }

    }
}
