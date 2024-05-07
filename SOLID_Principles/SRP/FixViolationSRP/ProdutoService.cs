namespace SOLID_Principles.SRP.FixViolationSRP
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoService(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public string AdicionarProduto(ProdutoRequestDTO produtoRequestDTO)
        {
            var produto = new Produto
            {
                Nome = produtoRequestDTO.Nome,
                Preco = produtoRequestDTO.Preco,
                Descricao = produtoRequestDTO.Descricao,
                DataCadastro = DateTime.Now
            };

            if (!produto.Validar())
                return "Produto inválido";

            _produtoRepository.SalvarProduto(produto);

            return "Produto cadastrado com sucesso!";
        }
    }
}
