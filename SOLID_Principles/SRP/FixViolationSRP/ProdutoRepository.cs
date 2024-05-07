using Microsoft.Data.SqlClient;
using System.Data;

namespace SOLID_Principles.SRP.FixViolationSRP
{
    public class ProdutoRepository
    {
        public void SalvarProduto(Produto produto)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUTO (NOME, PRECO, DESCRICAO, DATACADASTRO) VALUES (@nome, @preco, @descricao, @dataCad))";

                cmd.Parameters.AddWithValue("nome", produto.Nome);
                cmd.Parameters.AddWithValue("preco", produto.Preco);
                cmd.Parameters.AddWithValue("descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("dataCad", produto.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
