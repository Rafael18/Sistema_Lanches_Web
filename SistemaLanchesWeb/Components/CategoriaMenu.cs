using Microsoft.AspNetCore.Mvc;
using SistemaLanchesWeb.Repositories.Interfaces;

namespace SistemaLanchesWeb.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _cateogiriaRepository;

        public CategoriaMenu(ICategoriaRepository cateogiriaRepository)
        {
            _cateogiriaRepository = cateogiriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _cateogiriaRepository.categorias.OrderBy(o => o.CategoriaNome);
            return View(categorias);
        }
    }
}
