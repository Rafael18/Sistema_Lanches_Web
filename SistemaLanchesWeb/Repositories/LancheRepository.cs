using Microsoft.EntityFrameworkCore;
using SistemaLanchesWeb.Context;
using SistemaLanchesWeb.Models;
using SistemaLanchesWeb.Repositories.Interfaces;

namespace SistemaLanchesWeb.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _contex;

        public LancheRepository(AppDbContext contex)
        {
            _contex = contex;
        }
        public IEnumerable<Lanche> Lanches => _contex.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _contex.Lanches.
                                                        Where(l => l.IsLanchePreferido).
                                                        Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
            return _contex.Lanches.FirstOrDefault(l => l.LancheId == id);
        }
    }
}