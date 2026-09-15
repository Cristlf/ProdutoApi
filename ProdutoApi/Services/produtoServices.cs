using ProdutoApi.dto;
using ProdutoApi.interfaces;
using System.Security.Cryptography.X509Certificates;
namespace ProdutoApi.Services
{
    public class ProdutoServices : IProdutoService

    {
        private readonly IProdutoRepository _repository;
        public ProdutoServices(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProdutoResponseDTO> CreateProdutoAsync(ProdutoRequestDTO produtoRequestDTO)

        {  var produto = new Produto()
        {
            Nome = produtoRequestDTO.Nome,
            Preco = produtoRequestDTO.Preco,
            Quantidade = produtoRequestDTO.Quantidade,
            Ativo = produtoRequestDTO.Ativo ?? true
        };

               public async Task<bool> DeleteProdutoAsync(int produtoId)
        { 
            if (produtoId <= 0)
            {
                throw new ArgumentException("O ID do produto deve ser maior que zero.", nameof(produtoId));
            } return await _repository.DeletAsync(produtoId);


            {
            
}
