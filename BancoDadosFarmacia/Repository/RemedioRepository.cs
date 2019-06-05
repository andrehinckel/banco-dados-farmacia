using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class RemedioRepository
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65970\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";


        public List<Remedio> ObterTodos()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM remedios";

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            List<Remedio> remedios = new List<Remedio>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(row["id"]);
                remedio.Nome = row["nome"].ToString();
                remedio.Categoria = row["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(row["solido]");
                remedio.ContraIndicacoes = row["contra_indicacoes"].ToString();
                remedio.Bula = row["bula"].ToString();
                remedio.Faixa = row["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(row["precisa_receita"]);
            }
            connection.Close();
            return remedios;

        }

        public Remedio ObterPeloId(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM remedios WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            connection.Close();
            if(table.Rows.Count == 1)
            {
                DataRow row = table.Rows[i];
                Remedio remedio = new Remedio();
                remedio.Id = Convert.ToInt32(row["id"]);
                remedio.Nome = row["nome"].ToString();
                remedio.Categoria = row["categoria"].ToString();
                remedio.Solido = Convert.ToBoolean(row["solido"].ToString());
                remedio.ContraIndicacoes = row["contra_indicacoes"].ToString();
                remedio.Bula = row["bula"].ToString();
                remedio.Faixa = row["faixa"].ToString();
                remedio.PrecisaReceita = Convert.ToBoolean(row["precisa_receita"]);
                return remedio;
            }
            return null;
        }

        public void Inserir(Remedio remedio)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO remedios (nome, categoria, solido
contra_indicacoes, bula, faixa, precisa_receita) VALUES (@NOME, @CATEGORIA, @SOLIDO
@CONTRA_INDICACOES, @BULA, @FAIXA, @PRECISA_RECEITA";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "DELETE FROM remedios WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Remedio remedio)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE remedios SET nome = @ID, categoria = @CATEGORIA,
solido = @SOLIDO, contra_indicacoes = @CONTRA_INDICACOES, bula = @BULA, faixa = @FAIXA,
precisa_receita = @PRECISA_RECEITA";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
