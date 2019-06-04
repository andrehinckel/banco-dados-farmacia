using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class ComestivelRepository
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65970\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Comestivel> ObterTodos()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM comestiveis";

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            List<Comestivel> comestiveis = new List<Comestivel>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(row["id"]);
                comestivel.Nome = row["nome"].ToString();
                comestivel.Valor = Convert.ToDecimal(row["valor"]);
                comestivel.DataVencimento = Convert.ToDateTime(row["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(row["quantidade"]);
                comestivel.Marca = row["marca"].ToString();
                comestiveis.Add(comestivel);
            }
            connection.Close();
            return comestiveis;
        }

        public Comestivel ObterPeloID(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM comestiveis WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            connection.Close();
            if(table.Rows.Count  == 1)
            {
                DataRow row = table.Rows[0];
                Comestivel comestivel = new Comestivel();
                comestivel.Id = Convert.ToInt32(row["id"]);
                comestivel.Nome = row["nome"].ToString();
                comestivel.Valor = Convert.ToDecimal(row["valor"]);
                comestivel.DataVencimento = Convert.ToDateTime(row["data_vencimento"]);
                comestivel.Quantidade = Convert.ToInt32(row["quantidade"]);
                comestivel.Marca = row["marca"].ToString();
                return comestivel;
            }
            return null;
        }

        public void Inserir(Comestivel comestivel)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO comestiveis(nome, valor, data_vencimento, quantidade, marca) VALUES (@NOME, @VALOR, @DATA_VENCIMENTO, @QUANTIDADE, @MARCA)";
            command.Parameters.AddWithValue("@NOME", comestivel.Nome);
            command.Parameters.AddWithValue("@VALOR", comestivel.Valor);
            command.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            command.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            command.Parameters.AddWithValue("@MARCA", comestivel.Marca);
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
            command.CommandText = "DELETE FROM comestiveis WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Comestivel comestivel)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE comestiveis SET nome = @NOME, valor = @VALOR, data_vencimento = @DATA_VENCIMENTO, quantidade = @QUANTIDADE, marca = @MARCA WHERE id = @ID";
            command.Parameters.AddWithValue("@NOME", comestivel.Nome);
            command.Parameters.AddWithValue("@VALOR", comestivel.Valor;
            command.Parameters.AddWithValue("@DATA_VENCIMENTO", comestivel.DataVencimento);
            command.Parameters.AddWithValue("@QUANTIDADE", comestivel.Quantidade);
            command.Parameters.AddWithValue("@MARCA", comestivel.Marca);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
