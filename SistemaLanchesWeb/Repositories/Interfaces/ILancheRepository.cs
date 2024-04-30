using SistemaLanchesWeb.Context;
using SistemaLanchesWeb.Models;

namespace SistemaLanchesWeb.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int id);


    }
}