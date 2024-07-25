using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDBContext _dbcontext;

        public ProdutoRepository(AppDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetByPreferido()
        {
            throw new NotImplementedException();
        }
    }
}
