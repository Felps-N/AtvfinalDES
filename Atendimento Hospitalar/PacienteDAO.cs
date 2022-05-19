using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Atendimento_Hospitalar
{
    class PacienteDAO
    {
        MySqlConnection conexao;

        public PacienteDAO()
        {

            conexao = new MySqlConnection("server=localhost; database=pollinos; uid=root; password=root");

            conexao.Open();
        }

        public void cadastrarPaciente(Paciente p)
        {
            String sql = "insert into fila values(@cpf, @nome, @idade, @telefone, @email, @preferencial);";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            banco = new MySqlCommand(sql, conexao);

            banco.Parameters.AddWithValue("@cpf", p.getCpf());

            banco.Parameters.AddWithValue("@nome", p.getNome());

            banco.Parameters.AddWithValue("@idade", p.getIdade());

            banco.Parameters.AddWithValue("@telefone", p.getTelefone());

            banco.Parameters.AddWithValue("@email", p.getEmail());

            banco.Parameters.AddWithValue("@preferencial", p.getPreferencial());

            banco.ExecuteNonQuery();

            conexao.Close();
        }

        public void consultarPaciente(Paciente P)
        {
            String sql = "select * from fila;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            MySqlDataReader bancor = banco.ExecuteReader();

            while (bancor.Read())
            {
                Console.WriteLine("CPF: {0}\nNome: {1}\nIdade: {2}\nTelefone: {3}\nEmail: {4}\nPreferencia: {5}", bancor["cpf"], bancor["nome"], bancor["idade"], bancor["telefone"], bancor["email"], bancor["preferencial"]);

                Console.WriteLine(" ");

                Console.ReadKey();
            }
            conexao.Close();
            Console.ReadKey();
        }
    }
}
