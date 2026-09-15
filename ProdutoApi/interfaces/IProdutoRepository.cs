using ProdutoApi.models;

namespace ProdutoApi.interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllAsync();
        Task<Produto?> GetByIdasync(int Id);
        Task<Produto> CreatAsync(Produto produto);
        Task<Produto> UpdteAsync(Produto produto);
        Task<bool> DeletAsync(int id);
    }
}