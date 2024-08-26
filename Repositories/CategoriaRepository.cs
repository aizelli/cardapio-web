using CardapioWeb.Context;
using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDBContext _dbContext;

        public CategoriaRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Categoria categoria)
        {
            try
            {
                _dbContext.Categorias.Add(categoria);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }

        }

        public async Task Delete(Categoria categoria)
        {
            try
            {
                _dbContext.Categorias.Remove(categoria);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<Categoria> GetById(int id)
        {
            return await _dbContext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(Categoria categoria)
        {
            try
            {
                _dbContext.Categorias.Update(categoria);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<List<Categoria>> GetAll()
        {
            return await _dbContext.Categorias.ToListAsync();
        }
    }
}
