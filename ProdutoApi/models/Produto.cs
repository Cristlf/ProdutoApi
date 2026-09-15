namespace ProdutoApi.models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool Ativo { get; set; }
    }
}
