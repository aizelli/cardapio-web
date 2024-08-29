using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetAll();
        Task<Categoria> GetById(int id);
        Task Add(Categoria categoria);
        Task Update(Categoria categoria);
        Task Delete(Categoria categoria);    
    }
}
