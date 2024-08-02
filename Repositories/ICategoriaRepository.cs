using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}
