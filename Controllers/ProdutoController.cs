using CardapioWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CardapioWeb.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult ListarProdutos() { 
            var produtos = _produtoRepository.GetAll();
            return View(produtos);
        }
    }
}
