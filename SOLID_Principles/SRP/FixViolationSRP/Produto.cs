using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SRP.FixViolationSRP
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;

            if (Preco <= 0)
                return false;

            return true;
        }
    }
}
