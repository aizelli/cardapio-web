using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDBContext _dbContext;

        public ProdutoRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _dbContext.Produtos.ToList();
        }

        public Produto GetById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Produto> GetByPreferido()
        {
            return _dbContext.Produtos.Where(p => p.Produto_Preferido == true).ToList();
        }
    }
}
