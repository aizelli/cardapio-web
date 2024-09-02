using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CardapioWeb.Context;
using CardapioWeb.Models;
using CardapioWeb.Repositories;

namespace CardapioWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoriasController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public AdminCategoriasController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        // GET: Admin/AdminCategorias
        public async Task<IActionResult> Index()
        {
            var categorias = await _categoriaRepository.GetAll();
            return View(categorias);
        }

        // GET: Admin/AdminCategorias/Detalhes/5
        public async Task<IActionResult> Detalhes(int id)
        {
            var categoria = await _categoriaRepository.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Admin/AdminCategorias/Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        // POST: Admin/AdminCategorias/Cadastro
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastro([Bind("Id,Nome,Descricao")] Categoria categoria)
        {
            if (categoria != null)
            {
                await _categoriaRepository.Add(categoria);
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Admin/AdminCategorias/Edicao/5
        public async Task<IActionResult> Edicao(int id)
        {
            var categoria = await _categoriaRepository.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // POST: Admin/AdminCategorias/Edicao/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edicao(int id, [Bind("Id,Nome,Descricao")] Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return NotFound();
            }

            if (categoria != null)
            {
                await _categoriaRepository.Update(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        // GET: Admin/AdminCategorias/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var categoria = await _categoriaRepository.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // POST: Admin/AdminCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _categoriaRepository.GetById(id);
            if (categoria != null)
            {
                await _categoriaRepository.Delete(categoria);
            }

            return RedirectToAction("Index");
        }
    }
}
