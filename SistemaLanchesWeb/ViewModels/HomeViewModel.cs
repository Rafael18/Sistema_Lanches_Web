using SistemaLanchesWeb.Models;

namespace SistemaLanchesWeb.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
