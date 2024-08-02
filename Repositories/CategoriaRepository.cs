using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDBContext _dbContext;

        public CategoriaRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _dbContext.Categorias.ToList();
        }
    }
}
