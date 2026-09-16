namespace ProdutoApi.dto
{
    public class ProdutoRequestDto
    {

        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public bool? Ativo { get; set; }
    }
}
