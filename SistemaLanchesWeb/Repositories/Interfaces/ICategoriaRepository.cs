using SistemaLanchesWeb.Models;

namespace SistemaLanchesWeb.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> categorias { get; }
    }
}
