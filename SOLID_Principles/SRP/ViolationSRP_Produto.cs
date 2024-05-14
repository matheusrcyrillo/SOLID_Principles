using Microsoft.Data.SqlClient;
using System.Data;

namespace SOLID_Principles.SRP
{
    public class ViolationSRP_Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarProduto()
        {
            if (string.IsNullOrEmpty(Nome))
                return "Produto sem nome";

            if (Preco <= 0)
                return "Produto com preço inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUTO (NOME, PRECO, DESCRICAO, DATACADASTRO) VALUES (@nome, @preco, @descricao, @dataCad))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("preco", Preco);
                cmd.Parameters.AddWithValue("descricao", Descricao);
                cmd.Parameters.AddWithValue("dataCad", DataCadastro);

                cn.Open();
                
                cmd.ExecuteNonQuery();
                
                cn.Close();
            }

            return "Produto cadastrado com sucesso!";
        }
    }
}
