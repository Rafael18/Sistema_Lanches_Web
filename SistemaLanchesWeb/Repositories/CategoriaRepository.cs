using SistemaLanchesWeb.Context;
using SistemaLanchesWeb.Models;
using SistemaLanchesWeb.Repositories.Interfaces;

namespace SistemaLanchesWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contex;
        public CategoriaRepository(AppDbContext contex)
        {
            _contex = contex;
        }

        public IEnumerable<Categoria> categorias => _contex.Categorias;
    }
}