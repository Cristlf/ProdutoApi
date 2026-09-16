using ProdutoApi.dto;
using ProdutoApi.interfaces;
using System.Security.Cryptography.X509Certificates;
namespace ProdutoApi.Services
    using ProdutoApi.models;
{
    public class ProdutoServices : IProdutoService

    {
        private readonly IProdutoRepository _repository;
        public ProdutoServices(IProdutoRepository repository)
        {
            _repository = repository;
        }

       public async Task<ProdutoResponseDto> CreatProdutoAsync(ProdutoRequestDto produtoRequest)>
        {
        var produto = new Produto
        { 
            Nome = produtoRequest.Nome,
            Preco = produtoRequest.Preco,
            Quantidade = produtoRequest.Quantidade,
            Ativo = produtoRequest.Ativo ?? true
        };
       



