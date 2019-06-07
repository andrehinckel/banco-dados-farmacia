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
    public class ProdutoHigienicoRepository
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\65970\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        public List<ProdutoHigienico> ObterTodos()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM produtos_higienicos";

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());

            List<ProdutoHigienico> produtosHigienicos = new List<ProdutoHigienico>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(row["id"]);
                produtoHigienico.Nome = row["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(row["preco"]);
                produtoHigienico.Categoria = row["categoria"].ToString();
                produtosHigienicos.Add(produtoHigienico);
            }
            connection.Close();
            return produtosHigienicos;
        }

        public ProdutoHigienico ObterPeloID(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM produtos_higienicos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            connection.Close();
            if(table.Rows.Count == 1)
            {
                DataRow row = table.Rows[0];
                ProdutoHigienico produtoHigienico = new ProdutoHigienico();
                produtoHigienico.Id = Convert.ToInt32(row["id"]);
                produtoHigienico.Nome = row["nome"].ToString();
                produtoHigienico.Preco = Convert.ToDecimal(row["preco"]);
                produtoHigienico.Categoria = row["categoria"].ToString();
                return produtoHigienico;
            }
            return null;
        }

        public void Inserir(ProdutoHigienico produtoHigienico)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO produtos_higienicos (nome, preco, categoria) VALUES (@NOME, @PRECO, @CATEGORIA)";
            command.Parameters.AddWithValue("@NOME", produtoHigienico.Nome);
            command.Parameters.AddWithValue("@PRECO", produtoHigienico.Preco);
            command.Parameters.AddWithValue("@CATEGORIA", produtoHigienico.Categoria);
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
            command.CommandText = "DELETE FROM produtos_higienicos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(ProdutoHigienico produtoHigienico)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = CadeiaDeConexao;
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE produtos_higienicos SET nome = @NOME,
preco = @PRECO, categoria = @CATEGORIA WHERE id = @ID";
            command.Parameters.AddWithValue("@NOME", produtoHigienico.Nome);
            command.Parameters.AddWithValue("@PRECO", produtoHigienico.Preco);
            command.Parameters.AddWithValue("@CATEGORIA", produtoHigienico.Categoria);
            command.Parameters.AddWithValue("@ID", produtoHigienico.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
