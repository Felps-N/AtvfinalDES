using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double getCpf()
        {
            return this.cpf;
        }

        public void setCpf(double cpf)
        {
            this.cpf = cpf;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public double getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public double getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(double telefone)
        {
            this.telefone = telefone;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPreferencial()
        {
            return this.preferencial;
        }

        public void setPreferencial(string preferencial)
        {
            this.preferencial = preferencial;
        }

    }

}
