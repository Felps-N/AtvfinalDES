using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Atendimento_Hospitalar
{
    class Paciente
    {
        private double cpf;
        private string nome;
        private int idade;
        private double telefone;
        private string email;
        private string preferencial;

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
            Console.Write("Cadastrado ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + "... ");
                Thread.Sleep(1000);
            }
        }

        public void atualizar()
        {
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
            Console.Write("Atualizado ");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i+"... ");
                Thread.Sleep(1000);
            }


        }

        public void deletar()
        {
                Console.WriteLine("Insira o cpf do paciente que será deletado:");
                cpf = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("Deletado ");
                for (int i = 3; i > 0; i--)
                {
                   Console.Write(i + "... ");
                  Thread.Sleep(1000);
                }
        }

        public double getCpf()
        {
            return this.cpf;
        }

        

        public string getNome()
        {
            return this.nome;
        }

        

        public double getIdade()
        {
            return this.idade;
        }

       

        public double getTelefone()
        {
            return this.telefone;
        }

       

        public string getEmail()
        {
            return this.email;
        }

       

        public string getPreferencial()
        {
            return this.preferencial;
        }

        

    }

}
