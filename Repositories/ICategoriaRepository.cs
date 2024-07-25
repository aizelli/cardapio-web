using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface ICategoriaRepository
    {
        public IEnumerable<Categoria> GetAll();
    }
}
