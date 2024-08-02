using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        IEnumerable<Produto> GetByPreferido();
        Produto GetById(int id);
    }
}
