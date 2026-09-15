using ProdutoApi.dto;
namespace ProdutoApi. interfaces
{
    public interface IProdutoService
    {
    Task<IEnumerable<ProdutoResponseDTO>> GetAllAsync();
        Task<ProdutoResponseDTO?> GetByIdAsync(int produtosId);
        Task<ProdutoResponseDTO> CreateAsync(ProdutoRequestDTO produtoRequestDTO);
        Task<ProdutoResponseDTO> UpdateAsync(int produtosId, ProdutoRequestDTO produtoRequestDTO);
        Task<bool> DeleteAsync(int produtosId);
    }
}
