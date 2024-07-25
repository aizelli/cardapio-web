using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        public IEnumerable<Produto> GetAll();
        public Produto GetById(int id);
        public IEnumerable<Produto> GetByPreferido();
    }
}
