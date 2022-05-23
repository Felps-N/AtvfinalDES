using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;

namespace Atendimento_Hospitalar
{
    class PacienteDAO
    {
        MySqlConnection conexao;

        public PacienteDAO()
        {

            conexao = new MySqlConnection("server=localhost; database=pollinos; uid=root; password=root");

            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao se conectar ao banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void cadastrarPaciente(Paciente p)
        {
            String sql = "insert into fila (cpf, nome, idade, telefone, email, preferencial) values(@cpf, @nome, @idade, @telefone, @email, @preferencial);";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            banco = new MySqlCommand(sql, conexao);

            banco.Parameters.AddWithValue("@cpf", p.getCpf());

            banco.Parameters.AddWithValue("@nome", p.getNome());

            banco.Parameters.AddWithValue("@idade", p.getIdade());

            banco.Parameters.AddWithValue("@telefone", p.getTelefone());

            banco.Parameters.AddWithValue("@email", p.getEmail());

            banco.Parameters.AddWithValue("@preferencial", p.getPreferencial());

            try
            {
                banco.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao inserir informações no banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
            conexao.Close();
        }

        public void consultarPaciente(Paciente P)
        {
            String sql = "select * from fila order by preferencial desc;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            MySqlDataReader bancor = banco.ExecuteReader();

            while (bancor.Read())
            {
                Console.WriteLine("CPF: {0}\nNome: {1}\nIdade: {2}\nTelefone: {3}\nEmail: {4}\nPreferencia: {5}", bancor["cpf"], bancor["nome"], bancor["idade"], bancor["telefone"], bancor["email"], bancor["preferencial"]);

                Console.WriteLine(" ");

                for (int i = 3; i > 0; i--)
                {
                    Thread.Sleep(500);
                }
                Console.ReadKey();
            }
            conexao.Close();
        }

        public void atualizarPaciente(Paciente p)
        {
            conexao.Open();

            String sql = "update fila set nome=@nome, idade=@idade, telefone=@telefone, email=@email, preferencial=@preferencial where cpf=@cpf;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            banco = new MySqlCommand(sql, conexao);

            banco.Parameters.AddWithValue("@cpf", p.getCpf());

            banco.Parameters.AddWithValue("@nome", p.getNome());

            banco.Parameters.AddWithValue("@idade", p.getIdade());

            banco.Parameters.AddWithValue("@telefone", p.getTelefone());

            banco.Parameters.AddWithValue("@email", p.getEmail());

            banco.Parameters.AddWithValue("@preferencial", p.getPreferencial());

            try
            {
                banco.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao atualizar informações no banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }

            conexao.Close();
        }

        public void attconsulPaciente(Paciente P)
        {
            String sql = "select cpf from fila order by preferencial desc;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            MySqlDataReader bancor = banco.ExecuteReader();

            while (bancor.Read())
            {
                Console.WriteLine("CPF: {0}", bancor["cpf"]);
            }
            conexao.Close();
        }

        public void deletarPaciente(Paciente p)
        {
            conexao.Open();

            String sql = "delete from fila where cpf=@cpf;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            banco = new MySqlCommand(sql, conexao);

            banco.Parameters.AddWithValue("@cpf", p.getCpf());

            try
            {
                banco.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao deletar informações no banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }

            conexao.Close();
        }

        public string dltconsulPaciente(Paciente P)
        {
            string pull = "";

            String sql = "select cpf from fila order by preferencial desc;";

            MySqlCommand banco = new MySqlCommand(sql, conexao);

            MySqlDataReader bancor = banco.ExecuteReader();

            bancor.Read();

            try
            {
                Console.WriteLine("CPF: {0}", bancor["cpf"]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não há nenhum paciente cadastrado");
                Console.ReadKey();
                pull = "a";
            }

            conexao.Close();
            return pull;
        }
    }
}
