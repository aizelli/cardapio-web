using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { }

    }
}
